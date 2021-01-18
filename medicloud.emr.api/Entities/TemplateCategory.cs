using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateCategory
    {
        public int Tempcatid { get; set; }
        public string Categoryname { get; set; }
        public int? Specializationid { get; set; }
        public int? Accountid { get; set; }
        public DateTime? Dateadded { get; set; }
    }

    public class TemplateFormMaster
    {
        public int Masterid { get; set; }
        public string Jsonform { get; set; }
        public string Formname { get; set; }
        public string Formdescription { get; set; }
        public string Formcomments { get; set; }
        public int? Tempcatid { get; set; }
        public int? Adjusterid { get; set; }
        public int? Accountid { get; set; }
        public bool? Iscurrent { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Locationid { get; set; }
        public string categorybname { get; set; }
        public string categorycname { get; set; }

        public static explicit operator TemplateMaster(TemplateFormMaster templateFormMaster)
        {
            return JsonConvert.DeserializeObject<TemplateMaster>(JsonConvert.SerializeObject(templateFormMaster));
        }

        public static explicit operator TemplateCategoryB(TemplateFormMaster templateFormMaster)
        {
            return new TemplateCategoryB()
            {
                categoryname = templateFormMaster.categorybname,
                templatecategoryid = (int)templateFormMaster.Masterid
            };
        }
        public static explicit operator TemplateCategoryC(TemplateFormMaster templateFormMaster)
        {
            return new TemplateCategoryC()
            {
                categoryname = templateFormMaster.categorybname,
                templatecategoryid = (int)templateFormMaster.Masterid
            };
        }
    }

    public class TemplateCategoryB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string categoryname { get; set; }
        public int templatecategoryid { get; set; }
    }

    public class TemplateCategoryC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string categoryname { get; set; }
        public int templatecategoryid { get; set; }
        public int templatecategorybid { get; set; }
    }
}
