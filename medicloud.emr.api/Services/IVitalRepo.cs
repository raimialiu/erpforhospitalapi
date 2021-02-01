using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Etities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IVitalRepo
    {
        public EmrProblems GetAllProblem();
        public List<EmrproblemDuration> GetAllEmrproblemDuration();
        public IQueryable<Etities.ConsultationComplaints> TodaysProblem(string patientid);
        public bool SaveConsultationFavourites(ConsultationComplaintsFavorites dto);
        public bool DeleteConsultationFavourites(long id);
        public bool SaveFreeForm(DiagnosisFreeFormDTO dto);
        public IQueryable<DiagnosisFreeForm> LoadFreeFormByDateRange(string startDate, string endDate);
        public IOrderedQueryable<DiagnosisFreeForm> LoadFreeFormLastTen();
        public List<ConsultationComplaintsFavorites> LoadConsultationFavourites();
    }

    public class VitalRepo : IVitalRepo
    {
        private DataContext _ctx;
        public VitalRepo()
        {
            _ctx = new DataContext();
        }
        public bool DeleteConsultationFavourites(long id)
        {
            var single = _ctx.ConsultationComplaintsFavorites.SingleOrDefaultAsync(x => x.Favoriteid == id).Result;
            if (single == null) return false;

            _ctx.ConsultationComplaintsFavorites.Remove(single);
           return _ctx.SaveChangesAsync().Result > 0;
        }

        public List<EmrproblemDuration> GetAllEmrproblemDuration()
        {
            return _ctx.EmrProblemDuration.ToListAsync().Result;
        }

        public EmrProblems GetAllProblem()
        {
            throw new NotImplementedException();
        }

        public List<ConsultationComplaintsFavorites> LoadConsultationFavourites()
        {
            throw new NotImplementedException();
        }

        public IQueryable<DiagnosisFreeForm> LoadFreeFormByDateRange(string startDate, string endDate)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<DiagnosisFreeForm> LoadFreeFormLastTen()
        {
            throw new NotImplementedException();
        }

        public bool SaveConsultationFavourites(ConsultationComplaintsFavorites dto)
        {
            throw new NotImplementedException();
        }

        public bool SaveFreeForm(DiagnosisFreeFormDTO dto)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Etities.ConsultationComplaints> TodaysProblem(string patientid)
        {
            throw new NotImplementedException();
        }
    }
}
