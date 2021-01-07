using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using RestSharp;
using Newtonsoft.Json;
using System.Data.SqlClient;
using medicloud.emr.api.DTOs;
using Dapper;

namespace medicloud.emr.api.DataContextRepo
{
    public interface IPatientRepo
    {

       Task<IEnumerable<Patient>> SearchByValue(string searchValue);
       // Task<List<Patient>> SearchByValue(string searchValue);

        void Close();
        string AddPatient(Patient patient);
        Task<IEnumerable<Patient>> IsPatientRecordExist(string firstname, string lastname, string dob, string mobilePhone, string email, string othername = "", string mothername = "");
        string AddDependantPatient(Patient patient);
        Task<IEnumerable<Patient>> SearchForDependeant(string filter, string filterValue);
        bool SaveRegistrationLink(string link);
        bool getRegistrationLinkStatus(string link);
        string registerPatientFromLink(string link, Patient patientToUpdate);
        bool UpdatePatient(Patient patient);
        Task<IEnumerable<Patient>> searchForPatientToUpdate(string filter, string filterValue);
        string MinimalPatientReg(MinimalPatientRegistration _patient);
        Task<(List<Sponsor>, List<Payer>, List<Plan>, List<AccountCategory>)> patientDetails();
    }

    public class PatientRepo : IPatientRepo
    {
        private IDataContextRepo<Patient> _db;
        private DataContext ctx;
        private DataContext _context;
        private SqlConnection _conn;

        public PatientRepo(DataContext context)
        {
            _db = new DataContextRepo<Patient>();
            ctx = new DataContext();
            _context = context;
            _conn = PortalDAO.getNewConnection();
        }

        public string NextRegNo()
        {
            //try
            //{
            //  //  var connectionString = PortalDAO.getNewConnection();
            //    SqlConnection conx = PortalDAO.getNewConnection();
            //    conx.Open();
            //    SqlCommand cmdzs = new SqlCommand("SELECT MAX (patientid) as max_patient_id FROM patient ", conx);
            //    string AkhilRegNomaxValue = cmdzs.ExecuteScalar().ToString(); 
            //    int AkhilRegNomaxValue = Int32.Parse(AkhilRegNomaxValue); 
            //    int NextRegValue = AkhilRegNomaxValue + 1; conx.Close(); 
            //    return NextRegValue.ToString();
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message.ToString();
            //}
            return "";
        }
        
        public async Task<(List<Sponsor>, List<Payer>, List<Plan>, List<AccountCategory>)> patientDetails()
        {
            var sponsors = await ctx.Sponsor.ToListAsync();
            var payors = await ctx.Payer.ToListAsync();
            var plans = await ctx.Plan.ToListAsync();
            var accounts = await ctx.AccountCategory.ToListAsync();
            return (sponsors, payors, plans, accounts);
        }

        private string generatePatientId()
        {
            //string respponseContent = "";
            //var client = new RestClient("http://154.113.100.196:86/api/medismartapi/nextregno");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("Authorization", "Bearer 3bNpWGNlcf6R8WWKy0DjXUUbM5YSILtticLywwwnD5ZtPT52_I3bA4h74Se-g352-UxMnl4zN7GCNLG-pbDZ4XjG9v4UmZKgbuBGZK5T2CiXISWNZxPuYX2xNQVM0m2y6Y4wR58XLa4OXb-QKt2dUU7eNOEsSJi-B2h82tlv96cKhIDYLXtfzXV3UdvYK0NBGavaFoalLVJBqGY-agRw7zWvoQZo8uhlW_SH5zfnreiSjQVDhsxT3YxW5y1a9NRQj7fOFEwqy-NIjZ73vcHoYcciaRmeW_o8AW650wDfp1hoBdLID1qbPIRg7j9sKyat3zO0h8dxBWQB2LCeOuINOQNncULIHYl83QlO5tmjWpINyv1CwC8joAfyVHybHGzpMiPsQULFy3s3J-8_qm8DcpUWU1Oz2yx9NsgU8C0LM6L9xjFKu36kuCCEntG2KWs9AWgNRYQwToTch6nSdcL7Me25bktEsg6t2gKksgFzsjg");
            //request.AddHeader("Cookie", "__RequestVerificationToken=qL7t-K9JnQWNchykH4mZz_IM5TEC8gRSBZHKDQ4tW7py_r3nv2N0hz2oLqJ7YEbUVpIf382wZfi9_p-C2IC4Hy2fNx-qYMj9Hk3j9m7QfnM1");
            //IRestResponse response = client.Execute(request);
            ////Console.WriteLine(response.Content);

            //respponseContent = JsonConvert.DeserializeObject<string>(response.Content);
            //return respponseContent;

            
                 string _query = "[patient_reg_no_generate]";
                 _db.ExecutStoredProcedure(_query, out var patientId);
                return patientId;
      


        }

