using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace medicloud.emr.api.Helpers
{
    public interface ISearchParamters<T>
    {
       string searchValue { get; set; }

        IQueryable<T> GetValueBy(string searchValue);
    }

    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> shapeData(IEnumerable<T> entites, string fields);
        ExpandoObject shapeData(T entity, string fields);

        ExpandoObject getPropertyValues(T entity, IEnumerable<PropertyInfo> requiredProperties, string searchValue);
    }

    public class EntityDataShaper<T> : IDataShaper<T>
    {
        private PropertyInfo[] properties;

        public EntityDataShaper()
        {
            properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
        public IEnumerable<ExpandoObject> shapeData(IEnumerable<T> entites, string fields)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<PropertyInfo> GetRequiredProperties(string fieldsString)
        {
            var requiredProperties = new List<PropertyInfo>();
            if (!string.IsNullOrWhiteSpace(fieldsString))
            {
                var fields = fieldsString.Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach (var field in fields)
                {
                    var property = properties.FirstOrDefault(pi => pi.Name.Equals(field.Trim(), StringComparison.InvariantCultureIgnoreCase));
                    if (property == null)
                        continue;
                    requiredProperties.Add(property);
                }
            }
            else
            {
                requiredProperties = properties.ToList();
            }
            return requiredProperties;
        }

        public ExpandoObject shapeData(T entity, string fields)
        {
            var requiredProperties = GetRequiredProperties(fields);
            return FetchDataForEntity(entity, requiredProperties);
        }

        private IEnumerable<ExpandoObject> FetchData(IEnumerable<T> entities, IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedData = new List<ExpandoObject>();
            foreach (var entity in entities)
            {
                var shapedObject = FetchDataForEntity(entity, requiredProperties);
                shapedData.Add(shapedObject);
            }
            return shapedData;
        }

        private ExpandoObject FetchDataForEntity(T entity, IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedObject = new ExpandoObject();
            foreach (var property in requiredProperties)
            {
                var objectPropertyValue = property.GetValue(entity);
                shapedObject.TryAdd(property.Name, objectPropertyValue);
            }
            return shapedObject;
        }

        public ExpandoObject getPropertyValues(T entity, IEnumerable<PropertyInfo> requiredProperties, string searchValue)
         => FetchDataForEntity(entity, requiredProperties);
    }

    //public class SearchParamters<T> : ISearchParamters<T>
    //{
    //    private Data.DataContext dataContext;
    //    private IDataShaper<T> _dataShaper;

    //    public SearchParamters()
    //    {
    //        dataContext = new Data.DataContext();
    //        _dataShaper = new EntityDataShaper<T>();
    //    }

    //    public string searchValue { get ; set ; }

    //    // public V searchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public IQueryable<T> GetValueBy(string searchValue)
    //    {

    //        var dataReturnedFromSearch = dataContext.Patient.Where(
    //            x => x.Address.Contains(searchValue) || x.Bloodgroup.Bloodgroupname.Contains(searchValue) ||
    //            x.Mobilephone.Contains(searchValue) || x.Mothername.Contains(searchValue) || x.Nokphonenumber.Contains(searchValue)
    //            || x.State.Statename.Contains(searchValue) || x.Othername.Contains(searchValue) ||  x.Firstname.Contains(searchValue)
    //            || x.Lastname.Contains(searchValue) || x.Guardianname.Contains(searchValue) || x.Employername.Contains(searchValue)
    //            || x.Email.Contains(searchValue) || x.Accountcategory.Contains(searchValue) || x.City.Contains(searchValue) ||
    //            x.Gender.Gendername.Contains(searchValue)
    //            ) ;


    //        //var propertyInfo = dataToSearchFrom.GetP
    //        var shapedData = dataReturnedFromSearch.Select(x => new
    //        {
    //            Picture = x.Photopath,
    //            FullName = x.Title + x.Lastname + "" + x.Firstname + "" + x.Othername,
    //            AgeGender = getAge(x.Dob)+"/"+x.Gender.Gendername,
    //            MobileNumber = x.Mobilephone,
    //            Company = x.Employername
                                
    //        });

    //        return (IQueryable<T>)shapedData;
    //    }

    //    private string getAge(DateTime? date)
    //    {
    //        if(date.HasValue)
    //        {
    //            var now = Math.Abs(DateTime.Now.Year - date.Value.Year);

    //            return now.ToString();

    //        }

    //        return "";
    //    }

        
    //}
}
