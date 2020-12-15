using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Entities;

namespace medicloud.emr.api.DataContextRepo
{
    public interface IPatientRepo
    {
        Task<IQueryable<Patient>> SearchByValue(string searchValue);
        Task<IQueryable<Patient>> GetPatientById(string patientId);
        void Close();
    }

    public class PatientRepo : IPatientRepo
    {
        private IDataContextRepo<Patient> _db;

        public PatientRepo()
        {
            _db = new DataContextRepo<Patient>();
        }


        public Task<IQueryable<Patient>> SearchByValue(string searchValue)
        {
            string formattedQuery = $"'%{searchValue}%'";
            string query = $"select * from [Patient] where firstname like {formattedQuery} or lastname like {formattedQuery}  or othername like {formattedQuery} or address like {formattedQuery} or mothername like {formattedQuery} or mobilephone like {formattedQuery} or email like {formattedQuery} or employername like {formattedQuery}";
            //string query = $"select * from [Patient] where firstname like %" + searchValue + "%";
            // $"select * from [Patient] where firstname like {formattedQuery}"
            var result = _db.ExecuteRawSql(query);

            return Task.FromResult(result);
        }
        
        public Task<IQueryable<Patient>> GetPatientById(string patientId)
        {
            string query = $"select Top 1 * from [Patient] where patientid = {patientId}";
            
            var result = _db.ExecuteRawSql(query);

            return Task.FromResult(result);
        }

        //public Task<IQueryable<Patient>> SearchByValue(string searchValue)
        //{

        //    Task<IQueryable<Patient>> searchTask = new Task<IQueryable<Patient>>(() =>
        //    {
        //        //var getAll = _db.GetAll();

        //        // provided some data are not null
        //        var returnedDataFromSearch = _db.GetAll(x=>x.Mobilephone.Contains(searchValue) 
        //       || x.Lastname.Contains(searchValue) || x.Guardianname.Contains(searchValue) || x.Employername.Contains(searchValue)
        //       || x.Email.Contains(searchValue) || x.Patientid.Contains(searchValue) || (x.Lastname + " " + x.Firstname + " " + x.Othername).Contains(searchValue)
        //      );


        //        // var returnedDataFromSearch = _db.GetAll(x => x.Address.Contains(searchValue) ||  
        //        //x.Mobilephone.Contains(searchValue) || x.Mothername.Contains(searchValue) || x.Nokphonenumber.Contains(searchValue)
        //        //|| x.State.Statename.Contains(searchValue) || x.Othername.Contains(searchValue) || x.Firstname.Contains(searchValue)
        //        //|| x.Lastname.Contains(searchValue) || x.Guardianname.Contains(searchValue) || x.Employername.Contains(searchValue)
        //        //|| x.Email.Contains(searchValue) || x.Accountcategory.Contains(searchValue) || x.City.Contains(searchValue) ||
        //        //x.Gender.Gendername.Contains(searchValue));

        //        var listOfReturnedData = new List<Patient>();

        //        ////    // for perfomance reason this will not be the best...i think there is other way
        //        //foreach (Patient currentPatient in getAll)
        //        //{
        //        //    if ((currentPatient.Mobilephone != null && currentPatient.Mobilephone.Contains(searchValue))

        //        //        || (currentPatient.Email != null && currentPatient.Email.Contains(searchValue))
        //        //        || (currentPatient.Accountcategory != null && currentPatient.Accountcategory.Contains(searchValue))
        //        //        || (currentPatient.Lastname != null && currentPatient.Lastname.Contains(searchValue))
        //        //        || (currentPatient.Firstname != null && currentPatient.Firstname.Contains(searchValue))
        //        //        || (currentPatient.Address != null && currentPatient.Address.Contains(searchValue)) ||
        //        //        (currentPatient.Othername != null && currentPatient.Othername.Contains(searchValue)) ||
        //        //        (currentPatient.Patientid != null && currentPatient.Patientid.Contains(searchValue))

        //        //            )
        //        //    {
        //        //        listOfReturnedData.Add(currentPatient);
        //        //    }
        //        //}
        //        ////var shapedData = returnedDataFromSearch.Select(x => new
        //        ////{
        //        ////    Picture = x.Photopath,
        //        ////    FullName = x.Title + x.Lastname + "" + x.Firstname + "" + x.Othername,
        //        ////    AgeGender = getAge(x.Dob) + "/" + x.Gender.Gendername,
        //        ////    MobileNumber = x.Mobilephone,
        //        ////    Company = x.Employername

        //        ////});

        //       // return listOfReturnedData.AsQueryable<Patient>();

        //        return returnedDataFromSearch;
        //    });

        //    searchTask.Start();

        //    return searchTask;


        //}

        public static string getAge(DateTime? date)
        {
            if (date.HasValue)
            {
                var now = Math.Abs(DateTime.Now.Year - date.Value.Year);

                return now.ToString();

            }

            return "";
        }

        public void Close()
        {
            this._db.CloseConnection();
        }
    }
}