        private string generateFamilyNumber()
        {
            string _query = "[patient_fmaily_no_generate]";
            _db.ExecutStoredProcedure(_query, out var familyNumber);
            return familyNumber;
        }

        public Task<IEnumerable<Patient>> IsPatientRecordExist(string firstname, string lastname, string dob, string mobilePhone, string email, string othername = "", string mothername = "")
        {
            //string formattedQuery = $"'%{firstname}%'";

            Task<IEnumerable<Patient>> searchForRecord = new Task<IEnumerable<Patient>>(() =>
            {
                string _query = $"select * from [Patient] where (firstname = '{firstname}' and lastname = '{lastname}') or (firstname = '{firstname}' and lastname = '{lastname}' and mobilephone = '{mobilePhone}') or (firstname = '{firstname}' and lastname = '{lastname}' and dob = '{dob}' and mobilephone = '{mobilePhone}') or (othername = '{othername}' and firstname = '{firstname}' and lastname = '{lastname}' and dob = '{dob}' and mobilephone = '{mobilePhone}') or ( mothername = '{mothername}' and othername = '{othername}' and firstname = '{firstname}' and lastname = '{lastname}' and dob = '{dob}' and mobilephone = '{mobilePhone}')";
                var found = _db.ExecuteRawSql(_query);

                return found.AsEnumerable();
            });
            searchForRecord.Start();
            return searchForRecord;
            
        }
        public async Task<IEnumerable<Patient>> SearchByValue(string searchValue)
        {
            //            string formattedQuery = $"'%{searchValue}%'";
            string formattedQuery = $"'{searchValue}'";
            //string query = $"select * from [Patient] where (firstname is not null and firstname like {formattedQuery} or patientid is not null and patientid like {formattedQuery} or lastname is not null and lastname like {formattedQuery} or othername is not null and othername like {formattedQuery} or address is not null and address like {formattedQuery} or mothername is not null and mothername like {formattedQuery} or mobilephone is not null and mobilephone like {formattedQuery} or email is not null and email like {formattedQuery} or employername is not null and employername like {formattedQuery})";
            string query = $"select * from [Patient] where firstname is not null and firstname = {formattedQuery} or patientid is not null and patientid = {formattedQuery} or lastname is not null and lastname = {formattedQuery} or  mobilephone is not null and mobilephone = {formattedQuery} or email is not null and email = {formattedQuery}";
            //string query = $"select * from [Patient] where firstname like %" + searchValue + "%";
            // $"select * from [Patient] where firstname like {formattedQuery}"
            //var result = _db.ExecuteRawSql(query);

          //  var result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender); 

            //var result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender);
            var result = await _conn.QueryAsync<Patient>(query);

            //var _result = await _context.Patient.Where(p => p.Firstname.Contains(searchValue)).Include(g => g.Gender)/*.Take(10)*/.ToListAsync();


            //  var queryable = result.AsQueryable();

            //  return _result;


            return result;

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

        public string AddDependantPatient(Patient patient)
        {
            try
            {
                string newPatientId = generatePatientId();
              //  string familyNumber = generateFamilyNumber();
                patient.Patientid = newPatientId;
              
                if (_db.AddNew(patient))
                {
                    return newPatientId;
                }

                return null;
            }
            catch (Exception es)
            {

                throw es;
            }
        }
        public string AddPatient(Patient patient)
        {
            try
            {
                string newPatientId =  generatePatientId();
                if(newPatientId == "")
                {
                    throw new Exception("error generating patientId from Akhil endpoint");
                }
                string familyNumber = generateFamilyNumber();
                patient.Patientid = newPatientId;
                patient.FamilyNumber = familyNumber;
                patient.ProviderId = 2;
                if(_db.AddNew(patient))
                {
                    return newPatientId+":"+ familyNumber;
                }

                return null;
            }
            catch (Exception es)
            {

                throw es;
            }
        }

        public Task<IEnumerable<Patient>> searchForPatientToUpdate(string filter, string filterValue)
        {
            //string formattedQuery = $"'%{filterValue}%'";
            string formattedQuery = $"{filterValue}";
            string query = "";
           // string query = $"select * from [Patient] where (firstname is not null and firstname like {formattedQuery} or patientid is not null and patientid like {formattedQuery} or lastname is not null and lastname like {formattedQuery} or othername is not null and othername like {formattedQuery} or address is not null and address like {formattedQuery} or mothername is not null and mothername like {formattedQuery} or mobilephone is not null and mobilephone like {formattedQuery} or email is not null and email like {formattedQuery} or employername is not null and employername like {formattedQuery})";
            //string query = $"select * from [Patient] where firstname like %" + searchValue + "%";
            // $"select * from [Patient] where firstname like {formattedQuery}"
            //var result = _db.ExecuteRawSql(query);

            //return Task.FromResult(result);
            IEnumerable<Patient> result = null;
            switch (filter)
            {
                case "patientId":
                    query = $"select * from [Patient] where patientid is not null and patientid = '{filterValue}'";
                    // result = _db.ExecuteRawSql(query);
                    result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender).Include(x=>x.PayorTypes);
                    break;
                case "phoneNumber":
                    query = $"select * from [Patient] where mobilephone is not null and mobilephone = '{filterValue}' or workphone is not null and workphone = '{filterValue}' or homephone is not null and homephone = '{filterValue}'";
                    //result = _db.ExecuteRawSql(query);
                    result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender).Include(x => x.PayorTypes);
                    break;
                case "lastName":
                    query = $"select * from [Patient] where lastname is not null and lastname = '{filterValue}'";
                    // result = _db.ExecuteRawSql(query);
                    result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender).Include(x => x.PayorTypes);
                    break;
            }

