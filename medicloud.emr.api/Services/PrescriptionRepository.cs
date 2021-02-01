using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.DTOs;


namespace medicloud.emr.api.Services
{
    public interface IPrescriptionRepository
    {
        Task<List<Drug>> GetDrugs(int formularyid, int genericid);

        Task<List<Store>> GetStore(int locationid);
        Task<List<OrderPriority>> GetOrderPriority(int locationid);

                          Task<List<DrugGeneric>> GetDrugGeneric();

        Task<List<DrugUnit>> GetDrugUnit();

        Task<List<DrugDoseForm>> GetDrugDoseForms();

        Task<List<DrugRoute>> GetDrugRoute();

        Task<List<DrugFrequency>> GetDrugFrequency();

        Task<List<DrugFoodrelation>> GetDrugFoodRelation(int locationid);

        //Task AddFavourites(PrescriptionDTO pfavouritesDTO);

        ////Task RemovePrescriptionFavourite(ConsultationPrescriptionFavorites pfavouritesDTO);
        //Task AddConsultation(PrescriptionDTO pfavouritesDTO);
        //Task AddDetails(PrescriptionDTO pfavouritesDTO);


        //Task<List<ConsultationPrescriptionDetails>> GetPreviousMedication(string patientid);
    }

    public class PrescriptionRepository : IPrescriptionRepository
    {

        private readonly DataContext _context;

        public PrescriptionRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Drug>> GetDrugs(int formularyid, int genericid)
        {
            var druglist = await _context.Drug.Where(p=> p.Classid == formularyid && p.Drugcategoryid == genericid)
                .Select(r => new Drug
                {
                    Name = r.Name,
                    Id = r.Id,
                    Drugcode = r.Drugcode
                }).OrderByDescending(rq => rq.Name).ToListAsync();
            return druglist;
        }

        public async Task<List<Store>> GetStore(int locationid)
        {
            var druglist = await _context.Store.Where(p => p.Locationid == locationid)
                .Select(r => new Store
                {
                    Departmentname = r.Departmentname,
                    DepartmentId = r.DepartmentId
                }).OrderByDescending(rq => rq.Departmentname).ToListAsync();
            return druglist;
        }


        public async Task<List<OrderPriority>> GetOrderPriority(int locationid)
        {
            var druglist = await _context.OrderPriority.Where(p => p.Isactive == 1 && p.Locationid == locationid)
                .Select(r => new OrderPriority
                {
                    Indenttype = r.Indenttype,
                    Id = r.Id
                }).OrderByDescending(rq => rq.Indenttype).ToListAsync();
            return druglist;
        }

       

        public async Task<List<DrugGeneric>> GetDrugGeneric()
        {
            var druglist = await _context.DrugGeneric.Where(p => p.Isactive == true)
                .Select(r => new DrugGeneric
                {
                    Genericname = r.Genericname,
                    Genericid = r.Genericid
                }).OrderByDescending(rq => rq.Genericname).ToListAsync();
            return druglist;
        }


        public async Task<List<DrugUnit>> GetDrugUnit()
        {
            var druglist = await _context.DrugUnit.Where(p => p.Isactive == true)
                .Select(r => new DrugUnit
                {
                    Description = r.Description,
                    UnitId = r.UnitId
                }).OrderByDescending(rq => rq.Description).ToListAsync();
            return druglist;
        }



        public async Task<List<DrugDoseForm>> GetDrugDoseForms()
        {
            var druglist = await _context.DrugDoseForm.Where(p => p.Isactive == 1)
                .Select(r => new DrugDoseForm
                {
                    FormulationName = r.FormulationName,
                    DoseFormid = r.DoseFormid,
                    FormulationShortName = r.FormulationShortName
                }).OrderByDescending(rq => rq.FormulationName).ToListAsync();
            return druglist;
        }

        public async Task<List<DrugRoute>> GetDrugRoute()
        {
            var druglist = await _context.DrugRoute.Where(p => p.Isactive == true)
                .Select(r => new DrugRoute
                {
                    RouteName = r.RouteName,
                    Description = r.Description,
                    RouteId = r.RouteId
                }).OrderByDescending(rq => rq.RouteName).ToListAsync();
            return druglist;
        }

        public async Task<List<DrugFrequency>> GetDrugFrequency()
        {
            var druglist = await _context.DrugFrequency.Where(p => p.IsActive == true)
                .Select(r => new DrugFrequency
                {
                    Abbreviation = r.Abbreviation,
                    CommonFrequency = r.CommonFrequency,
                    Description = r.Description,
                    Frequency = r.Frequency,
                    FrequencyId = r.FrequencyId,
                }).OrderByDescending(rq => rq.Frequency).ToListAsync();
            return druglist;
        }

        public async Task<List<DrugFoodrelation>> GetDrugFoodRelation(int locationid)
        {
            var druglist = await _context.DrugFoodrelation.Where(p => p.IsActive == true && p.LocationId == locationid)
                .Select(r => new DrugFoodrelation
                {
                    Foodid = r.Foodid,
                    FoodName = r.FoodName,
                }).OrderByDescending(rq => rq.FoodName).ToListAsync();
            return druglist;
        }

        //public async Task AddFavourites(PrescriptionDTO pfavourites)
        //{
        //    await _context.AddRangeAsync(pfavourites.ConsultationPrescriptionFavorites);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteFavourite(ConsultationPrescriptionFavorites pfavourites)
        //{
        //    _context.Remove(pfavourites);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<List<ConsultationPrescriptionDetails>> GetPreviousMedication(string patientid)
        //{
        //    var druglist = await _context.ConsultationPrescriptionDetails.Where(p => p.Patientid == patientid)
        //        .Select(r => new ConsultationPrescriptionDetails
        //        {
        //            Prescriptionid = r.Prescriptionid,
        //            PrescriptionDetail = r.PrescriptionDetail,
        //        }).OrderByDescending(rq => rq.PrescriptionDetail).ToListAsync();
        //    return druglist;
        //}

        //public async Task AddConsultation(PrescriptionDTO cp)
        //{
        //    await _context.AddRangeAsync(cp.ConsultationPrescriptions);
        //    await _context.SaveChangesAsync();
        //}


        //public async Task AddDetails(PrescriptionDTO details)
        //{
        //    await _context.AddRangeAsync(details.Details);
        //    await _context.SaveChangesAsync();
        //}


    }
}
