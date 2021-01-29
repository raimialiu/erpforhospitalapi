using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IBillingRepository
    {
        Task<(bool, string, decimal?)> getPatientTarrifByPayor(int accountId, string patientId, int servicecode, int locationId);
        Task<(bool, string, decimal?)> WritePatientRegistrationBill(BillingInvoice billingInvoice);
        Task<(bool, string, decimal?)> WritePatientConsultationBill(BillingInvoice billingInvoice);
        Task<PatientBillDto> GetPatientEncounterBill(int accountId, string patientId, int? encounterId);
        Task<List<BillType>> GetBillingTypes(int accountId);
        Task<List<Tariff>> GetTariffs(int accountId);
        Task<List<ServiceCode>> GetServiceCodes(int accountId, int tariffId, int serviceId);
        Task<BillingInvoice> GetPatientBillingInvoice(int accountId, int billId, string patientId);
        Task UpdateBillInvoice(BillingInvoice billingInvoice);
        Task<(decimal, int)> GetBillingInvoiceOutstanding(int billId, int accountId, decimal billAmount);
        Task<(bool, string, decimal?)> getTarrifByServiceCode(int accountId, int tariffid, int servicecode, int locationId);
        Task AddConsulttionAndRegBillInvoice(BillingInvoice billingInvoice);
        Task<(bool, string, int?)> AddBillInvoice(BillingInvoice billingInvoice);
        Task ClearPatientEncounterBill(int accountId, int encounterId, string patientId, decimal amountPaid, int locationid);
        Task<(bool, string, decimal?)> getPatientDrugTarriff(int accountId, string patientId, int drugid, int locationId);
        Task<(bool, string, decimal?)> getDrugTarrifByDrugId(int accountId, int tariffid, int drugid, int locationId);

    }

    public class BillingRepository : IBillingRepository
    {
        private readonly DataContext _context;
        private readonly IPayerInsuranceRepository _payerInsuranceRepository;
        private readonly ICheckInRepository _checkInRepository;
        public BillingRepository(DataContext context, IPayerInsuranceRepository payerInsuranceRepository, ICheckInRepository checkInRepository)
        {
            _context = context;
            _payerInsuranceRepository = payerInsuranceRepository;
            _checkInRepository = checkInRepository;
        }


        public async Task<(bool, string, decimal?)> getPatientTarrifByPayor (int accountId, string patientId, int servicecode, int locationId)
        {
            var patientPlantype = await _context.Patient.Where(p => p.Patientid == patientId && p.ProviderId == accountId).Select(r => r.Plantype).FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(patientPlantype))
            {
                return (false, "plan type not available for this patient", null);
            }

            var tariffplan = await _context.TarriffPlan.Where(t => t.planid == int.Parse(patientPlantype)).FirstOrDefaultAsync();

            if (tariffplan == null)
            {
                return (false, "tariff plan not found for patient plan type", null);
            }

            var tariffServiceCode = await _context.TariffServiceCode.Where(ts => ts.serviceid == servicecode && ts.tariffid == tariffplan.tariffid).FirstOrDefaultAsync();

            if (tariffServiceCode == null)
            {
                return (false, "tariff not found for this patient plan type and service requested", null);
            }

            var location = await _context.Location.Where(l => l.Locationid == locationId && l.AccountID == accountId).FirstOrDefaultAsync();

            if (location.ispremium)
            {
                return (true, "Success", tariffServiceCode.premiumtariffamount);

            }
            else
            {
                return (true, "Success", tariffServiceCode.tariffamount);
            }

        }
        
        public async Task<(bool, string, decimal?)> getTarrifByServiceCode (int accountId, int tariffid, int servicecode, int locationId)
        {
            var tariffServiceCode = await _context.TariffServiceCode.Where(ts => ts.serviceid == servicecode && ts.tariffid == tariffid).FirstOrDefaultAsync();

            if (tariffServiceCode == null)
            {
                return (false, "tariff not found for this service requested", null);
            }

            var location = await _context.Location.Where(l => l.Locationid == locationId && l.AccountID == accountId).FirstOrDefaultAsync();

            if (location.ispremium)
            {
                return (true, "Success", tariffServiceCode.premiumtariffamount);

            }
            else
            {
                return (true, "Success", tariffServiceCode.tariffamount);
            }

        }
        
        public async Task<(bool, string, decimal?)> getDrugTarrifByDrugId(int accountId, int tariffid, int drugid, int locationId)
        {
            var tariffServiceCode = await _context.TariffServiceCode.Where(ts => ts.serviceid == drugid && ts.tariffid == tariffid).FirstOrDefaultAsync();

            if (tariffServiceCode == null)
            {
                return (false, "tariff not found for this service requested", null);
            }

            var location = await _context.Location.Where(l => l.Locationid == locationId && l.AccountID == accountId).FirstOrDefaultAsync();

            if (location.ispremium)
            {
                return (true, "Success", tariffServiceCode.premiumtariffamount);

            }
            else
            {
                return (true, "Success", tariffServiceCode.tariffamount);
            }

        }
        
        public async Task<(bool, string, decimal?)> getPatientDrugTarriff (int accountId, string patientId, int drugid, int locationId)
        {
            var patientPlantype = await _context.Patient.Where(p => p.Patientid == patientId && p.ProviderId == accountId).Select(r => r.Plantype).FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(patientPlantype))
            {
                return (false, "plan type not available for this patient", null);
            }

            var tariffplan = await _context.TarriffPlan.Where(t => t.planid == int.Parse(patientPlantype)).FirstOrDefaultAsync();

            if (tariffplan == null)
            {
                return (false, "tariff plan not found for patient plan type", null);
            }

            var tariffServiceCode = await _context.TariffServiceCode.Where(ts => ts.drugid == drugid && ts.tariffid == tariffplan.tariffid).FirstOrDefaultAsync();

            if (tariffServiceCode == null)
            {
                return (false, "tariff not found for this patient plan type and service requested", null);
            }

            var location = await _context.Location.Where(l => l.Locationid == locationId && l.AccountID == accountId).FirstOrDefaultAsync();

            if (location.ispremium)
            {
                return (true, "Success", tariffServiceCode.premiumtariffamount);

            }
            else
            {
                return (true, "Success", tariffServiceCode.tariffamount);
            }
        }

        public async Task<(bool, string, decimal?)> WritePatientRegistrationBill(BillingInvoice billingInvoice)
        {
            var patient = await _context.Patient.Where(p => p.Patientid == billingInvoice.patientid && p.ProviderId == billingInvoice.ProviderID).FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(patient.Plantype))
            {
                return (false, "plan type not available for this patient", null);
            }

            if (int.Parse(patient.Plantype) == 32 || int.Parse(patient.Plantype) == 430)
            {
                //var tariffServiceCode = await (from r in _context.TariffServiceCode
                //                               join s in _context.ServiceCode on r.serviceid equals s.serviceid
                //                               where s.servicename.Contains("Registration") && r.tariffid == 38
                //                               select new
                //                               {
                //                                   r.tariffamount,
                //                                   r.premiumtariffamount,
                //                                   serviceName = s.servicename,
                //                                   s.serviceid,
                //                                   r.tariffid
                //                               }).ToListAsync();

                //var registration = tariffServiceCode.Where(e => e.serviceid == 3209).FirstOrDefault();
                var registrationTariff = await getPatientTarrifByPayor((int)billingInvoice.ProviderID, billingInvoice.patientid, 3209, (int)billingInvoice.locationid);

                var location = await _context.Location.Where(l => l.Locationid == billingInvoice.locationid && l.AccountID == billingInvoice.ProviderID).FirstOrDefaultAsync();

                if (location.ispremium)
                {
                    billingInvoice.billamount = registrationTariff.Item3;
                    billingInvoice.amounttopay = registrationTariff.Item3;
                }
                else
                {
                    billingInvoice.billamount = registrationTariff.Item3;
                    billingInvoice.amounttopay = registrationTariff.Item3;
                }

                //billingInvoice.billamount = registrationTariff.Item3;
                //billingInvoice.amounttopay = registrationTariff.Item3;


                billingInvoice.plantypeid = null;// int.Parse(patient.Plantype);
                billingInvoice.tariffid = 38;
                billingInvoice.servicecode = 3209.ToString();
                billingInvoice.unit = 1;
                billingInvoice.unitcharge = billingInvoice.unit * billingInvoice.billamount;
                billingInvoice.payortypeid = !string.IsNullOrEmpty(patient.Payor) ? (int?)int.Parse(patient.Payor) : null;


                await AddConsulttionAndRegBillInvoice(billingInvoice);
                return (true, "success", billingInvoice.billamount);
            }
            else
            {
                return (false, "Patient plan type doesn't match a private plan", null);
            }

        }

        public async Task<(bool, string, decimal?)> WritePatientConsultationBill(BillingInvoice billingInvoice)
        {
            var patient = await _context.Patient.Where(p => p.Patientid == billingInvoice.patientid && p.ProviderId == billingInvoice.ProviderID).FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(patient.Plantype))
            {
                return (false, "plan type not available for this patient", null);
            }

            if (int.Parse(patient.Plantype) == 32 || int.Parse(patient.Plantype) == 430)
            {
                var tariffServiceCode = await (from r in _context.TariffServiceCode
                                               join s in _context.ServiceCode on r.serviceid equals s.serviceid
                                               where s.servicename.Contains("Consultation") && r.tariffid == 38
                                               select new
                                               {
                                                   r.tariffamount,
                                                   r.premiumtariffamount,
                                                   serviceName = s.servicename,
                                                   s.serviceid,
                                                   r.tariffid
                                               }).ToListAsync();

                var registration = tariffServiceCode.Where(e => e.serviceid == 137).FirstOrDefault();
                //var registrationTariff = await getPatientTarrifByPayor((int)billingInvoice.ProviderID, billingInvoice.patientid, 3209, (int)billingInvoice.locationid);

                var location = await _context.Location.Where(l => l.Locationid == billingInvoice.locationid && l.AccountID == billingInvoice.ProviderID).FirstOrDefaultAsync();

                if (location.ispremium)
                {
                    billingInvoice.billamount = registration.premiumtariffamount;
                    billingInvoice.amounttopay = registration.premiumtariffamount;
                }
                else
                {
                    billingInvoice.billamount = registration.tariffamount;
                    billingInvoice.amounttopay = registration.tariffamount;
                }

                //var registration = tariffServiceCode.Where(e => e.serviceid == 3209).FirstOrDefault();
                //var registrationTariff = await getPatientTarrifByPayor((int)billingInvoice.ProviderID, billingInvoice.patientid, 137, (int)billingInvoice.locationid);

                //billingInvoice.billamount = registrationTariff.Item3;
                //billingInvoice.amounttopay = registrationTariff.Item3;

                billingInvoice.plantypeid = null;// int.Parse(patient.Plantype);
                billingInvoice.tariffid = 38;
                billingInvoice.servicecode = 137.ToString();
                billingInvoice.unit = 1;
                billingInvoice.unitcharge = billingInvoice.unit * billingInvoice.billamount;
                billingInvoice.payortypeid = !string.IsNullOrEmpty(patient.Payor) ? (int?)int.Parse(patient.Payor): null;
                //billingInvoice.servicecode = tariffServiceCode.serviceid;

                await AddConsulttionAndRegBillInvoice(billingInvoice);
                return (true, "success", billingInvoice.billamount);
            }
            else
            {
                return (false, "Patient plan type doesn't match a private plan", null);
            }

        }
        
        public async Task UpdateBillInvoice(BillingInvoice billingInvoice)
        {
            billingInvoice.isadjusted = true;
            _context.BillingInvoice.Update(billingInvoice);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddConsulttionAndRegBillInvoice(BillingInvoice billingInvoice)
        {
            var encounterCheck = await _checkInRepository.GetPatientLatestEncounter(billingInvoice.patientid, (int)billingInvoice.ProviderID);

            if (encounterCheck == null)
            {
                CheckIn checkIn = new CheckIn
                {
                    ProviderId = (int)billingInvoice.ProviderID,
                    CheckInDate = DateTime.Now,
                    CheckOutDate = null,
                    IsCheckedIn = false,
                    IsCheckedOut = false,
                    Locationid = (int)billingInvoice.locationid,
                    Patientid = billingInvoice.patientid,
                    IsActive = false
                };

                var _checkIn = await _context.AddAsync(checkIn);
                await _context.SaveChangesAsync();

                billingInvoice.encounterId = _checkIn.Entity.Encounterid;
            }
            else
            {
                billingInvoice.encounterId = encounterCheck.EncounterId;
            }

            
            billingInvoice.dateadded = DateTime.Now;
            
            _context.BillingInvoice.Add(billingInvoice);
            await _context.SaveChangesAsync();
        }
        
        public async Task<(bool, string, int?)> AddBillInvoice(BillingInvoice billingInvoice)
        {
            if(billingInvoice.encounterId == null || billingInvoice.encounterId <= 0)
            {
                var currentEncounter = await _checkInRepository.GetPatientLatestEncounter(billingInvoice.patientid, (int)billingInvoice.ProviderID);

                if (currentEncounter == null)
                {
                    CheckIn checkIn = new CheckIn
                    {
                        ProviderId = (int)billingInvoice.ProviderID,
                        CheckInDate = DateTime.Now,
                        CheckOutDate = null,
                        IsCheckedIn = false,
                        IsCheckedOut = false,
                        Locationid = (int)billingInvoice.locationid,
                        Patientid = billingInvoice.patientid,
                        IsActive = false
                    };

                    var _checkIn = await _context.AddAsync(checkIn);
                    //await _context.SaveChangesAsync();

                    billingInvoice.encounterId = _checkIn.Entity.Encounterid;
                }
                else
                {
                    billingInvoice.encounterId = currentEncounter.EncounterId;
                }

                return (false, "Please pass in encounterid", null);
            }

            var patient = await _context.Patient.Where(p => p.Patientid == billingInvoice.patientid && p.ProviderId == billingInvoice.ProviderID).FirstOrDefaultAsync();

            var tariffplan = await _context.TarriffPlan.Where(t => t.planid == int.Parse(patient.Plantype)).FirstOrDefaultAsync();
            var plan = await _context.Plan.Where(t => t.Id == int.Parse(patient.Plantype)).FirstOrDefaultAsync();

            var invoiceamount = await getTarrifByServiceCode((int)billingInvoice.ProviderID, (int)tariffplan.tariffid, int.Parse(billingInvoice.servicecode), (int)billingInvoice.locationid);

            if (!invoiceamount.Item1)
            {
                return (false, "tariff not found for this service requested", null);
            }

            if(billingInvoice.unit == null || billingInvoice.unit == 0)
            {
                billingInvoice.unit = 1;
            }

            billingInvoice.dateadded = DateTime.Now;
            billingInvoice.plantypeid = //plan != null ? (int?)plan.Id : null;
            billingInvoice.payortypeid = !string.IsNullOrEmpty(patient.Payor) ? (int?)int.Parse(patient.Payor) : null;
            billingInvoice.tariffid = tariffplan != null ? tariffplan.tariffid : null;
            billingInvoice.billamount = invoiceamount.Item3 * billingInvoice.unit;
            billingInvoice.amounttopay = invoiceamount.Item3 * billingInvoice.unit;
            billingInvoice.unitcharge = invoiceamount.Item3;
            
            var billId = _context.BillingInvoice.Add(billingInvoice);
            await _context.SaveChangesAsync();
            return (true, "success", billId.Entity.billid);
        }

        public async Task<PatientBillDto> GetPatientEncounterBill (int accountId, string patientId, int? encounterId)
        {
            // get patient information
            var patient = await _context.Patient.Where(p => p.Patientid == patientId && p.ProviderId == accountId).FirstOrDefaultAsync();

            //  get encounter details
            var encounterDetails = await _context.CheckIn.Where(e => e.Encounterid == encounterId && e.ProviderId == accountId).FirstOrDefaultAsync();

            // get patient bill invoice by patientId and encounterId
            var billingInvoice = await _context.BillingInvoice.Where(b => b.ProviderID == accountId && b.encounterId == encounterId && b.patientid == patientId)
                .Select(r => new BillingInvoiceDto()
                {
                    billamount = r.billamount,
                    billid = r.billid,
                    discount = r.discount,
                    encounterId = r.encounterId,
                    locationid = r.locationid,
                    patientid = r.patientid,
                    ProviderID = r.ProviderID,
                    servicecode = r.servicecode,
                    unit = r.unit,
                    unitcharge = r.unitcharge
                    
                }).ToListAsync();

            // calculate patient outstanding bill
            foreach (var item in billingInvoice)
            {
                var outstandingAndInvoiceCount = await GetBillingInvoiceOutstanding(item.billid, (int)item.ProviderID, (decimal)item.billamount);

                item.Outstanding = outstandingAndInvoiceCount.Item1;

                if (item.Outstanding > 0)
                {
                    item.isbilledclosed = false;
                }
                else
                {
                    if (outstandingAndInvoiceCount.Item2 == 0)
                    {
                        item.Outstanding = item.billamount;
                        item.isbilledclosed = false;

                    }else if (outstandingAndInvoiceCount.Item2 > 0)
                    {
                        item.isbilledclosed = true;
                    }
                    
                }
                var serviceId = int.Parse(item.servicecode);
                item.Servicename = _context.ServiceCode.Where(p => p.serviceid == serviceId && p.ProviderID == accountId).Select(w => w.servicename).FirstOrDefault();
            }

            // retreive patient accountcategory
            var patientAccountCategory = await _payerInsuranceRepository.GetPatientPayerInfo(patient.Payor);

            PatientBillDto patientBillDto = new PatientBillDto()
            {
                encounterid = encounterDetails.Encounterid,
                patientAccountCategory = patientAccountCategory.AccountCategory != null ? patientAccountCategory.AccountCategory.Accountcattype : "",
                encounterdate = encounterDetails.CheckInDate,
                patientname = patient.Lastname + " " + patient.Firstname,
                totalbilledamount = (decimal)billingInvoice.Sum(e => e.billamount),
                totaloutstanding = (decimal)billingInvoice.Sum(e => e.Outstanding),
                invoices = billingInvoice,
                billid = billingInvoice.Select(b => b.billid).FirstOrDefault()
            };

            return patientBillDto;

        }

        public async Task<(decimal, int)> GetBillingInvoiceOutstanding(int billId, int accountId, decimal billAmount)
        {
            var invoiceReceipts = await _context.BillingReceipt.Where(r => r.billid == billId && r.ProviderID == accountId).ToListAsync();

            if (invoiceReceipts.Count > 0)
            {
                var invoiceTotalCreditAmount = invoiceReceipts.Select(k => k.creditamount).Sum();
                var totalOutstanding = billAmount - invoiceTotalCreditAmount;
                return (totalOutstanding, invoiceReceipts.Count);

            }
            else
            {
                return (0.00m, 0);
            }
        }

        public async Task<List<BillType>> GetBillingTypes(int accountId)
        {
            var billType = await _context.BillType.Where(r => r.ProviderID == accountId).OrderBy(p => p.billtypename).ToListAsync();
            return billType;

           
        }

        public async Task<List<Tariff>> GetTariffs(int accountId)
        {
            var tariffs = await _context.Tariff.Where(r => r.ProviderId == accountId).OrderBy(p => p.Tariffname).ToListAsync();
            return tariffs;

           
        }

        public async Task<List<ServiceCode>> GetServiceCodes(int accountId, int tariffId, int serviceId)
        {
            var tariffServiceCodes = await (from r in _context.TariffServiceCode
                                            join s in _context.ServiceCode on r.serviceid equals s.serviceid
                                            where r.tariffid == tariffId
                                            select new ServiceCode
                                            {
                                                serviceid = s.serviceid,
                                                servicename = s.servicename,
                                                ProviderID = s.ProviderID,
                                                servicecategoryid = s.servicecategoryid

                                            }).ToListAsync();

            //var tariffs = await _context.ServiceCode.Where(r => r.ProviderID == accountId && r.serviceid == serviceId).OrderBy(p => p.servicename).FirstOrDefaultAsync();

            //tariffServiceCodes.Add(tariffs);

            return tariffServiceCodes.OrderBy(p => p.servicename).ToList();


            //var tariffs = await _context.ServiceCode.Where(r => r.ProviderID == accountId).OrderBy(p => p.servicename).ToListAsync();
            //return tariffs;


        }
        
        public async Task<BillingInvoice> GetPatientBillingInvoice(int accountId, int billId, string patientId)
        {
            var billlingInvoice = await _context.BillingInvoice.Where(r => r.ProviderID == accountId && r.billid == billId && r.patientid == patientId).FirstOrDefaultAsync();
            return billlingInvoice;

           
        }
        
        public async Task ClearPatientEncounterBill(int accountId, int encounterId, string patientId, decimal amountPaid, int locationid)
        {
            var encounterBilllingInvoice = await _context.BillingInvoice.Where(r => r.ProviderID == accountId && r.encounterId == encounterId && r.patientid == patientId).ToListAsync();

            var patient = await _context.Patient.Where(p => p.Patientid == patientId && p.ProviderId == accountId).FirstOrDefaultAsync();

            var whatIsLeftOfAmountPaid = (decimal?)amountPaid;

            if (encounterBilllingInvoice.Count > 0)
            {

                foreach (var invoice in encounterBilllingInvoice)
                {
                    var receipt = await _context.BillingReceipt.Where(p => p.billid == invoice.billid && p.encounterId == invoice.encounterId && p.patientid == invoice.patientid).ToListAsync();

                    if (whatIsLeftOfAmountPaid > 0)
                    {
                        if (receipt.Count > 0)
                        {
                            var totalSum = receipt.Sum(i => i.creditamount);

                            if (totalSum < invoice.billamount)
                            {
                                var balanceTopay = invoice.billamount - totalSum;

                                if (whatIsLeftOfAmountPaid > balanceTopay)
                                {
                                    var billToclear = whatIsLeftOfAmountPaid - balanceTopay;

                                    BillingReceipt billingReceipt = new BillingReceipt()
                                    {
                                        billid = invoice.billid,
                                        creditamount = (decimal)billToclear,
                                        encounterId = encounterId,
                                        dateadded = DateTime.Now,
                                        patientid = patientId,
                                        ProviderID = accountId,
                                        receiptdate = DateTime.Now,
                                        tariffid = invoice.tariffid,
                                        //plantypeid = patient != null ? (int?)int.Parse(patient.Plantype) : null,
                                        locationid = locationid
                                    };

                                    await CreateReceipt(billingReceipt);
                                    whatIsLeftOfAmountPaid = whatIsLeftOfAmountPaid - billToclear;
                                }

                                if (whatIsLeftOfAmountPaid <= balanceTopay && whatIsLeftOfAmountPaid > 0)
                                {
                                    //var billToclear = whatIsLeftOfAmountPaid - balanceTopay;

                                    BillingReceipt billingReceipt = new BillingReceipt()
                                    {
                                        billid = invoice.billid,
                                        creditamount = (decimal)whatIsLeftOfAmountPaid,
                                        encounterId = encounterId,
                                        dateadded = DateTime.Now,
                                        patientid = patientId,
                                        ProviderID = accountId,
                                        receiptdate = DateTime.Now,
                                        tariffid = invoice.tariffid,
                                        //plantypeid = patient != null ? (int?)int.Parse(patient.Plantype) : null,
                                        locationid = locationid
                                    };

                                    await CreateReceipt(billingReceipt);
                                    whatIsLeftOfAmountPaid = 0;
                                }
                            }
                        }
                        else
                        {
                            if (whatIsLeftOfAmountPaid > invoice.billamount)
                            {
                                var balanceTopay = whatIsLeftOfAmountPaid - invoice.billamount;

                                var billToclear = whatIsLeftOfAmountPaid - balanceTopay;

                                BillingReceipt billingReceipt = new BillingReceipt()
                                {
                                    billid = invoice.billid,
                                    creditamount = (decimal)invoice.billamount,
                                    encounterId = encounterId,
                                    dateadded = DateTime.Now,
                                    patientid = patientId,
                                    ProviderID = accountId,
                                    receiptdate = DateTime.Now,
                                    tariffid = invoice.tariffid,
                                    //plantypeid = patient != null ? (int?)int.Parse(patient.Plantype) : null,
                                    locationid = locationid
                                };

                                await CreateReceipt(billingReceipt);
                                whatIsLeftOfAmountPaid = balanceTopay;
                            }

                            if (whatIsLeftOfAmountPaid <= invoice.billamount)
                            {
                                //var billToclear = whatIsLeftOfAmountPaid - balanceTopay;

                                BillingReceipt billingReceipt = new BillingReceipt()
                                {
                                    billid = invoice.billid,
                                    creditamount = (decimal)whatIsLeftOfAmountPaid,
                                    encounterId = encounterId,
                                    dateadded = DateTime.Now,
                                    patientid = patientId,
                                    ProviderID = accountId,
                                    receiptdate = DateTime.Now,
                                    tariffid = invoice.tariffid,
                                    //plantypeid = patient != null ? (int?)int.Parse(patient.Plantype) : null,
                                    locationid = locationid
                                };

                                await CreateReceipt(billingReceipt);
                                whatIsLeftOfAmountPaid = 0;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                    
            }

        }
            

           
        

        public async Task CreateReceipt (BillingReceipt billingReceipt)
        {
            await _context.BillingReceipt.AddAsync(billingReceipt);
            await _context.SaveChangesAsync();
        }

    }
}