            return Task.FromResult<IEnumerable<Patient>>(result);
        }
        public Task<IEnumerable<Patient>> SearchForDependeant(string filter, string filterValue)
        {
            string formattedQuery = $"'%{filterValue}%'";
            string query = $"select * from [Patient] where (firstname is not null and firstname like {formattedQuery} or patientid is not null and patientid like {formattedQuery} or lastname is not null and lastname like {formattedQuery} or othername is not null and othername like {formattedQuery} or address is not null and address like {formattedQuery} or mothername is not null and mothername like {formattedQuery} or mobilephone is not null and mobilephone like {formattedQuery} or email is not null and email like {formattedQuery} or employername is not null and employername like {formattedQuery})";
            //string query = $"select * from [Patient] where firstname like %" + searchValue + "%";
            // $"select * from [Patient] where firstname like {formattedQuery}"
            //var result = _db.ExecuteRawSql(query);

            //return Task.FromResult(result);
            IEnumerable<Patient> result = null;
            switch(filter)
            {
                case "patientId":
                    query = $"select * from [Patient] where patientid is not null and patientid like {formattedQuery}";
                    // result = _db.ExecuteRawSql(query);
                    result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender);
                    break;
                case "phoneNumber":
                    query = $"select * from [Patient] where mobilephone is not null and mobilephone like {formattedQuery} or workphone is not null and workphone like {formattedQuery} or homephone is not null and homephone like {formattedQuery}";
                    //result = _db.ExecuteRawSql(query);
                    result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender);
                    break;
                case "lastName":
                    query = $"select * from [Patient] where lastname is not null and lastname like {formattedQuery}";
                    // result = _db.ExecuteRawSql(query);
                    result = ctx.Patient.FromSqlRaw(query).Include(x => x.Gender);
                    break;
            }

            return Task.FromResult<IEnumerable<Patient>>(result);
        }

        public bool SaveRegistrationLink(string link)
        {
            string regLink = $"{link}";
            string patientId = generatePatientId();
            string familyId = generateFamilyNumber();
            var patient = PatientDTO.GetDefault();
            patient.Patientid = patientId;
            patient.FamilyNumber = familyId;
            patient.Reglink = regLink;
            var patientObject = (Patient)patient;
            //patientObject.Reglink = regLink;

            return _db.AddNew(patientObject);
        }
        
        public string MinimalPatientReg(MinimalPatientRegistration _patient)
        {
            string patientId = generatePatientId();
            string familyId = generateFamilyNumber();
            var patient = PatientDTO.GetDefault();
            patient.Patientid = patientId;
            patient.FamilyNumber = familyId;
            patient.Firstname = _patient.Firstname;
            patient.Lastname = _patient.Lastname;
            patient.Genderid = _patient.Genderid;
            patient.Mobilephone = _patient.Phone;
            patient.Dob = _patient.Dob;
            patient.Email = _patient.Email;
            patient.RegistrationType = _patient.RegistrationType;
            patient.Accountcategory = _patient.Address;
            var patientObject = (Patient)patient;

            _db.AddNew(patientObject);
            return patientId;
        }

        public string registerPatientFromLink(string link, Patient patientToUpdate)
        {
            //ctx = null;
            string newLink = $"{link}_1";

            Patient getSingle = _db.GetSingle(x => x.Reglink == link+"_0");
            _db.CloseConnection();
            if(getSingle == null)
            {
                return null;
            }
           
            patientToUpdate.Reglink = newLink;
            patientToUpdate.FamilyNumber = getSingle.FamilyNumber;
           //zzz patientToUpdate.Patientid = generatePatientId();
            // patientToUpdate.Autoid = getSingle.Autoid;
            //var result =  _db.Update(patientToUpdate);

            ctx.Entry<Patient>(patientToUpdate).State = EntityState.Modified;
            ctx.Entry<Patient>(patientToUpdate).Property(x => x.Autoid).IsModified = false;
            bool result = ctx.SaveChanges() > 0;
            //result = _db.AddNew(patientToUpdate);


            if (!result)
            {
                return null;
            }
            _db.CloseConnection();
           // var deleted = _db.Delete(x => x.Reglink == link + "_0" || x.Patientid == getSingle.Patientid);

            return patientToUpdate.Patientid + ":" + patientToUpdate.FamilyNumber;
        }
        public bool getRegistrationLinkStatus(string link)
        {
            var find = _db.GetSingle(x => x.Reglink == link);

            if(find == null)
            {
                return false;
            }

            var split_input = link.Split("_");
            string status = split_input[1];

            if(status == "1")
            {
                return false;
            }

            return true;
        }

        public bool UpdatePatient(Patient patient)
        {
            ctx.Entry<Patient>(patient).State = EntityState.Modified;
            ctx.Entry<Patient>(patient).Property(x => x.Autoid).IsModified = false;
            ctx.Entry<Patient>(patient).Property(x => x.hospitallocationid).IsModified = false;
            return ctx.SaveChanges() > 0;
            //return _db.Update(patient);
        }
    }
}
