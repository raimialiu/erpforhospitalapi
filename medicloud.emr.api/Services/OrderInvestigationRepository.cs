using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IOrderInvestigationRepository
    {
        Task<(bool, string)> AddConsultationOrder(AddConsultationOrderDto model);
        Task AddConsultationOrderFavourites(ConsultationOrderFavorites model);
        Task DeleteConsultationOrder(int accountId, int consultationOrderId);
        Task<List<ConsultationOrderFavouriteDto>> GetConsultationOrdersFavourites(int accountId, int doctorId, string searchword);
        Task<List<ConsultationOrderDetailsDto>> getConsultationOrderByPatientIdDateRange(int accountId, string patientNo, DateTime startDate, DateTime endDate);
        Task<List<ConsultationOrderDetailsDto>> getConsultationOrderByPatientId(int accountId, string patientNo);
    }

    public class OrderInvestigationRepository : IOrderInvestigationRepository
    {
        private readonly DataContext _context;
        private readonly IBillingRepository _billingRepository;
        public OrderInvestigationRepository(DataContext context, IBillingRepository billingRepository)
        {
            _context = context;
            _billingRepository = billingRepository;
        }


        public async Task<(bool, string)> AddConsultationOrder(AddConsultationOrderDto model)
        {
            // add bill
            List<int> insertedBillId = new List<int>();
            int orderId = 0;

            try
            {
                foreach (var item in model.consultationOrderDetails)
                {
                    if (item.unit == null || string.IsNullOrEmpty(item.unit))
                    {
                        item.unit = "1";
                    }

                    BillingInvoice billingInvoice = new BillingInvoice()
                    {
                        patientid = model.consultationOrder.Patientid,
                        encounterId = model.consultationOrder.EncounterId,
                        servicecode = item.serviceId.ToString(),
                        unit = int.Parse(item.unit),
                        locationid = model.consultationOrder.Locationid,
                        ProviderID = model.consultationOrder.ProviderId,
                        diagnosisid = item.DiagnosisId,
                        encodedby = item.EncodedBy
                    };
                    try
                    {
                        var inserted = await _billingRepository.AddBillInvoice(billingInvoice, null);
                        if (!inserted.Item1)
                        {
                            return (inserted.Item1, inserted.Item2);
                        }
                        insertedBillId.Add((int)inserted.Item3);

                        item.InvoiceId = inserted.Item3;
                    }
                    catch (Exception ex)
                    {
                        foreach (var billid in insertedBillId)
                        {
                            var bill = await _context.BillingInvoice.Where(y => y.billid == billid).FirstOrDefaultAsync();
                            _context.BillingInvoice.Remove(bill);
                        }
                        /// delete all inserted billing_Invoice
                        throw new Exception("An error occured while creating consultation order bills please try again or contact suppport");
                    }

                }

                model.consultationOrder.EncodedDate = DateTime.Now;
                model.consultationOrder.ordertypeid = null;
                model.consultationOrder.ordercategoryid = null;
                var conOrder = await _context.ConsultationOrders.AddAsync(model.consultationOrder);
                await _context.SaveChangesAsync();
                orderId = conOrder.Entity.Id;

                foreach (var item in model.consultationOrderDetails)
                {

                    item.investigationdate = item.investigationdate != null ? item.investigationdate.Value.AddHours(1) : DateTime.Now;
                    item.investigationdate = new DateTime(item.investigationdate.Value.Year, item.investigationdate.Value.Month, item.investigationdate.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                    item.investigationdate = item.investigationdate;
                    item.investigationdate = new DateTime(item.investigationdate.Value.Year, item.investigationdate.Value.Month, item.investigationdate.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    item.encounterid = model.consultationOrder.EncounterId;
                    item.patientid = model.consultationOrder.Patientid;
                    item.orderId = conOrder.Entity.Id;
                    item.InvoiceId = insertedBillId[0];

                    await _context.ConsultationOrderDetails.AddRangeAsync(item);
                }
                try
                {
                    await _context.SaveChangesAsync();
                    return (true, "success!");
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured while creating consultation order details please try again or contact suppport");
                }
                
            }
            catch(Exception ex) 
            {
                if (orderId > 0)
                {
                    var order = await _context.ConsultationOrders.Where(e => e.Id == orderId && e.ProviderId == model.consultationOrder.ProviderId).FirstOrDefaultAsync();
                    _context.ConsultationOrders.Remove(order);
                    await _context.SaveChangesAsync();
                }

                if (insertedBillId.Count() > 0)
                {
                    foreach (var billid in insertedBillId)
                    {
                        var bill = await _context.BillingInvoice.Where(y => y.billid == billid).FirstOrDefaultAsync();
                        _context.BillingInvoice.Remove(bill);
                        await _context.SaveChangesAsync();
                    }
                }

                await _context.SaveChangesAsync();
                return (false, ex.Message);
                
            }

        }


        public async Task AddConsultationOrderFavourites(ConsultationOrderFavorites model)
        {
            var check = await _context.ConsultationOrderFavorites.Where(e => e.serviceid == model.serviceid && e.DoctorId == model.DoctorId && e.ProviderID == model.ProviderID).FirstOrDefaultAsync();

            if (check != null)
            {
               // check.s = DateTime.Now;

                //_context.Update(check);
                //await _context.SaveChangesAsync();
            }
            else
            {
                var result = _context.ConsultationOrderFavorites.Add(model);
                await _context.SaveChangesAsync();
            }



        }


        public async Task<List<ConsultationOrderDetailsDto>> getConsultationOrderByPatientId(int accountId, string patientNo)
        {
            var result = await _context.ConsultationOrderDetails.Where(c => c.ProviderID == accountId && c.patientid == patientNo)
                .Select(a => new ConsultationOrderDetailsDto()
                {
                    Id = a.Id,
                    ordercategoryid = a.ordercategoryid,
                    EncodedBy = a.EncodedBy,
                    Isactive = a.Isactive,
                    encounterid = a.encounterid,
                    investigationdate = a.investigationdate,
                    //orderDate = a.orderDate,
                    DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == a.DoctorId).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                    orderno = a.orderId.ToString(),
                    ordertypeid = a.ordertypeid,
                    ProviderID = a.ProviderID,
                    patientid = a.patientid,
                    Remark = a.Remark,
                    serviceName = _context.OrderDetails.Where(o => o.providerId == a.ProviderID && o.serviceid == a.serviceId).Select(o => o.servicename).FirstOrDefault(),
                    OrderCategoryName = _context.OrderCategory.Where(o => o.ProviderID == a.ProviderID && o.Ordercategoryid == a.ordercategoryid).Select(o => o.Ordercategory1).FirstOrDefault(),
                    OrderTypeName = _context.OrderType.Where(o => o.ProviderID == a.ProviderID && o.Ordertypeid == a.ordertypeid).Select(o => o.Ordername).FirstOrDefault(),
                    LocationName = _context.Location.Where(o => o.Locationid == a.LocationId).Select(o => o.Locationname).FirstOrDefault()
                }).OrderByDescending(r => r.investigationdate).ToListAsync();

            return result;

        }


        public async Task<List<ConsultationOrderDetailsDto>> getConsultationOrderByPatientIdToday(int accountId, string patientNo)
        {
            var result = await _context.ConsultationOrderDetails.Where(c => c.ProviderID == accountId && c.patientid == patientNo && c.investigationdate.Value.Date == DateTime.Today.Date)
                .Select(a => new ConsultationOrderDetailsDto()
                {
                    Id = a.Id,
                    ordercategoryid = a.ordercategoryid,
                    EncodedBy = a.EncodedBy,
                    Isactive = a.Isactive,
                    encounterid = a.encounterid,
                    investigationdate = a.investigationdate,
                    //orderDate = a.orderDate,
                    DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == a.DoctorId).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                    orderno = a.orderId.ToString(),
                    ordertypeid = a.ordertypeid,
                    ProviderID = a.ProviderID,
                    patientid = a.patientid,
                    Remark = a.Remark,
                    serviceName = _context.OrderDetails.Where(o => o.providerId == a.ProviderID && o.serviceid == a.serviceId).Select(o => o.servicename).FirstOrDefault(),
                    OrderCategoryName = _context.OrderCategory.Where(o => o.ProviderID == a.ProviderID && o.Ordercategoryid == a.ordercategoryid).Select(o => o.Ordercategory1).FirstOrDefault(),
                    OrderTypeName = _context.OrderType.Where(o => o.ProviderID == a.ProviderID && o.Ordertypeid == a.ordertypeid).Select(o => o.Ordername).FirstOrDefault(),
                    LocationName = _context.Location.Where(o => o.Locationid == a.LocationId).Select(o => o.Locationname).FirstOrDefault()
                }).OrderByDescending(r => r.investigationdate).ToListAsync();

            return result;

        }


        public async Task DeleteConsultationOrder(int accountId, int consultationOrderId)
        {

            var result = await _context.ConsultationOrders.Where(c => c.Id == consultationOrderId && c.ProviderId == accountId).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.ConsultationOrders.Remove(result);
                await _context.SaveChangesAsync();
            }


        }

        public async Task<List<ConsultationOrderDetailsDto>> getConsultationOrderByPatientIdDateRange(int accountId, string patientNo, DateTime startDate, DateTime endDate)
        {
            var result = await _context.ConsultationOrderDetails.Where(c => c.ProviderID == accountId && c.patientid == patientNo && c.investigationdate.Value.Date >= startDate.Date && c.investigationdate.Value.Date <= endDate)
                .Select(a => new ConsultationOrderDetailsDto()
                {
                    Id = a.Id,
                    ordercategoryid = a.ordercategoryid,
                    EncodedBy = a.EncodedBy,
                    Isactive = a.Isactive,
                    encounterid = a.encounterid,
                    investigationdate = a.investigationdate,
                    //orderDate = a.orderDate,
                    DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == a.DoctorId).Select(o => o.Lastname +" "+ o.Firstname).FirstOrDefault(),
                    orderno = a.orderId.ToString(),
                    ordertypeid = a.ordertypeid,
                    ProviderID = a.ProviderID,
                    patientid = a.patientid,
                    Remark = a.Remark,
                    serviceName = _context.OrderDetails.Where(o => o.providerId == a.ProviderID && o.serviceid == a.serviceId).Select(o => o.servicename).FirstOrDefault(),
                    OrderCategoryName = _context.OrderCategory.Where(o => o.ProviderID == a.ProviderID && o.Ordercategoryid == a.ordercategoryid).Select(o => o.Ordercategory1).FirstOrDefault(),
                    OrderTypeName = _context.OrderType.Where(o => o.ProviderID == a.ProviderID && o.Ordertypeid == a.ordertypeid).Select(o => o.Ordername).FirstOrDefault(),
                    LocationName = _context.Location.Where(o => o.Locationid == a.LocationId).Select(o => o.Locationname).FirstOrDefault()
                }).OrderByDescending(r => r.investigationdate).ToListAsync();

            return result;

        }

        public async Task<List<ConsultationOrderFavouriteDto>> GetConsultationOrdersFavourites(int accountId, int doctorId, string searchword)
        {
            if (!string.IsNullOrEmpty(searchword))
            {
                var favourites = await _context.ConsultationOrderFavorites.Where(e => e.ProviderID == accountId && e.DoctorId == doctorId)
                    .Select(r => new ConsultationOrderFavouriteDto()
                    {
                        serviceName = _context.OrderDetails.Where(d => d.providerId == accountId && d.serviceid == r.serviceid).Select(m => m.servicename).FirstOrDefault(),
                        DoctorId = r.DoctorId,
                        serviceid = r.serviceid,
                        FavoriteId = r.FavoriteId,
                        LocationId = r.LocationId,
                        ProviderID = r.ProviderID
                    }).ToListAsync();

                var search = favourites.Where(f => f.serviceName.ToUpper().Contains(searchword.ToUpper())).OrderBy(p => p.serviceName).ToList();
                return search;

            }
            else
            {
                var favourites = await _context.ConsultationOrderFavorites.Where(e => e.ProviderID == accountId && e.DoctorId == doctorId)
                    .Select(r => new ConsultationOrderFavouriteDto()
                    {
                        serviceName = _context.OrderDetails.Where(d => d.providerId == accountId && d.serviceid == r.serviceid).Select(m => m.servicename).FirstOrDefault(),
                        DoctorId = r.DoctorId,
                        serviceid = r.serviceid,
                        FavoriteId = r.FavoriteId,
                        LocationId = r.LocationId,
                        ProviderID = r.ProviderID
                    }).ToListAsync();

                return favourites;
            }

        }

    }
}
