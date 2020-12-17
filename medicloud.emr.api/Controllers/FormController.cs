using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace medicloud.emr.api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly DataContext _dataContext;

        //inject into the instance 
        public FormController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //get all forms
        //[Authorize(Roles = "Admin, Nurse")]
        [HttpGet]
        //public IActionResult GetData() => Ok((from t in _dataContext.TemplateMaster
        //                                      join tc in _dataContext.TemplateCategory on t.Tempcatid equals tc.Tempcatid
        //                                      join l in _dataContext.Location on t.Locationid equals l.Locationid into location
        //                                      from subset in location.DefaultIfEmpty()
        //                                      orderby t.Formname ascending
        //                                      where (t.Iscurrent == true)
        //                                      select new { t.Masterid, t.Jsonform, t.Tempcatid, t.Formname, t.Formdescription, t.Formcomments, t.Adjusterid, t.Accountid, t.Iscurrent, t.Dateadded, tc.Categoryname, t.Locationid, locationname = subset.Locationname ?? "All Locations" }).ToList());

        public IActionResult GetData()
        {
            var data = (from t in _dataContext.TemplateMaster
                        join tc in _dataContext.TemplateCategory on t.Tempcatid equals tc.Tempcatid
                        join l in _dataContext.Location on t.Locationid equals l.Locationid into location
                        // join tb in _dataContext.TemplateCategoryB on t.Tempcatid equals tb.templatecategoryid
                        //join tcc in _dataContext.TemplateCategoryC on t.Tempcatid equals tcc.templatecategoryid
                        from subset in location.DefaultIfEmpty()
                        orderby t.Formname ascending
                        where (t.Iscurrent == true)
                        select new
                        {
                            t.Masterid,
                            t.Jsonform,
                            t.Tempcatid,
                            t.Formname,
                            t.Formdescription,
                            t.Formcomments,
                            t.Adjusterid,
                            t.Accountid,
                            t.Iscurrent,
                            t.Dateadded,
                            tc.Categoryname,
                            t.Locationid,
                            // tb.categoryname,
                            //tempcname = tcc.categoryname,
                            locationname = subset.Locationname ?? "All Locations"
                        }).ToList();
            var tempcatDb = _dataContext.TemplateCategoryB.ToList();
            var tempcatC = _dataContext.TemplateCategoryC.ToList();

            var newData = new
            {
                tempcatb = tempcatDb,
                tempcatc = tempcatC,
                data
            };
            return Ok(newData);
        }


        //[Authorize(Roles = "Admin, Nurse")]
        [HttpGet("{id}")]
        public IActionResult GetSingleForm([FromRoute]string id)
        {
            int masterid = Convert.ToInt32(id);
            var data = _dataContext.TemplateMaster.Where(x => x.Masterid == masterid).FirstOrDefault();
            if (data is null) return NotFound("Form Not Found");
            return Ok(data);
        }


        [Route("getFormById/{id}")]
        [HttpGet]
        public IActionResult GetFormById([FromRoute] string id)
        {
            int masterid = Convert.ToInt32(id);
            var data = _dataContext.TemplateMaster.Where(x => x.Masterid == masterid).FirstOrDefault();
            if (data is null) return NotFound("Form Not Found");


            var catId = data.Tempcatid;
            var templateCatB = _dataContext.TemplateCategoryB.Where(x => x.templatecategoryid == catId);
            if (templateCatB == null)
                return Ok(data);

            var templateCatC = _dataContext.TemplateCategoryC.Where(x => x.templatecategoryid == catId);
            if (templateCatC == null)
                return Ok(data);

            var info = new
            {
                data = data,
                templateB = templateCatB,
                templateC = templateCatC
            };

            return Ok(info);
        }

        // [Authorize(Roles = "Admin, Nurse")]
        [HttpGet("{name}")]
        public IActionResult GetFormByName([FromRoute]string name)
        {

            var data = _dataContext.TemplateMaster.Where(x => x.Formname == name).FirstOrDefault();
            if (data is null) return NotFound("Form Not Found");
            return Ok(data);
        }

        //insert forms
        //[Authorize(Roles = "Admin, Nurse")]
        [HttpPost("create")]
        public IActionResult Create(TemplateFormMaster master)
        {

            TemplateMaster request = (TemplateMaster)master;

            if (request != null && request.Formname != null && request.Jsonform != null && request.Iscurrent != null && request.Tempcatid != null)
            {
                var checkexisting = _dataContext.TemplateMaster.Where(x => x.Formname == request.Formname).FirstOrDefault();

                if (checkexisting == null)
                {
                    string createtable = CreateTable(request.Jsonform, request.Formname);
                    if (createtable == "Success")
                    {
                        _dataContext.TemplateMaster.Add(request);
                        _dataContext.SaveChanges();

                        TemplateCategoryB catb = (TemplateCategoryB)master;
                        TemplateCategoryC catc = (TemplateCategoryC)master;

                        if (catb != null || catb.categoryname != null)
                        {
                            _dataContext.TemplateCategoryB.Add(catb);
                            _dataContext.SaveChanges();
                        }

                        if (catc != null || catc.categoryname != null)
                        {
                            catc.templatecategorybid = catb.id;
                            _dataContext.TemplateCategoryC.Add(catc);
                            _dataContext.SaveChanges();
                        }
                        return Ok("Success");
                        //return CreatedAtAction(nameof(GetSingleForm), new { id = request.Masterid }, request);
                    }
                    else
                    {
                        return BadRequest("Unable to create table");
                    }

                }
                else
                {
                    return BadRequest("Form Exists");
                }
            }
            else
            {
                return BadRequest("Invalid/Bad Request");
            }


            //if (request != null && request.Formname != null && request.Jsonform != null && request.Iscurrent != null && request.Tempcatid != null)
            //{
            //    var checkexisting = _dataContext.TemplateMaster.Where(x => x.Formname == request.Formname).FirstOrDefault();

            //    if (checkexisting == null)
            //    {
            //        string createtable = CreateTable(request.Jsonform, request.Formname);
            //        if (createtable == "Success")
            //        {
            //            _dataContext.TemplateMaster.Add(request);
            //            _dataContext.SaveChanges();
            //            return Ok("Success");
            //            //return CreatedAtAction(nameof(GetSingleForm), new { id = request.Masterid }, request);
            //        }
            //        else
            //        {
            //            return BadRequest("Unable to create table");
            //        }

            //    }
            //    else
            //    {
            //        return BadRequest("Form Exists");
            //    }
            //}
            //else
            //{
            //    return BadRequest("Invalid/Bad Request");
            //}



        }

        [HttpPost("save")]
        public IActionResult SaveData(FormData request)
        {
            SQLDataManager sql = new SQLDataManager(false);
            if (request != null && request.formname != null && request.formdata != null )
            {
                string query = "insert into template_" + request.formname.Replace(" ", "").ToLower() + " "+request.formdata;
                sql.ExecuteNonQuery(query, CommandType.Text);
                return Ok("Success");
            }
            else
            {
                return BadRequest("Invalid/Bad Request");
            }



        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetTemplateCategories()
        {
            var categories = await _dataContext.TemplateCategory
                                .Select(c => new { c.Tempcatid, c.Categoryname })
                                .ToListAsync();
            return Ok(categories);
        }

        public string CreateTable(string formdata, string formname)
        {

            SQLDataManager sql = new SQLDataManager(false);

           
            string query_create = "CREATE TABLE template_" + formname.Replace(" ", "").ToLower() + " (Id INT IDENTITY(1,1) PRIMARY KEY, accountid int, locationid int, patientid varchar(100)";

            //List<Component> request = new List<Component>();
            try
            {
                Form myform = new Form();
                myform = JsonConvert.DeserializeObject<Form>(formdata);

                for (int i = 0; i < myform.components.Count; i++)
                {
                    Columns mycolumn = myform.components[i];
                    for (int j = 0; j < mycolumn.columns.Count; j++)
                    {
                        Component mycomponent = mycolumn.columns[j];
                        for (int k = 0; k < mycomponent.components.Count; k++)
                        {
                            //Detail mydetail = mycomponent.components[i].;
                            query_create += "," + mycomponent.components[k].key.ToString().Replace(" ", "").ToLower() + " varchar(100)";
                        }
                    }
                    //query_create += ","+myform.components[i].key.ToString().Replace(" ", "").ToLower() + " varchar(100)";

                }
            }
            catch(Exception)
            {
                FormDirect myform = new FormDirect();
                myform = JsonConvert.DeserializeObject<FormDirect>(formdata);
                for (int k = 0; k < myform.components.Count; k++)
                {
                        //Detail mydetail = mycomponent.components[i].;
                        query_create += "," + myform.components[k].key.ToString().Replace(" ", "").ToLower() + " varchar(100)";
                }
            }

             query_create += " , Dateadded datetime DEFAULT GETDATE() )";
             sql.ExecuteNonQuery(query_create, CommandType.Text);

            return "Success";
        }
    }
}