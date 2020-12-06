using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations
{
    public partial class pa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "access_control",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modules = table.Column<string>(nullable: true),
                    roles = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_access_control", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AccountCategory",
                columns: table => new
                {
                    accountcatid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountcattype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCategory", x => x.accountcatid);
                });

            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    accttypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accttypedesc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.accttypeid);
                });

            migrationBuilder.CreateTable(
                name: "app_setting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(unicode: false, nullable: true),
                    value = table.Column<string>(unicode: false, nullable: true),
                    user = table.Column<string>(unicode: false, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_setting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentStatus",
                columns: table => new
                {
                    statusid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusname = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    statuscolor = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Appointm__36247E305B0C5D02", x => x.statusid);
                });

            migrationBuilder.CreateTable(
                name: "BenefitPackage",
                columns: table => new
                {
                    benpackageid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    packagename = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    packagedesc = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    comments = table.Column<string>(unicode: false, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_benefit_package", x => x.benpackageid);
                });

            migrationBuilder.CreateTable(
                name: "BloodGroup",
                columns: table => new
                {
                    bloodgroupid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bloodgroupname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroup", x => x.bloodgroupid);
                });

            migrationBuilder.CreateTable(
                name: "Clinic",
                columns: table => new
                {
                    clinicid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clinicname = table.Column<string>(nullable: true),
                    contactperson = table.Column<string>(nullable: true),
                    contactphone = table.Column<string>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinic", x => x.clinicid);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Impression",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    impressioncode = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Impression", x => x.txnkey);
                });

            migrationBuilder.CreateTable(
                name: "ConsultationChecks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCname = table.Column<string>(nullable: true),
                    FilterCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    datecreated = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationChecks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    countryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryname = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.countryid);
                });

            migrationBuilder.CreateTable(
                name: "CPTCategory",
                columns: table => new
                {
                    cptcategoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cptcategoryname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cptcategorydesc = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPTCategory", x => x.cptcategoryid);
                });

            migrationBuilder.CreateTable(
                name: "Dental_Procedure",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    price = table.Column<string>(maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dental_Procedure", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    desigid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.desigid);
                });

            migrationBuilder.CreateTable(
                name: "DrugCategory",
                columns: table => new
                {
                    drugcategoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugcategory = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    categorydesc = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCategory", x => x.drugcategoryid);
                });

            migrationBuilder.CreateTable(
                name: "DrugPricelist",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    hmoid = table.Column<int>(nullable: false),
                    drugname = table.Column<string>(nullable: false),
                    price = table.Column<string>(maxLength: 50, nullable: true),
                    datetadded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DrugTherapeuticClass",
                columns: table => new
                {
                    classid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    therapeuticdesc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugTherapeuticClass", x => x.classid);
                });

            migrationBuilder.CreateTable(
                name: "formdirect2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    textfield = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    textfield2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formdirect2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    genderid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gendername = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.genderid);
                });

            migrationBuilder.CreateTable(
                name: "General_Examination",
                columns: table => new
                {
                    examid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    examdescription = table.Column<string>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General_Examination", x => x.examid);
                });

            migrationBuilder.CreateTable(
                name: "GenoType",
                columns: table => new
                {
                    genotypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genotypename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenoType", x => x.genotypeid);
                });

            migrationBuilder.CreateTable(
                name: "group",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scheme = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    contractstart = table.Column<DateTime>(type: "date", nullable: true),
                    contractend = table.Column<DateTime>(type: "date", nullable: true),
                    created_at = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    shortname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareFacilitator",
                columns: table => new
                {
                    facilitatorid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facilitatorname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareFacilitator", x => x.facilitatorid);
                });

            migrationBuilder.CreateTable(
                name: "HospitalUnit",
                columns: table => new
                {
                    HospitalUnitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalUnitName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalUnit", x => x.HospitalUnitId);
                });

            migrationBuilder.CreateTable(
                name: "hshhs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    textfield1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    textfield12 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hshhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ICDCategory",
                columns: table => new
                {
                    icdcategoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icdcategoryname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    icdcategorydesc = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICDCategory", x => x.icdcategoryid);
                });

            migrationBuilder.CreateTable(
                name: "id_generation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastcode = table.Column<string>(nullable: true),
                    startvalue = table.Column<string>(nullable: true),
                    endvalue = table.Column<string>(nullable: true),
                    sequence = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_id_generation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationMode",
                columns: table => new
                {
                    IdentificationModeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationModename = table.Column<string>(nullable: true),
                    Dateadded = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationMode", x => x.IdentificationModeid);
                });

            migrationBuilder.CreateTable(
                name: "Injection_Taken",
                columns: table => new
                {
                    injid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    consultationid = table.Column<int>(nullable: false),
                    injname = table.Column<string>(unicode: false, nullable: false),
                    qty_taken = table.Column<int>(nullable: false),
                    qty_left = table.Column<int>(nullable: false),
                    datetaken = table.Column<DateTime>(type: "datetime", nullable: false),
                    administeredby = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injection_Taken", x => x.injid);
                });

            migrationBuilder.CreateTable(
                name: "LeadSource",
                columns: table => new
                {
                    leadid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    leadname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSource", x => x.leadid);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    locationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    address = table.Column<string>(unicode: false, nullable: true),
                    phone1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    phone2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    zipcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    locationadmin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    locationdescription = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.locationid);
                });

            migrationBuilder.CreateTable(
                name: "maritalstatus",
                columns: table => new
                {
                    maritalstatusid = table.Column<int>(nullable: false),
                    maritalstatusname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maritalstatus", x => x.maritalstatusid);
                });

            migrationBuilder.CreateTable(
                name: "MeasureUnit",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    freqvalue = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureUnit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProblemCategory",
                columns: table => new
                {
                    medid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    problemtype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProblem", x => x.medid);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    nationalityid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationalityname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.nationalityid);
                });

            migrationBuilder.CreateTable(
                name: "network",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    startdate = table.Column<DateTime>(type: "date", nullable: true),
                    enddate = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_network", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NextOfKinRelationship",
                columns: table => new
                {
                    nokid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noktype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKinRelationship", x => x.nokid);
                });

            migrationBuilder.CreateTable(
                name: "Nursing_Record",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    categoryid = table.Column<int>(nullable: true),
                    record = table.Column<string>(nullable: true),
                    details = table.Column<string>(nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nursing_Record", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    orderstatusid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderstatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.orderstatusid);
                });

            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    ordertypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ordername = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderType", x => x.ordertypeid);
                });

            migrationBuilder.CreateTable(
                name: "PatientType",
                columns: table => new
                {
                    PatienttypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Dateadded = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientType", x => x.PatienttypeId);
                });

            migrationBuilder.CreateTable(
                name: "plan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, nullable: true),
                    description = table.Column<string>(unicode: false, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Problem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    problem = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProcedurePricelist",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hmoid = table.Column<int>(nullable: false),
                    procedurename = table.Column<string>(nullable: false),
                    price = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedurePricelist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "provider",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    tin = table.Column<string>(nullable: true),
                    network = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    contactphone = table.Column<string>(nullable: true),
                    contactname = table.Column<string>(nullable: true),
                    contactemail = table.Column<string>(nullable: true),
                    hmoproviderid = table.Column<string>(nullable: true),
                    isreferral = table.Column<bool>(nullable: true),
                    accountnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionCategory",
                columns: table => new
                {
                    qcatid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryname = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionCategory", x => x.qcatid);
                });

            migrationBuilder.CreateTable(
                name: "Referral",
                columns: table => new
                {
                    refid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reftype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referral", x => x.refid);
                });

            migrationBuilder.CreateTable(
                name: "ReferringPhysician",
                columns: table => new
                {
                    refid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    physicianname = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Referrin__198472FDAD57E270", x => x.refid);
                });

            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    reminderid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reminder = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.reminderid);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    servicetypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicetypedesc = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.servicetypeid);
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    sponsid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sponsortype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.sponsid);
                });

            migrationBuilder.CreateTable(
                name: "SupplierType",
                columns: table => new
                {
                    suppliertypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierdesc = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    comments = table.Column<string>(unicode: false, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierType", x => x.suppliertypeid);
                });

            migrationBuilder.CreateTable(
                name: "temp",
                columns: table => new
                {
                    DIAGNOSISCODE = table.Column<string>(name: "DIAGNOSIS CODE", maxLength: 255, nullable: false),
                    SHORTDESCRIPTION = table.Column<string>(name: "SHORT DESCRIPTION", maxLength: 255, nullable: true),
                    LONGDESCRIPTION = table.Column<string>(name: "LONG DESCRIPTION", maxLength: 255, nullable: true),
                    NFEXCL = table.Column<string>(name: "NF EXCL", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temp", x => x.DIAGNOSISCODE);
                });

            migrationBuilder.CreateTable(
                name: "template_abdomen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    distended = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    soft = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    firm = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hyperemic = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    tender = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hepatomegaly = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    splenomegaly = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    renomegaly = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bowelsound = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_abdomen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_activity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bedrest = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    monitorvitalsigns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    monitorpainscore = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    monitorwounddrainage = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_allergies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    allergies = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_allergies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_allreadyfordischarge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    allnursingmedicationxraycollectedreadyfordischarge = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_allreadyfordischarge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_anthpropometry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    weight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sga = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    aga = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lga = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lengthcm = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    headcircumferencecm = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_anthpropometry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_antibiotics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    a = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    b = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    c = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    d = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    e = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    f = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    g = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_antibiotics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_arvdrugs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    regimen = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    adherence = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    whypoorfairadherence1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherspleasespecify = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_arvdrugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_assesment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    assement = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_assesment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_attitude",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    flexion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    partialflexion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    extension = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    suck = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    grasp = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    mororeflex = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_attitude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_biodata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    patientname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hospitalnumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateofbirth = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    datetime = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_biodata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_bloodgasanalysisform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    date = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    time = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sampletype = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    na = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    k = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cl = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    tco2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bun = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    glu = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hct = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hb = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ph = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pco2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    po2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    po2fio2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    so2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hco3 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    beecf = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    angap = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lac = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_bloodgasanalysisform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_bloodsugar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bloodsugar = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_bloodsugar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_capturevitals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    height = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    patientnumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    weight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_capturevitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_cathetercouldbepassedthrough",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    l = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    r = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_cathetercouldbepassedthrough", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_chromeform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    firstname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lastname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_chromeform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_chromiumform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    height = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    weight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_chromiumform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_clinicalnotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    date = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    time = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    painscore = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    clinicalnotes = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_clinicalnotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_colonoscopy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateofprcedure = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    endoscopist = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    colonoscopenumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    indication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bowelpreparation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    quantityofbowelpreparation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sedation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    extentofintubation1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    textarea = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    report = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    caecum = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ascendingcolon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    transversecolon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    descendingcolon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    symoidcolon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rectum = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    analcanalonretroflexion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    biopsies = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    diagnosis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    treatmentandoutcome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_colonoscopy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    postebtorders = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_consultantincharge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    consultantincharge = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_consultantincharge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_cotrimoxazole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    dose = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    adherence = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    afraidaffectedbysideeffect = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    busyworkingathome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    changeinroutineawayfromhome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    didnotunderstandhowtotakemedications = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    didnotwantotherstoknow = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    didnotwanttotakemedications = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    drugstockout = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fellasleepsleptthroughdose = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feltoverwhelmeddepressed = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feltsickwell = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feltwell = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    forgot = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    gotpregnancy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    notabletopay = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    others = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    patientmoved = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ranoutofmedication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    toomanypills = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherspleasespecify = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_cotrimoxazole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_dayodaysurgery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bedrest = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    monitorvitalsigns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    monitorpainscore = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_dayodaysurgery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_deliverydetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    modeofdelivery = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    presentation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    maternalsedation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lscs = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    onsetoflabor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_deliverydetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_detailsofresuscitation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    textfield = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nameofmedicalstaff = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    signatureofmedicalstaff = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_detailsofresuscitation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_diagnosisanddifferentials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    diagnosisanddifferentials = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_diagnosisanddifferentials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_dialysisprescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    treatmentduration = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bloodflowrate = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dialysisflowrate = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    anticoagulation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ultafiltration = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dialysisaccessused = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_dialysisprescription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_dialysisvitaltest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pretreatmentdiagnoses = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    posttreatmentdiagnoses = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    indicationsfordialysis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pretreatmentweight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pretreatmentlabtestresult = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_dialysisvitaltest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_diet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    diet = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_diet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_dietorder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    whatdietshouldthepatientbeplacedonkindlyinformthenurses = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_dietorder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_dischargeplanning",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    socialsupportneededathome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherproblemsidentifiedassessmentandplandischargeplanning = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_dischargeplanning", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_expectedoutcomesofcare",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    expectedoutcomeofcare = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_expectedoutcomesofcare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_firstexaminationatbirth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    date = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    time = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_firstexaminationatbirth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_fluidfeeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fluids = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    types = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feeds = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    typevia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_fluidfeeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_gastroscopy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    date = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateofbirth = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hospitalnumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    endoscopist = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    endoscopenumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    indication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    comorbidity = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    intubation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sedation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_gastroscopy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_generalapearances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sleeping = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pink = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    blue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pale = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    jaundiced = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    conscious = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hsiii = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    murmur = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    mbp = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hr = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rr = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ae = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    addedsounds = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_generalapearances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_homesupport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    arranged = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_homesupport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_informationgiventopatientandcaregiver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    continuingcare = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    medication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    diet = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    specialtreatmentandcareanduseofequipment = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_informationgiventopatientandcaregiver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_informedofdischarge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    patientandrelativecaregiverinformedofdischarge = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_informedofdischarge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_inn",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    dose = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    adherence = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    afraidaffectedbysideeffect = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    busyworkingatschool = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    changeinroutineawayfromhome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    didnotunderstandhowtotakemedication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    didnotwantotherstoknow = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    didnotwanttotakemedications = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    drugstockout = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fellasleepsleptthroughdose = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feltoverwhelmeddepressed = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feltsickbad = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    feltwell = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    gotpregnant = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    iforgot = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    notabletopay = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    patientmoved = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ranoutofmedication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    toomanypills = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherspleasespecify = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_inn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_inpatientform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientno = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    payertype = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_inpatientform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_investigation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    investigation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_investigation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_jaundice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    jaundice = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lastsbtotal = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    conj = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    phototherapy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_jaundice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_laboratory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    glands = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    tongue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    biochemicaldatalaboratorytestandprocedure = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    foodnutritionrelatedhistory2472hoursdietaryrecall = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nutritiondiagnosis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nutritionintervention = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_laboratory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_laboratory1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nutritioncounselling = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nutritioneducaion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    coordinationofnutritioncare = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_laboratory1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_lastsawadoctoron",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lastsawadoctoron = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_lastsawadoctoron", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_managementchangesinthelast24hrs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    am = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pm = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cxr = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_managementchangesinthelast24hrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_maternalrecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    mothersname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dob = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    registrationnumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateofadmission = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    eddbydate = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    antenatalscan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    maternalproblem = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    relevantmaterialmedication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    relevantfamilyhistory = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nameofnurseormidwife = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_maternalrecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_medicalofficerandcarecoordinator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    signature = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    datetime = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    time = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_medicalofficerandcarecoordinator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_medicationanddressings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    obtained = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    instructiongiven = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    informationonwheretoobtainfurthersupply = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_medicationanddressings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_medicationandothertreatmentalreadygiven",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    medicationothertreatmentalreadygiven = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_medicationandothertreatmentalreadygiven", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_medications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    asperanethesia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    antiemeticprophylaxisasperorder = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    prophylacticantibioticprescribed = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    injectionofclexaneat2000 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    applytedstockings = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_minivitals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    height = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    temperature = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    weight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pulse = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_minivitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_mother",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    age = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    health = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    causeofdeath = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_mother", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_neuro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    findings = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_neuro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_neurologic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    examinationfindings = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_neurologic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_neurologicexam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fits = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    jittery = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    abnormalmovement = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lethargic = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_neurologicexam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_otherconcern",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherconcern = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_otherconcern", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_otherdetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    otherdrugsprescribed = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    othertestdone = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    consulthospitalizereferlink = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nextappointmentdata = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_otherdetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_otherfluids",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dopamine = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dobutamine = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    morphin = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    midazolam = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    insulin = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bloodsugarrange = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    totalfluidsandfeeds = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    totalcalories = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    gainandlossof = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    aspirate = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    vomit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    urineoutput = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_otherfluids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_othermodification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    othermodification = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_othermodification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_outpatientappointmentmade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    outpatientappointmentmade = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_outpatientappointmentmade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_painassessmentscale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    painassessmentscale = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_painassessmentscale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_painassestmentscale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    painscore = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_painassestmentscale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_pastobstericform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    gravidity = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    para = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    alive = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    miscarriage = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_pastobstericform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_pastobsterichistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    gravidity = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    para = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    alive = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    miscarriage = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_pastobsterichistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_patientandcaregiver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    patientandcaregiverhasanamedcontactandtelephonenumberintheeventofdifficultiesfollowingdischarge = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_patientandcaregiver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_patientdetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    mothersbloodgroup = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    indicationforebt = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    babysbloodgroup = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_patientdetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_patientdetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pregnancybreastfeedingstatus = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    edd = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    familyplanningwritecode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    functionalstatus = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    whoclinicalstage = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    tbstatus = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otheroisproblem = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_patientdetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_patientinformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    firstname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lastname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_patientinformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_physicalexamination",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    linesdatedlines = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    uac = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    uvc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    textfield = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    longlines = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    others = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_physicalexamination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_physicianincharge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    physicianname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_physicianincharge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_plan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    foodandideatoemphasize = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    foodstolimit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    foodstoavoid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    othernotes = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    handoutanddietsheetgive1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_plan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_posttreatmentlabresult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dialysisdoseacheieved = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nextrecommendeddialysistreatment = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_posttreatmentlabresult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_presentingcomplaintsandhistoryofpresentillness",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    presentingcomplaintsandhistoryofpresentillness = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_presentingcomplaintsandhistoryofpresentillness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_presentobsterichistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    datebleeding = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lmp = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    edd = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ega = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    radio1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    urinarysymptoms = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    radio2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    febrilicillness = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pelvicpain = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    excessivevomiting = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns3 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns4 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherrelevantsymptoms = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_presentobsterichistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_primaryexaminationdetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    generalcondition = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    chest = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cvs = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    abdomen = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pelvis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    breast = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherrelevantabnormalities = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_primaryexaminationdetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_primaryexaminationdetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    generalcondition = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    chest = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cvs = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    abdomen = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pelvis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    mss = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    breasts = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    otherrelevantabnormalities = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_primaryexaminationdetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_psychological",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    anxious = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    radio1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    angry = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    suicidal = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    homicidal = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    other = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    normal = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_psychological", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_result",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    result = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ppr = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    qrs = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    qtqtc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pqrst = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rvssv1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rvssv2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rv6sv2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_result", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_resultinterpretation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    resultinterpretation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_resultinterpretation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_resultsofpreviousinvestigationdone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    results = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_resultsofpreviousinvestigationdone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_sepsis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    sepsis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    source = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_sepsis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_specimenrequired",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    specimenrequired = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_specimenrequired", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_surgeryform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    firstname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lastname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_surgeryform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_teaching",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    discusspainmanagementpainscaleandsideeffect = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    teachankleexercise = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    columns = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    explaintreatment = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_teaching", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_testspecimen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fbc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ptnr12goalsinrifonwatarin = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    eucrifindicatedclinically = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_testspecimen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_tone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    normal = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hypertonia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    floppy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_tone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_transportarrange",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    @private = table.Column<string>(name: "private", unicode: false, maxLength: 100, nullable: true),
                    ambulance = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_transportarrange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_treatmentgiven",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    treatmenttype = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    posttreatmentconditionandrecommendation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_treatmentgiven", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_treatmentmanagementplan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    treatmentmanagementplan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_treatmentmanagementplan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_typeofresuscitation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    suction = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    tactilestimulation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bagmask = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    intubation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    umbilicalcatheterization = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    drugs = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_typeofresuscitation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_urinalysis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    urinalysis = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_urinalysis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_ventilation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    mode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pipandpeep = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    map = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ti = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ratedp = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fioz = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    spoz = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_ventilation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template_vitals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    vitals = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    submit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template_vitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateCategory",
                columns: table => new
                {
                    tempcatid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    specializationid = table.Column<int>(nullable: true),
                    accountid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCategory", x => x.tempcatid);
                });

            migrationBuilder.CreateTable(
                name: "TemplateMaster",
                columns: table => new
                {
                    masterid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jsonform = table.Column<string>(type: "text", nullable: true),
                    formname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    formdescription = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    formcomments = table.Column<string>(type: "text", nullable: true),
                    tempcatid = table.Column<int>(nullable: true),
                    adjusterid = table.Column<int>(nullable: true),
                    accountid = table.Column<int>(nullable: true),
                    iscurrent = table.Column<bool>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    locationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateMaster", x => x.masterid);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    titleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titlename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.titleid);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    ID_u = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname_u = table.Column<string>(unicode: false, nullable: true),
                    lastname_u = table.Column<string>(unicode: false, nullable: true),
                    othername_u = table.Column<string>(unicode: false, nullable: true),
                    gender_u = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    dob_u = table.Column<DateTime>(type: "date", nullable: true),
                    title_u = table.Column<string>(nullable: true),
                    addressline1_u = table.Column<string>(unicode: false, nullable: true),
                    addressline2_u = table.Column<string>(unicode: false, nullable: true),
                    phone_u = table.Column<string>(unicode: false, nullable: true),
                    email_u = table.Column<string>(unicode: false, nullable: true),
                    username_u = table.Column<string>(unicode: false, nullable: true),
                    password_u = table.Column<string>(unicode: false, nullable: true),
                    providerid = table.Column<int>(nullable: true),
                    departmetid = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.ID_u);
                });

            migrationBuilder.CreateTable(
                name: "VisitType",
                columns: table => new
                {
                    typeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typename = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VisitTyp__F0528D02702008C8", x => x.typeid);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    wardid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wardname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.wardid);
                });

            migrationBuilder.CreateTable(
                name: "ConsultationCheckslist",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCLname = table.Column<string>(nullable: true),
                    CCLtypeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationCheckslist", x => x.id);
                    table.ForeignKey(
                        name: "FK_ConsultationCheckslist_ConsultationCheckslist",
                        column: x => x.CCLtypeid,
                        principalTable: "ConsultationChecks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    stateid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statename = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    countryid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.stateid);
                    table.ForeignKey(
                        name: "FK_State_country",
                        column: x => x.countryid,
                        principalTable: "country",
                        principalColumn: "countryid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPTSubCategory",
                columns: table => new
                {
                    cptsubcategoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cptsubcategoryname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cptcategorydesc = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    cptcategoryid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPTSubCategory", x => x.cptsubcategoryid);
                    table.ForeignKey(
                        name: "FK_CPTSubCategory_CPTCategory",
                        column: x => x.cptcategoryid,
                        principalTable: "CPTCategory",
                        principalColumn: "cptcategoryid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "division",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupid = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    shortname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_division", x => x.ID);
                    table.ForeignKey(
                        name: "FK_division_group",
                        column: x => x.groupid,
                        principalTable: "group",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ICD10Diagnosis",
                columns: table => new
                {
                    serial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnosiscode = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    description = table.Column<string>(nullable: true),
                    longdescription = table.Column<string>(nullable: true),
                    comments = table.Column<string>(nullable: true),
                    icdcategoryid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICD10Diagnosis_1", x => x.serial);
                    table.ForeignKey(
                        name: "FK_ICD10Diagnosis_ICDCategory",
                        column: x => x.icdcategoryid,
                        principalTable: "ICDCategory",
                        principalColumn: "icdcategoryid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    appuserid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    firstname = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    lastname = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    middlename = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    phone1 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    phone2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    passwordhash = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    image = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    locationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Applicat__CF5F694F2AAD88F5", x => x.appuserid);
                    table.ForeignKey(
                        name: "FK__Applicati__locat__5C0D8F7B",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSchedule",
                columns: table => new
                {
                    genschid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    timeinterval = table.Column<int>(nullable: false),
                    adjuster = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    iscurrent = table.Column<bool>(nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    locationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GeneralS__370A00B8E685F8EB", x => x.genschid);
                    table.ForeignKey(
                        name: "FK__GeneralSc__locat__1451E89E",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    specid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specname = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    locationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Speciali__72C1C97BF664F5C7", x => x.specid);
                    table.ForeignKey(
                        name: "FK__Specializ__locat__172E5549",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProblemItem",
                columns: table => new
                {
                    itemid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medid = table.Column<int>(nullable: true),
                    itemname = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProblemItem", x => x.itemid);
                    table.ForeignKey(
                        name: "FK_MedicalProblemItem_MedicalProblemCategory",
                        column: x => x.medid,
                        principalTable: "MedicalProblemCategory",
                        principalColumn: "medid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderCategory",
                columns: table => new
                {
                    ordercategoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ordertypeid = table.Column<int>(nullable: true),
                    ordercategory = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    categorycomment = table.Column<string>(unicode: false, maxLength: 2000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCategory", x => x.ordercategoryid);
                    table.ForeignKey(
                        name: "fk_ordercategory_ordertype",
                        column: x => x.ordertypeid,
                        principalTable: "OrderType",
                        principalColumn: "ordertypeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "provider_network",
                columns: table => new
                {
                    providerid = table.Column<int>(nullable: false),
                    networkid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider_network", x => new { x.providerid, x.networkid });
                    table.ForeignKey(
                        name: "FK_provider_network_provider",
                        column: x => x.providerid,
                        principalTable: "provider",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaire",
                columns: table => new
                {
                    qid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    questioncategoryid = table.Column<int>(nullable: true),
                    question = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaire", x => x.qid);
                    table.ForeignKey(
                        name: "FK_Questionnaire_QuestionCategory",
                        column: x => x.questioncategoryid,
                        principalTable: "QuestionCategory",
                        principalColumn: "qcatid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "accesscontrol_user",
                columns: table => new
                {
                    access_controlID = table.Column<int>(nullable: false),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accesscontrol_user", x => new { x.access_controlID, x.userID });
                    table.ForeignKey(
                        name: "FK_accesscontrol_user_access_control",
                        column: x => x.access_controlID,
                        principalTable: "access_control",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_accesscontrol_user_user",
                        column: x => x.userID,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data_synchronization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    userid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_synchronization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_data_synchronization_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountManager",
                columns: table => new
                {
                    ProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    HospitalName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    HospitalAddress = table.Column<string>(unicode: false, nullable: true),
                    AdminEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Phone1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    stateid = table.Column<int>(nullable: true),
                    countryid = table.Column<int>(nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountManager", x => x.ProviderID);
                    table.ForeignKey(
                        name: "FK_AccountManager_country",
                        column: x => x.countryid,
                        principalTable: "country",
                        principalColumn: "countryid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountManager_State",
                        column: x => x.stateid,
                        principalTable: "State",
                        principalColumn: "stateid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPTProcedure",
                columns: table => new
                {
                    serial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPTCode = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CPTDescription = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    cptcategoryid = table.Column<int>(nullable: true),
                    cptsubcategoryid = table.Column<int>(nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPTProcedure", x => x.serial);
                    table.ForeignKey(
                        name: "FK_CPTProcedure_CPTCategory",
                        column: x => x.cptcategoryid,
                        principalTable: "CPTCategory",
                        principalColumn: "cptcategoryid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPTProcedure_CPTSubCategory",
                        column: x => x.cptsubcategoryid,
                        principalTable: "CPTSubCategory",
                        principalColumn: "cptsubcategoryid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BreakBlockSchedule",
                columns: table => new
                {
                    blockid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blockname = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    days = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    adjuster = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    iscurrent = table.Column<bool>(nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    locationid = table.Column<int>(nullable: true),
                    provid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BreakBlo__17B570224D59AC15", x => x.blockid);
                    table.ForeignKey(
                        name: "FK__BreakBloc__locat__70D3A237",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__BreakBloc__provi__71C7C670",
                        column: x => x.provid,
                        principalTable: "ApplicationUser",
                        principalColumn: "appuserid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderSchedule",
                columns: table => new
                {
                    provschid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    duration = table.Column<int>(nullable: false),
                    days = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    adjuster = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    iscurrent = table.Column<bool>(nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    locationid = table.Column<int>(nullable: true),
                    specid = table.Column<int>(nullable: true),
                    provid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Provider__0EF5CA8BD8860088", x => x.provschid);
                    table.ForeignKey(
                        name: "FK__ProviderS__locat__24885067",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ProviderS__provi__267098D9",
                        column: x => x.provid,
                        principalTable: "ApplicationUser",
                        principalColumn: "appuserid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ProviderS__speci__257C74A0",
                        column: x => x.specid,
                        principalTable: "Specialization",
                        principalColumn: "specid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecializationSchedule",
                columns: table => new
                {
                    specschid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    duration = table.Column<int>(nullable: false),
                    days = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    adjuster = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    iscurrent = table.Column<bool>(nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    locationid = table.Column<int>(nullable: true),
                    specid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Speciali__3A71E2D82A4295DC", x => x.specschid);
                    table.ForeignKey(
                        name: "FK__Specializ__locat__1A0AC1F4",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Specializ__speci__1AFEE62D",
                        column: x => x.specid,
                        principalTable: "Specialization",
                        principalColumn: "specid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderListing",
                columns: table => new
                {
                    orderlistid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ordertypeid = table.Column<int>(nullable: true),
                    ordertype = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    orderthreshold = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ordercategoryid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orderlisting", x => x.orderlistid);
                    table.ForeignKey(
                        name: "fk_ordercat_orderlisting",
                        column: x => x.ordercategoryid,
                        principalTable: "OrderCategory",
                        principalColumn: "ordercategoryid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordertype_orderlisting",
                        column: x => x.ordertypeid,
                        principalTable: "OrderType",
                        principalColumn: "ordertypeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    userid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titleid = table.Column<int>(nullable: true),
                    username = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    secretquestion = table.Column<string>(unicode: false, nullable: true),
                    secretanswer = table.Column<string>(unicode: false, nullable: true),
                    firstname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    lastname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true),
                    IdentificationModeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.userid);
                    table.ForeignKey(
                        name: "FK_AppUser_IdentificationMode_IdentificationModeid",
                        column: x => x.IdentificationModeid,
                        principalTable: "IdentificationMode",
                        principalColumn: "IdentificationModeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_appuser_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Title_AppUser",
                        column: x => x.titleid,
                        principalTable: "Title",
                        principalColumn: "titleid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    comment = table.Column<string>(nullable: true),
                    providerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssetType_Provider",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bed",
                columns: table => new
                {
                    bedid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bednumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    wardid = table.Column<int>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    bedname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bed", x => x.bedid);
                    table.ForeignKey(
                        name: "fk_bed_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bed_Ward",
                        column: x => x.wardid,
                        principalTable: "Ward",
                        principalColumn: "wardid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CentralStore",
                columns: table => new
                {
                    centralstoreid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugid = table.Column<int>(nullable: true),
                    drugcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    packetno = table.Column<int>(nullable: true),
                    units = table.Column<int>(nullable: true),
                    extqty = table.Column<int>(nullable: true),
                    costprice = table.Column<double>(nullable: true),
                    reorderlevel = table.Column<int>(nullable: true),
                    manufacturedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    unitofstorage = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentralStore", x => x.centralstoreid);
                    table.ForeignKey(
                        name: "fk_centralstore_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation",
                columns: table => new
                {
                    consultationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staffid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    patienttype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    arrivaltime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    departuretime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    complaints = table.Column<string>(unicode: false, nullable: true),
                    chronicdisease = table.Column<string>(unicode: false, nullable: true),
                    findings = table.Column<string>(unicode: false, nullable: true),
                    complainthistory = table.Column<string>(type: "text", nullable: true),
                    subjective = table.Column<string>(unicode: false, nullable: true),
                    objective = table.Column<string>(unicode: false, nullable: true),
                    assessment = table.Column<string>(unicode: false, nullable: true),
                    plan = table.Column<string>(unicode: false, nullable: true),
                    advice = table.Column<string>(unicode: false, nullable: true),
                    hmoid = table.Column<int>(nullable: true),
                    isdocattached = table.Column<bool>(nullable: true),
                    docname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    docpath = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    consultationdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    casenotes = table.Column<string>(unicode: false, nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    isbillgenerated = table.Column<bool>(nullable: true),
                    proceduredone = table.Column<string>(type: "text", nullable: true),
                    notenote = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation", x => x.consultationid);
                    table.ForeignKey(
                        name: "fk_consultation_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Radiology",
                columns: table => new
                {
                    labkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consultationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    labserviceid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    arrivaltime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    departuretime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    patienttype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    labnotes = table.Column<string>(unicode: false, nullable: true),
                    isdocattached = table.Column<bool>(nullable: true),
                    docname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    docpath = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    labdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Radiology", x => x.labkey);
                    table.ForeignKey(
                        name: "fk_consultationrad_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    deptid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.deptid);
                    table.ForeignKey(
                        name: "fk_dept_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "diagnosis",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    comments = table.Column<string>(nullable: true),
                    genderconstraint = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosis", x => x.ID);
                    table.ForeignKey(
                        name: "fk_diagnosis_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "enrollee_type",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrollee_type", x => x.ID);
                    table.ForeignKey(
                        name: "fk_enrolleetype_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HmoType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<bool>(nullable: true),
                    providerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmoType", x => x.id);
                    table.ForeignKey(
                        name: "FK_HmoType_Provider",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LicenseManager",
                columns: table => new
                {
                    LicenseKey = table.Column<Guid>(nullable: false),
                    LicenseStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    LicenseEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    RecordLimit = table.Column<int>(nullable: true),
                    IsFirstTimeLogin = table.Column<bool>(nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseManager", x => x.LicenseKey);
                    table.ForeignKey(
                        name: "fk_license_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    AccountID = table.Column<Guid>(nullable: true),
                    IsNewUser = table.Column<bool>(nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    IsLoggedIn = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginID);
                    table.ForeignKey(
                        name: "fk_login_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "procedure",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    procedurename = table.Column<string>(nullable: true),
                    procedurecode = table.Column<string>(nullable: true),
                    procedurepa = table.Column<string>(nullable: true),
                    procedurepp = table.Column<string>(nullable: true),
                    procedurereferral = table.Column<string>(nullable: true),
                    procedurepr = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    genderconstraint = table.Column<int>(nullable: true),
                    procedurecatid = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedure", x => x.ID);
                    table.ForeignKey(
                        name: "fk_procedure_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingStore",
                columns: table => new
                {
                    receivingstoreid = table.Column<int>(nullable: false),
                    storename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    storedescription = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingStore", x => x.receivingstoreid);
                    table.ForeignKey(
                        name: "fk_recvstore_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    roleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    roledescription = table.Column<string>(unicode: false, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.roleid);
                    table.ForeignKey(
                        name: "fk_role_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    supplierid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    suppliername = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    suppliertypeid = table.Column<int>(nullable: true),
                    contactname = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    address1 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    address2 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    phone1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    phone2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    website = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    bankname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    bankaccountno = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    specialty = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    comments = table.Column<string>(unicode: false, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    providerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.supplierid);
                    table.ForeignKey(
                        name: "FK_Supplier_provider",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_supplier_type",
                        column: x => x.suppliertypeid,
                        principalTable: "SupplierType",
                        principalColumn: "suppliertypeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tariff",
                columns: table => new
                {
                    tariffid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tariffname = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    tariffdesc = table.Column<string>(unicode: false, maxLength: 2000, nullable: true),
                    expirydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariff", x => x.tariffid);
                    table.ForeignKey(
                        name: "fk_tariff_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Location",
                columns: table => new
                {
                    userlocationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Location", x => x.userlocationid);
                    table.ForeignKey(
                        name: "Location_User_Location",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "AppUser_User_Location",
                        column: x => x.userid,
                        principalTable: "AppUser",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Antenatal_Record",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    categoryid = table.Column<int>(nullable: true),
                    record = table.Column<string>(nullable: true),
                    details = table.Column<string>(nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antenatal_Record", x => x.id);
                    table.ForeignKey(
                        name: "FK_Antenatal_Record_Patient",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill_Detail",
                columns: table => new
                {
                    billdetailid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    billid = table.Column<int>(nullable: true),
                    serviceid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    servicedesc = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    amount = table.Column<double>(nullable: true),
                    servicetype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    comments = table.Column<string>(unicode: false, nullable: true),
                    billtype = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    dateofservice = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_Detail", x => x.billdetailid);
                    table.ForeignKey(
                        name: "FK_Bill_Detail_Department",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_billdetail_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    staffid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    firstname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    middlename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    titleid = table.Column<int>(nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(unicode: false, nullable: true),
                    mobilephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    homephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    workphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    emergencycontact = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    emergencyphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    designationid = table.Column<int>(nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    IdentificationModeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.staffid);
                    table.ForeignKey(
                        name: "FK_Personnel_Department",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnel_Designation",
                        column: x => x.designationid,
                        principalTable: "Designation",
                        principalColumn: "desigid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnel_IdentificationMode_IdentificationModeid",
                        column: x => x.IdentificationModeid,
                        principalTable: "IdentificationMode",
                        principalColumn: "IdentificationModeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_personnel_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnel_Title",
                        column: x => x.titleid,
                        principalTable: "Title",
                        principalColumn: "titleid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    serviceid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicedesc = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    servicetypeid = table.Column<int>(nullable: true),
                    servicecode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.serviceid);
                    table.ForeignKey(
                        name: "FK_Service_Department",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_service_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_ServiceType",
                        column: x => x.servicetypeid,
                        principalTable: "ServiceType",
                        principalColumn: "servicetypeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "enrollee",
                columns: table => new
                {
                    ID_e = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname_e = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    lastname_e = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    othername_e = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    title_e = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    gender_e = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    addressline1_e = table.Column<string>(nullable: true),
                    addressline2_e = table.Column<string>(nullable: true),
                    dob_e = table.Column<DateTime>(type: "date", nullable: true),
                    maritalstatus = table.Column<string>(nullable: true),
                    phone_e = table.Column<string>(nullable: true),
                    coveragestartdate = table.Column<DateTime>(type: "date", nullable: true),
                    coverageenddate = table.Column<DateTime>(type: "date", nullable: true),
                    effectivedate = table.Column<DateTime>(type: "date", nullable: true),
                    terminationdate = table.Column<DateTime>(type: "date", nullable: true),
                    planeffectivedate = table.Column<DateTime>(type: "date", nullable: true),
                    planterminationdate = table.Column<DateTime>(type: "date", nullable: true),
                    providereffectivedate = table.Column<DateTime>(type: "date", nullable: true),
                    providerterminationdate = table.Column<DateTime>(type: "date", nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    hmocode1 = table.Column<string>(nullable: true),
                    hmocode2 = table.Column<string>(nullable: true),
                    hmocode3 = table.Column<string>(nullable: true),
                    principalCode = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    market = table.Column<string>(nullable: true),
                    providerReason = table.Column<string>(nullable: true),
                    nextofkin = table.Column<string>(nullable: true),
                    nextofkinaddress = table.Column<string>(nullable: true),
                    nextofkinphone = table.Column<string>(nullable: true),
                    dateenrolleed = table.Column<DateTime>(type: "date", nullable: true),
                    formreceiveddate = table.Column<DateTime>(type: "date", nullable: true),
                    formprocesseddate = table.Column<DateTime>(type: "date", nullable: true),
                    receiptnum = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    syncid = table.Column<string>(nullable: true),
                    flag = table.Column<string>(nullable: true),
                    issynced = table.Column<bool>(nullable: true),
                    sync_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    plainid = table.Column<int>(nullable: true),
                    providerid = table.Column<int>(nullable: true),
                    networkid = table.Column<int>(nullable: true),
                    userid = table.Column<int>(nullable: true),
                    groupid = table.Column<int>(nullable: true),
                    enrolleetypeid = table.Column<int>(nullable: true),
                    divisionid = table.Column<int>(nullable: true),
                    officeaddress = table.Column<string>(nullable: true),
                    officecity = table.Column<string>(maxLength: 500, nullable: true),
                    officeLGA = table.Column<string>(maxLength: 250, nullable: true),
                    officestate = table.Column<string>(maxLength: 250, nullable: true),
                    cardnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrollee", x => x.ID_e);
                    table.ForeignKey(
                        name: "FK_enrollee_division",
                        column: x => x.divisionid,
                        principalTable: "division",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_enrollee_enrollee_type",
                        column: x => x.enrolleetypeid,
                        principalTable: "enrollee_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_enrollee_group",
                        column: x => x.groupid,
                        principalTable: "group",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_enrollee_network",
                        column: x => x.networkid,
                        principalTable: "network",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_enrollee_plan",
                        column: x => x.plainid,
                        principalTable: "plan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_enrollee_provider",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_enrollee_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    firstname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    lastname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    othername = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dob = table.Column<DateTime>(type: "date", nullable: true),
                    securityid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    securitynumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(unicode: false, nullable: true),
                    stateid = table.Column<int>(nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    country = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    postalcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mothername = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    guardianname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    emergencycontact = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    emergencyphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    nokrelationship = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    nokoccupation = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    nokworkaddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    homephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    workphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mobilephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    occupation = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    photopath = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    employername = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    employeraddress = table.Column<string>(unicode: false, nullable: true),
                    employercity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    employerstateid = table.Column<int>(nullable: true),
                    employercountry = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateofdeath = table.Column<DateTime>(type: "date", nullable: true),
                    deathcause = table.Column<string>(unicode: false, nullable: true),
                    hmoclass1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmoname1 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    hmoclass2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmoname2 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    hmoclass3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmoname3 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    principalcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    relationship = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    inactive = table.Column<bool>(nullable: true),
                    cardtypeid = table.Column<int>(nullable: true),
                    datedeactivated = table.Column<DateTime>(type: "datetime", nullable: true),
                    HMONumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    genotype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    alternateID1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    alternateID2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    autoid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicetype = table.Column<string>(nullable: true),
                    plantype = table.Column<string>(nullable: true),
                    maritalstatusid = table.Column<int>(nullable: true),
                    nationality = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    nokinname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    nokphonenumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    accountcategory = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    genderid = table.Column<int>(nullable: true),
                    genotypeid = table.Column<int>(nullable: true),
                    bloodgroupid = table.Column<int>(nullable: true),
                    sponsid = table.Column<int>(nullable: true),
                    facilitatorid = table.Column<int>(nullable: true),
                    refid = table.Column<int>(nullable: true),
                    leadid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.patientid);
                    table.ForeignKey(
                        name: "FK_BloodGroup_Patient",
                        column: x => x.bloodgroupid,
                        principalTable: "BloodGroup",
                        principalColumn: "bloodgroupid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_enrollee_type",
                        column: x => x.cardtypeid,
                        principalTable: "enrollee_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealthCareFacilitator_Patient",
                        column: x => x.facilitatorid,
                        principalTable: "HealthCareFacilitator",
                        principalColumn: "facilitatorid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Gender_Patient",
                        column: x => x.genderid,
                        principalTable: "Gender",
                        principalColumn: "genderid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Genotype_Patient",
                        column: x => x.genotypeid,
                        principalTable: "GenoType",
                        principalColumn: "genotypeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leadsource_Patient",
                        column: x => x.leadid,
                        principalTable: "LeadSource",
                        principalColumn: "leadid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marital_Patient",
                        column: x => x.maritalstatusid,
                        principalTable: "maritalstatus",
                        principalColumn: "maritalstatusid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_patient_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Referral_Patient",
                        column: x => x.refid,
                        principalTable: "Referral",
                        principalColumn: "refid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sponsor_Patient",
                        column: x => x.sponsid,
                        principalTable: "Sponsor",
                        principalColumn: "sponsid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "State_Patient",
                        column: x => x.stateid,
                        principalTable: "State",
                        principalColumn: "stateid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HMO",
                columns: table => new
                {
                    hmoid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hmoname = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    hmoaddress = table.Column<string>(unicode: false, nullable: true),
                    stateid = table.Column<int>(nullable: true),
                    hmocountry = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmocontact = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    hmophone1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmophone2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    typeid = table.Column<int>(nullable: true),
                    hmonumber = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HMO", x => x.hmoid);
                    table.ForeignKey(
                        name: "State_HMO",
                        column: x => x.stateid,
                        principalTable: "State",
                        principalColumn: "stateid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HMO_HmoType",
                        column: x => x.typeid,
                        principalTable: "HmoType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Role",
                columns: table => new
                {
                    userroleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(nullable: true),
                    roleid = table.Column<int>(nullable: true),
                    permission = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Role", x => x.userroleid);
                    table.ForeignKey(
                        name: "Role_User_Role",
                        column: x => x.roleid,
                        principalTable: "Role",
                        principalColumn: "roleid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "AppUser_User_Role",
                        column: x => x.userid,
                        principalTable: "AppUser",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    name = table.Column<string>(nullable: true),
                    supplierid = table.Column<int>(nullable: true),
                    details = table.Column<string>(nullable: true),
                    typeid = table.Column<int>(nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    rate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    locationid = table.Column<int>(nullable: true),
                    receiptNum = table.Column<string>(nullable: true),
                    comment = table.Column<string>(nullable: true),
                    providerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.id);
                    table.ForeignKey(
                        name: "FK_Asset_Location",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Provider",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Supplier",
                        column: x => x.supplierid,
                        principalTable: "Supplier",
                        principalColumn: "supplierid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType",
                        column: x => x.typeid,
                        principalTable: "AssetType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drug",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    name = table.Column<string>(nullable: true),
                    drugcategoryid = table.Column<int>(nullable: true),
                    brandname = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    manufacturer = table.Column<string>(nullable: true),
                    dispensingrate = table.Column<string>(nullable: true),
                    indication = table.Column<string>(nullable: true),
                    dosage = table.Column<string>(nullable: true),
                    contrindications = table.Column<string>(nullable: true),
                    adverseeffect = table.Column<string>(nullable: true),
                    supplierid = table.Column<int>(nullable: true),
                    stock = table.Column<int>(nullable: true),
                    expirydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    productiondate = table.Column<DateTime>(type: "datetime", nullable: true),
                    unitprice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    comment = table.Column<string>(nullable: true),
                    uploaded_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    providerid = table.Column<int>(nullable: true),
                    reorder_quantity = table.Column<int>(nullable: true),
                    lastNotificationID = table.Column<int>(nullable: true),
                    drugtype = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    unitofstorage = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drug", x => x.id);
                    table.ForeignKey(
                        name: "FK_Drug_DrugCategory",
                        column: x => x.drugcategoryid,
                        principalTable: "DrugCategory",
                        principalColumn: "drugcategoryid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drug_Provider",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drug_Supplier",
                        column: x => x.supplierid,
                        principalTable: "Supplier",
                        principalColumn: "supplierid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    appointmentid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    staffid = table.Column<int>(nullable: true),
                    appointmentdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    appointmenttime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    comments = table.Column<string>(unicode: false, nullable: true),
                    appointmentenddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    subject = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    locationid = table.Column<int>(nullable: true),
                    accountid = table.Column<int>(nullable: true),
                    reasonforvisit = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.appointmentid);
                    table.ForeignKey(
                        name: "FK_Department_Appointment",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Department_Staff",
                        column: x => x.staffid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "audit_log",
                columns: table => new
                {
                    auditlogid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    systemid = table.Column<string>(unicode: false, nullable: true),
                    actionperformed = table.Column<string>(unicode: false, nullable: true),
                    formaccessed = table.Column<string>(unicode: false, nullable: true),
                    modulename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    userid = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audit_log", x => x.auditlogid);
                    table.ForeignKey(
                        name: "fk_auditlog_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_audit_log_user",
                        column: x => x.userid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messaging",
                columns: table => new
                {
                    msgID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    senderID = table.Column<int>(nullable: true),
                    recieverID = table.Column<int>(nullable: true),
                    datesent = table.Column<DateTime>(type: "datetime", nullable: true),
                    subject = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: false),
                    isRead = table.Column<bool>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messaging", x => x.msgID);
                    table.ForeignKey(
                        name: "fk_messaging_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messaging_Personnel1",
                        column: x => x.recieverID,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messaging_Personnel",
                        column: x => x.senderID,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service_Tariff",
                columns: table => new
                {
                    servtariffid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serviceid = table.Column<int>(nullable: true),
                    tariffid = table.Column<int>(nullable: true),
                    tariffamount = table.Column<double>(nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Tariff", x => x.servtariffid);
                    table.ForeignKey(
                        name: "fk_servicetariff_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Tariff_Service",
                        column: x => x.serviceid,
                        principalTable: "Service",
                        principalColumn: "serviceid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Tariff_Tariff",
                        column: x => x.tariffid,
                        principalTable: "Tariff",
                        principalColumn: "tariffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dependant_info",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    position = table.Column<string>(unicode: false, nullable: true),
                    value = table.Column<string>(unicode: false, nullable: true),
                    relationship = table.Column<string>(unicode: false, nullable: true),
                    enrolleeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependant_info", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dependant_info_enrollee",
                        column: x => x.enrolleeid,
                        principalTable: "enrollee",
                        principalColumn: "ID_e",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "provider_change",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oldprovider = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    sequence = table.Column<int>(nullable: true),
                    reason = table.Column<string>(nullable: true),
                    providereffectivedate = table.Column<DateTime>(type: "date", nullable: true),
                    providerterminationdate = table.Column<DateTime>(type: "date", nullable: true),
                    enrolleeID = table.Column<int>(nullable: true),
                    issynced = table.Column<bool>(nullable: true),
                    synced_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    userid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider_change", x => x.ID);
                    table.ForeignKey(
                        name: "FK_provider_change_enrollee",
                        column: x => x.enrolleeID,
                        principalTable: "enrollee",
                        principalColumn: "ID_e",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_provider_change_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "renewal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coveragestatedate = table.Column<DateTime>(type: "date", nullable: true),
                    coverageenddate = table.Column<DateTime>(type: "date", nullable: true),
                    amountpaid = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    paymentstatus = table.Column<string>(nullable: true),
                    amountdue = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    receiptnum = table.Column<string>(nullable: true),
                    reasonfortermination = table.Column<string>(nullable: true),
                    isexpires = table.Column<bool>(nullable: true),
                    mutation = table.Column<bool>(nullable: true),
                    contractnum = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    userid = table.Column<int>(nullable: true),
                    syncid = table.Column<string>(maxLength: 50, nullable: true),
                    flag = table.Column<string>(nullable: true),
                    issynced = table.Column<bool>(nullable: true),
                    synced_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    enrolleeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_renewal", x => x.ID);
                    table.ForeignKey(
                        name: "FK_renewal_enrollee",
                        column: x => x.enrolleeid,
                        principalTable: "enrollee",
                        principalColumn: "ID_e",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_renewal_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "utilization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enrolleeid = table.Column<int>(nullable: true),
                    respiration = table.Column<string>(nullable: true),
                    pulse = table.Column<string>(nullable: true),
                    temprature = table.Column<string>(nullable: true),
                    height = table.Column<string>(nullable: true),
                    weight = table.Column<string>(nullable: true),
                    bloodpressure = table.Column<string>(nullable: true),
                    encounterdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    visitoutcome = table.Column<string>(nullable: true),
                    dateDied = table.Column<DateTime>(type: "datetime", nullable: true),
                    isReferred = table.Column<bool>(nullable: true),
                    referredFrom = table.Column<int>(nullable: true),
                    referredTo = table.Column<int>(nullable: true),
                    diagnosisID = table.Column<int>(nullable: true),
                    testingDoctor = table.Column<string>(nullable: true),
                    visitInfoEncounterDate = table.Column<DateTime>(type: "date", nullable: true),
                    note = table.Column<string>(type: "text", nullable: true),
                    isNewBorn = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    isinpatient = table.Column<bool>(nullable: true),
                    dischargeddate = table.Column<DateTime>(type: "date", nullable: true),
                    issynced = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    sync_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    userid = table.Column<int>(nullable: true),
                    isvisitscheduled = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    visiType = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utilization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_utilization_enrollee",
                        column: x => x.enrolleeid,
                        principalTable: "enrollee",
                        principalColumn: "ID_e",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_utilization_provider",
                        column: x => x.referredFrom,
                        principalTable: "provider",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_utilization_provider1",
                        column: x => x.referredTo,
                        principalTable: "provider",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_utilization_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admission",
                columns: table => new
                {
                    admissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    staffid = table.Column<int>(nullable: true),
                    complaints = table.Column<string>(nullable: true),
                    clinicalSummary = table.Column<string>(nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    dateadmitted = table.Column<DateTime>(type: "datetime", nullable: true),
                    bedid = table.Column<int>(nullable: true),
                    admissiontime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dischargedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    dischargetime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    estimateddischarge = table.Column<DateTime>(type: "datetime", nullable: true),
                    dischargedBy = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admission", x => x.admissionID);
                    table.ForeignKey(
                        name: "FK_Admission_Bed",
                        column: x => x.bedid,
                        principalTable: "Bed",
                        principalColumn: "bedid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admission_Department",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admission_Personnel1",
                        column: x => x.dischargedBy,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admission_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_admission_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admission_Personnel",
                        column: x => x.staffid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentSchedule",
                columns: table => new
                {
                    apptid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    starttime = table.Column<DateTime>(type: "datetime", nullable: false),
                    endtime = table.Column<DateTime>(type: "datetime", nullable: false),
                    reason = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    isrecurring = table.Column<bool>(nullable: false),
                    recurrencerule = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    adjuster = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    locationid = table.Column<int>(nullable: true),
                    specid = table.Column<int>(nullable: true),
                    provid = table.Column<int>(nullable: true),
                    referralid = table.Column<int>(nullable: true),
                    referringid = table.Column<int>(nullable: true),
                    statusid = table.Column<int>(nullable: true),
                    visittypeid = table.Column<int>(nullable: true),
                    reminderid = table.Column<int>(nullable: true),
                    patientNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Appointm__6670983A2FEC3E03", x => x.apptid);
                    table.ForeignKey(
                        name: "FK__Appointme__locat__28E2F130",
                        column: x => x.locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__patie__308412F8",
                        column: x => x.patientNumber,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__provi__2ACB39A2",
                        column: x => x.provid,
                        principalTable: "ApplicationUser",
                        principalColumn: "appuserid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__refer__2BBF5DDB",
                        column: x => x.referralid,
                        principalTable: "Referral",
                        principalColumn: "refid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__refer__2CB38214",
                        column: x => x.referringid,
                        principalTable: "ReferringPhysician",
                        principalColumn: "refid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__remin__2F8FEEBF",
                        column: x => x.reminderid,
                        principalTable: "Reminder",
                        principalColumn: "reminderid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__speci__29D71569",
                        column: x => x.specid,
                        principalTable: "Specialization",
                        principalColumn: "specid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__statu__2DA7A64D",
                        column: x => x.statusid,
                        principalTable: "AppointmentStatus",
                        principalColumn: "statusid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__visit__2E9BCA86",
                        column: x => x.visittypeid,
                        principalTable: "VisitType",
                        principalColumn: "typeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    billid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    staffid = table.Column<int>(nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    consultationfee = table.Column<double>(nullable: true),
                    paymentconfirmed = table.Column<bool>(nullable: true),
                    accounttypeid = table.Column<int>(nullable: true),
                    tariffid = table.Column<int>(nullable: true),
                    batchno = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    billdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    comments = table.Column<string>(unicode: false, maxLength: 2000, nullable: true),
                    billclosedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    isHMOPayment = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.billid);
                    table.ForeignKey(
                        name: "FK_Bill_AccountType",
                        column: x => x.accounttypeid,
                        principalTable: "AccountType",
                        principalColumn: "accttypeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_bill_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Personnel",
                        column: x => x.staffid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Tariff",
                        column: x => x.tariffid,
                        principalTable: "Tariff",
                        principalColumn: "tariffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Biometric",
                columns: table => new
                {
                    biometricid = table.Column<int>(nullable: false),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fingerindex = table.Column<string>(unicode: false, nullable: true),
                    fingertemplate = table.Column<string>(unicode: false, nullable: true),
                    quality = table.Column<string>(unicode: false, nullable: true),
                    wsqformat = table.Column<string>(unicode: false, nullable: true),
                    fingername = table.Column<string>(unicode: false, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biometric", x => x.biometricid);
                    table.ForeignKey(
                        name: "Patient_Biometric",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_biometric_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BirthRegister",
                columns: table => new
                {
                    babyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    deliverydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    deliverytype = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    gender = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    familyname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    birthweight = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    babycount = table.Column<int>(nullable: true),
                    notes = table.Column<string>(unicode: false, nullable: true),
                    staffid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthRegister", x => x.babyid);
                    table.ForeignKey(
                        name: "FK_BirthRegister_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_birthregister_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirthRegister_Personnel",
                        column: x => x.staffid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckIn",
                columns: table => new
                {
                    encounterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patientid = table.Column<string>(nullable: true),
                    Accountid = table.Column<int>(nullable: false),
                    Locationid = table.Column<int>(nullable: false),
                    ischeckedin = table.Column<bool>(type: "bit", nullable: false),
                    ischeckedout = table.Column<bool>(type: "bit", nullable: false),
                    checkindate = table.Column<DateTime>(type: "datetime", nullable: false),
                    checkoutdate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Checke__3A71E2D82A4295FC", x => x.encounterId);
                    table.ForeignKey(
                        name: "FK_CheckIn_Patient_Account",
                        column: x => x.Accountid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIn_Location",
                        column: x => x.Locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIn_Patient",
                        column: x => x.Patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Check",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consultationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    checkid = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    details = table.Column<string>(unicode: false, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Check_1", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Check_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Check_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultationcheck_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Complaints",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    complaints = table.Column<string>(maxLength: 250, nullable: true),
                    duration = table.Column<string>(maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Complaints", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Complaints_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultation_Complaints_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultation_Complaints_AccountManager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Dental",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    extraoralexamfa = table.Column<string>(maxLength: 50, nullable: true),
                    extraoralexamtmj = table.Column<string>(maxLength: 50, nullable: true),
                    extraoralexamswe = table.Column<string>(maxLength: 50, nullable: true),
                    extraoralexamlav = table.Column<string>(maxLength: 50, nullable: true),
                    intraoralexamtris = table.Column<string>(maxLength: 50, nullable: true),
                    intraoralexamoralhyj = table.Column<string>(maxLength: 50, nullable: true),
                    intraoralexamgingivae = table.Column<string>(maxLength: 50, nullable: true),
                    tp = table.Column<string>(nullable: true),
                    ct = table.Column<string>(nullable: true),
                    ft = table.Column<string>(nullable: true),
                    dt = table.Column<string>(nullable: true),
                    ttp = table.Column<string>(nullable: true),
                    displacement = table.Column<string>(nullable: true),
                    treatmentplan = table.Column<string>(nullable: true),
                    treatmentdone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Dental", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Dental_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Dental_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Dental_AccountManager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_DentalProcedure",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    treatmentplan = table.Column<string>(nullable: true),
                    toothno = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_DentalProcedure", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_DentalProcedure_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_DentalProcedure_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_DentalProcedure_AccountManager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Diagnosis",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    diagnosiscode = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Diagnosis", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Diagnosis_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Diagnosis_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultationdiagnosis_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_OtherDiagnosis",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    otherdiagnosis = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_OtherDiagnosis", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_OtherDiagnosis_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultation_OtherDiagnosis_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultation_OtherDiagnosis_AccountManager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Prescription",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    drugcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    drugtype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    drugstrength = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    isdocattached = table.Column<bool>(nullable: true),
                    docname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    docpath = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    quantity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    units = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dosage = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    frequency = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    duration = table.Column<int>(nullable: true),
                    prescriptionnotes = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    isdispensed = table.Column<bool>(nullable: true),
                    isundispensed = table.Column<bool>(nullable: true),
                    dispensedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    dispensenotes = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    injectionflow = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Prescription", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Prescription_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Prescription_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultationprescription_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Problem",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    consultationid = table.Column<int>(nullable: true),
                    problem = table.Column<string>(maxLength: 250, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Problem", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Problem_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Problem_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Problem_AccountManager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Procedure",
                columns: table => new
                {
                    txnkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consultationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    procedurecode = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    panumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Procedure", x => x.txnkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Procedure_Consultation",
                        column: x => x.consultationid,
                        principalTable: "Consultation",
                        principalColumn: "consultationid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Procedure_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultationprocedure_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fingerprint",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    index = table.Column<string>(unicode: false, nullable: true),
                    image = table.Column<byte[]>(nullable: true),
                    quality = table.Column<int>(nullable: true),
                    wsqformat = table.Column<byte[]>(nullable: true),
                    fingername = table.Column<string>(unicode: false, nullable: true),
                    issynced = table.Column<bool>(nullable: true),
                    sync_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fingerprint", x => x.ID);
                    table.ForeignKey(
                        name: "FK_fingerprint_enrollee",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_fingerprint_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaRequest",
                columns: table => new
                {
                    PARequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    PaStatus = table.Column<string>(nullable: true),
                    PaNumber = table.Column<string>(nullable: true),
                    ProcedureId = table.Column<int>(nullable: false),
                    UnitCharge = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    IssuerComment = table.Column<string>(nullable: true),
                    RequestDate = table.Column<DateTime>(nullable: true),
                    PatientId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaRequest", x => x.PARequestId);
                    table.ForeignKey(
                        name: "FK_PaRequest_Account",
                        column: x => x.AccountId,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaRequest_Location",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaRequest_Patient",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaRequest_Procedure",
                        column: x => x.ProcedureId,
                        principalTable: "procedure",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_MedicalHistory",
                columns: table => new
                {
                    pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    problemid = table.Column<int>(nullable: true),
                    problemdesc = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    datestart = table.Column<DateTime>(type: "date", nullable: true),
                    dateend = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    occurence = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    diagnosiscode = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    reaction = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    comments = table.Column<string>(unicode: false, nullable: true),
                    dateadded = table.Column<DateTime>(type: "date", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_MedicalHistory", x => x.pid);
                    table.ForeignKey(
                        name: "FK_Patient_MedicalHistory_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MedicalHistory_MedicalProblemItem",
                        column: x => x.problemid,
                        principalTable: "MedicalProblemItem",
                        principalColumn: "itemid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_patientmh_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Order",
                columns: table => new
                {
                    patientorderid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ordertypeid = table.Column<int>(nullable: true),
                    orderlistid = table.Column<int>(nullable: true),
                    orderstatusid = table.Column<int>(nullable: true),
                    ordercomment = table.Column<string>(unicode: false, nullable: true),
                    raisedby = table.Column<int>(nullable: true),
                    completedby = table.Column<int>(nullable: true),
                    docpath = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    docimage = table.Column<byte[]>(type: "image", nullable: true),
                    orderdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ordercategoryid = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Order", x => x.patientorderid);
                    table.ForeignKey(
                        name: "fk_patient_order_personnel",
                        column: x => x.completedby,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordercat_patient_order",
                        column: x => x.ordercategoryid,
                        principalTable: "OrderCategory",
                        principalColumn: "ordercategoryid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orderlisting_patient_order",
                        column: x => x.orderlistid,
                        principalTable: "OrderListing",
                        principalColumn: "orderlistid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orderstatus_patient_order",
                        column: x => x.orderstatusid,
                        principalTable: "OrderStatus",
                        principalColumn: "orderstatusid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordertype_patient_order",
                        column: x => x.ordertypeid,
                        principalTable: "OrderType",
                        principalColumn: "ordertypeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_patient_patient_order",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_patientorder_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_patient_doctor_personnel",
                        column: x => x.raisedby,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Questionnaire",
                columns: table => new
                {
                    pqid = table.Column<int>(nullable: false),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    qid = table.Column<int>(nullable: true),
                    qcatid = table.Column<int>(nullable: true),
                    patientanswer = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Questionnaire", x => x.pqid);
                    table.ForeignKey(
                        name: "FK_Patient_Questionnaire_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_patientques_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Questionnaire_QuestionCategory",
                        column: x => x.qcatid,
                        principalTable: "QuestionCategory",
                        principalColumn: "qcatid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Questionnaire_Questionnaire",
                        column: x => x.qid,
                        principalTable: "Questionnaire",
                        principalColumn: "qid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientQueue",
                columns: table => new
                {
                    PatientQueueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(nullable: true),
                    AccountId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    HospitalUnitId = table.Column<int>(nullable: false),
                    EncounterId = table.Column<int>(nullable: false),
                    LastVisit = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientQueue", x => x.PatientQueueId);
                    table.ForeignKey(
                        name: "FK_PatientQueue_Account",
                        column: x => x.AccountId,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientQueue_HospitalUnit",
                        column: x => x.HospitalUnitId,
                        principalTable: "HospitalUnit",
                        principalColumn: "HospitalUnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientQueue_Location",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientQueue_Patient",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<byte[]>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    issynced = table.Column<bool>(nullable: true),
                    sync_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_photo_enrollee",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueueManager",
                columns: table => new
                {
                    listID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fromPersonnelid = table.Column<int>(nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    isSeen = table.Column<bool>(nullable: true),
                    isRemoved = table.Column<bool>(nullable: true),
                    removedBy = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    benpackageid = table.Column<int>(nullable: true),
                    toPersonnelid = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    isflagged = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueManager", x => x.listID);
                    table.ForeignKey(
                        name: "FK_QueueManager_BenefitPackage",
                        column: x => x.benpackageid,
                        principalTable: "BenefitPackage",
                        principalColumn: "benpackageid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueManager_Department",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueManager_Personnel",
                        column: x => x.fromPersonnelid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueManager_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_queuemgr_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueManager_Personnel1",
                        column: x => x.removedBy,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueManager_Personnel2",
                        column: x => x.toPersonnelid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reference_Material",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ProviderID = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    filepath = table.Column<string>(nullable: false),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    type = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference_Material", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reference_Material_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reference_Material_AccountManager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Verification_Log",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    userid = table.Column<int>(nullable: true),
                    mode = table.Column<string>(maxLength: 50, nullable: true),
                    issynced = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    sync_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    isseen = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verification_Log", x => x.ID);
                    table.ForeignKey(
                        name: "FK_verification_log_enrollee",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_verificationlog_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_verification_log_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authorisation",
                columns: table => new
                {
                    authorisationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    authorisationcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    approvallist = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    procedurecodes = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    hmoid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    nameofapprover = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    treatmentoption = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorisation", x => x.authorisationid);
                    table.ForeignKey(
                        name: "fk_hmo",
                        column: x => x.hmoid,
                        principalTable: "HMO",
                        principalColumn: "hmoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hmoMonthlyList",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastname = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    othernames = table.Column<string>(nullable: true),
                    patientHmoNumber = table.Column<string>(nullable: true),
                    plancode = table.Column<string>(nullable: true),
                    planname = table.Column<string>(nullable: true),
                    servicetype = table.Column<string>(maxLength: 50, nullable: true),
                    phone = table.Column<string>(nullable: true),
                    companyname = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    month = table.Column<string>(nullable: true),
                    hmoname = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    startdate = table.Column<string>(maxLength: 50, nullable: true),
                    enddate = table.Column<string>(maxLength: 50, nullable: true),
                    isResolved = table.Column<bool>(nullable: true),
                    year = table.Column<string>(maxLength: 50, nullable: true),
                    uploaddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    dob = table.Column<DateTime>(type: "datetime", nullable: true),
                    gender = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hmoMonthlyList", x => x.id);
                    table.ForeignKey(
                        name: "FK_hmoMonthlyList_HMO",
                        column: x => x.hmoid,
                        principalTable: "HMO",
                        principalColumn: "hmoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    insuranceid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    insurancetype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    hmoid = table.Column<int>(nullable: true),
                    planname = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    effectivedate = table.Column<DateTime>(type: "date", nullable: true),
                    hmonumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    employername = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    employeraddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    stateid = table.Column<int>(nullable: true),
                    employercountry = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    relationship = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.insuranceid);
                    table.ForeignKey(
                        name: "HMO_Insurance",
                        column: x => x.hmoid,
                        principalTable: "HMO",
                        principalColumn: "hmoid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Patient_Insurance",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "State_Insurance",
                        column: x => x.stateid,
                        principalTable: "State",
                        principalColumn: "stateid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssignedAsset",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staffid = table.Column<int>(nullable: true),
                    assetid = table.Column<int>(nullable: true),
                    approverid = table.Column<int>(nullable: true),
                    dateAssigned = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateReturned = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    providerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedAsset", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssignedAsset_Personnel2",
                        column: x => x.approverid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedAsset_Asset",
                        column: x => x.assetid,
                        principalTable: "Asset",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedAsset_AccountManager",
                        column: x => x.providerid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedAsset_Personnel1",
                        column: x => x.staffid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DispensingStore",
                columns: table => new
                {
                    dispensingstoreid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugid = table.Column<int>(nullable: true),
                    ReorderLevel = table.Column<int>(nullable: true),
                    Stockdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    manufacturedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    expirydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true),
                    description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispensingStore", x => x.dispensingstoreid);
                    table.ForeignKey(
                        name: "FK_DispensingStore_Drug",
                        column: x => x.drugid,
                        principalTable: "Drug",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_dispensing_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrugOrders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugID = table.Column<int>(nullable: true),
                    created_at = table.Column<int>(nullable: true),
                    AdminHandler = table.Column<int>(nullable: true),
                    isAdminApproved = table.Column<bool>(nullable: true),
                    AdminTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PharmacyHandler = table.Column<int>(nullable: true),
                    isPharmayHandled = table.Column<bool>(nullable: true),
                    PharmacyTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    OrderSupplierID = table.Column<int>(nullable: true),
                    isAdminHandled = table.Column<bool>(nullable: true),
                    AdminComment = table.Column<string>(nullable: true),
                    isPharmacyConcluded = table.Column<bool>(nullable: true),
                    RequisitionNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugOrders", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrugOrders_Personnel2",
                        column: x => x.AdminHandler,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DrugOrders_Drug",
                        column: x => x.drugID,
                        principalTable: "Drug",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DrugOrders_Supplier",
                        column: x => x.OrderSupplierID,
                        principalTable: "Supplier",
                        principalColumn: "supplierid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DrugOrders_Personnel",
                        column: x => x.PharmacyHandler,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "case_note",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complaints = table.Column<string>(type: "text", nullable: true),
                    HistoryOfPresentingComplaints = table.Column<string>(type: "text", nullable: true),
                    PastMedicalAndDrugHistory = table.Column<string>(type: "text", nullable: true),
                    FamilyAndSocialHistory = table.Column<string>(type: "text", nullable: true),
                    General = table.Column<string>(type: "text", nullable: true),
                    Cardiovascular = table.Column<string>(type: "text", nullable: true),
                    Respiratory = table.Column<string>(type: "text", nullable: true),
                    GastroIntestinal = table.Column<string>(type: "text", nullable: true),
                    CentralNervousSystem = table.Column<string>(type: "text", nullable: true),
                    MusculoSkeletal = table.Column<string>(type: "text", nullable: true),
                    Reproductive = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    utilizationID = table.Column<int>(nullable: true),
                    userID = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_case_note", x => x.ID);
                    table.ForeignKey(
                        name: "fk_casenote_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_case_note_user",
                        column: x => x.userID,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_case_note_utilization",
                        column: x => x.utilizationID,
                        principalTable: "utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "diagnosis_utilization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnosisID = table.Column<int>(nullable: false),
                    utilizationID = table.Column<int>(nullable: false),
                    visiType = table.Column<string>(nullable: true),
                    diagsequence = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosis_utilization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_diagnosis_utilization_diagnosis",
                        column: x => x.diagnosisID,
                        principalTable: "diagnosis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_diagnosis_utilization_utilization",
                        column: x => x.utilizationID,
                        principalTable: "utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "drug_dispense",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(nullable: true),
                    unit = table.Column<string>(nullable: true),
                    note = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    utilizationID = table.Column<int>(nullable: true),
                    userID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_dispense", x => x.ID);
                    table.ForeignKey(
                        name: "FK_drug_dispense_user",
                        column: x => x.userID,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_drug_dispense_utilization",
                        column: x => x.utilizationID,
                        principalTable: "utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admission_Diagnosis",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admissionid = table.Column<int>(nullable: true),
                    diagnosiscode = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    dateadded = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admission_Diagnosis", x => x.id);
                    table.ForeignKey(
                        name: "FK_Admission_Diagnosis_Admission",
                        column: x => x.admissionid,
                        principalTable: "Admission",
                        principalColumn: "admissionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillPayable",
                columns: table => new
                {
                    billpayableid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    billid = table.Column<int>(nullable: true),
                    billamount = table.Column<double>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    discount = table.Column<double>(nullable: true),
                    amountpaid = table.Column<double>(nullable: true),
                    amountinwords = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    balance = table.Column<double>(nullable: true),
                    trfno = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    staffid = table.Column<int>(nullable: true),
                    txndate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayable", x => x.billpayableid);
                    table.ForeignKey(
                        name: "FK_BillPayable_Bill",
                        column: x => x.billid,
                        principalTable: "Bill",
                        principalColumn: "billid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillPayable_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_billpayable_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillPayable_Personnel",
                        column: x => x.staffid,
                        principalTable: "Personnel",
                        principalColumn: "staffid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation_Laboratory",
                columns: table => new
                {
                    labkey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consultationid = table.Column<int>(nullable: true),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    patientorderid = table.Column<int>(nullable: true),
                    arrivaltime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    starttime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    endtime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    departuretime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    deptid = table.Column<int>(nullable: true),
                    patienttype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    labnotes = table.Column<string>(unicode: false, nullable: true),
                    isdocattached = table.Column<bool>(nullable: true),
                    docname = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    docpath = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    labdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    isexternal = table.Column<bool>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation_Laboratory", x => x.labkey);
                    table.ForeignKey(
                        name: "FK_Consultation_Laboratory_Department",
                        column: x => x.deptid,
                        principalTable: "Department",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Laboratory_Patient",
                        column: x => x.patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Laboratory_Patient_Order",
                        column: x => x.patientorderid,
                        principalTable: "Patient_Order",
                        principalColumn: "patientorderid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultationlab_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Order_Details",
                columns: table => new
                {
                    patientorderdetailsid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    patientorderid = table.Column<int>(nullable: true),
                    ordertypeid = table.Column<int>(nullable: true),
                    orderlistid = table.Column<int>(nullable: true),
                    orderstatusid = table.Column<int>(nullable: true),
                    result = table.Column<string>(unicode: false, nullable: true),
                    ordercomment = table.Column<string>(unicode: false, nullable: true),
                    raisedby = table.Column<int>(nullable: true),
                    completedby = table.Column<int>(nullable: true),
                    docpath = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    docimage = table.Column<byte[]>(type: "image", nullable: true),
                    orderdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ordercategoryid = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Order_Details", x => x.patientorderdetailsid);
                    table.ForeignKey(
                        name: "FK_Patient_Order_Details_Patient_Order",
                        column: x => x.patientorderid,
                        principalTable: "Patient_Order",
                        principalColumn: "patientorderid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "claims",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enrolleeid = table.Column<int>(nullable: true),
                    userid = table.Column<int>(nullable: true),
                    diagnosisID = table.Column<int>(nullable: true),
                    hmonumber = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    treatmentstartdate = table.Column<DateTime>(type: "date", nullable: true),
                    treatmentenddate = table.Column<DateTime>(type: "date", nullable: true),
                    amountbilled = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    diagnosiscode = table.Column<string>(nullable: true),
                    claimtype = table.Column<string>(nullable: true),
                    isClaimExported = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    syncid = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    flag = table.Column<string>(unicode: false, nullable: true),
                    issynced = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    synced_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PANumber = table.Column<string>(nullable: true),
                    patienttype = table.Column<string>(nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_claims_diagnosis_utilization",
                        column: x => x.diagnosisID,
                        principalTable: "diagnosis_utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_claims_enrollee",
                        column: x => x.enrolleeid,
                        principalTable: "enrollee",
                        principalColumn: "ID_e",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_claims_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_claims_user",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "ID_u",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consultation_utilization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnosisID = table.Column<int>(nullable: false),
                    consultationID = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    isclaimsgenerated = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultation_utilization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_consultation_utilization_diagnosis_utilization",
                        column: x => x.diagnosisID,
                        principalTable: "diagnosis_utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultationutilization_accountmanager",
                        column: x => x.ProviderID,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "drug_utilization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugID = table.Column<int>(nullable: true),
                    diagnosisID = table.Column<int>(nullable: false),
                    dose = table.Column<string>(unicode: false, nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    frequency = table.Column<string>(unicode: false, nullable: true),
                    duration = table.Column<string>(unicode: false, nullable: true),
                    deseunit = table.Column<string>(unicode: false, nullable: true),
                    cost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    paymenttype = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    isdispensed = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    isclaimsgenerated = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_utilization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_drug_utilization_diagnosis_utilization",
                        column: x => x.diagnosisID,
                        principalTable: "diagnosis_utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "procedure_utilization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisID = table.Column<int>(nullable: false),
                    ProcedureID = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    paymenttype = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    isclaimsgenerated = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedure_utilization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_procedure_utilization_diagnosis_utilization",
                        column: x => x.DiagnosisID,
                        principalTable: "diagnosis_utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procedure_utilization_procedure",
                        column: x => x.ProcedureID,
                        principalTable: "procedure",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transportation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    preauth = table.Column<string>(nullable: true),
                    isclaimsgenerated = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    diagnosisID = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transportation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_transportation_diagnosis_utilization",
                        column: x => x.diagnosisID,
                        principalTable: "diagnosis_utilization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accesscontrol_user_userID",
                table: "accesscontrol_user",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountManager_countryid",
                table: "AccountManager",
                column: "countryid");

            migrationBuilder.CreateIndex(
                name: "IX_AccountManager_stateid",
                table: "AccountManager",
                column: "stateid");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_bedid",
                table: "Admission",
                column: "bedid");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_deptid",
                table: "Admission",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_dischargedBy",
                table: "Admission",
                column: "dischargedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_patientid",
                table: "Admission",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_ProviderID",
                table: "Admission",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_staffid",
                table: "Admission",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_Diagnosis_admissionid",
                table: "Admission_Diagnosis",
                column: "admissionid");

            migrationBuilder.CreateIndex(
                name: "IX_Antenatal_Record_consultationid",
                table: "Antenatal_Record",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_locationid",
                table: "ApplicationUser",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_deptid",
                table: "Appointment",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_staffid",
                table: "Appointment",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_locationid",
                table: "AppointmentSchedule",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_patientNumber",
                table: "AppointmentSchedule",
                column: "patientNumber");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_provid",
                table: "AppointmentSchedule",
                column: "provid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_referralid",
                table: "AppointmentSchedule",
                column: "referralid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_referringid",
                table: "AppointmentSchedule",
                column: "referringid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_reminderid",
                table: "AppointmentSchedule",
                column: "reminderid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_specid",
                table: "AppointmentSchedule",
                column: "specid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_statusid",
                table: "AppointmentSchedule",
                column: "statusid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedule_visittypeid",
                table: "AppointmentSchedule",
                column: "visittypeid");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_IdentificationModeid",
                table: "AppUser",
                column: "IdentificationModeid");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_ProviderID",
                table: "AppUser",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_titleid",
                table: "AppUser",
                column: "titleid");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_locationid",
                table: "Asset",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_providerid",
                table: "Asset",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_supplierid",
                table: "Asset",
                column: "supplierid");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_typeid",
                table: "Asset",
                column: "typeid");

            migrationBuilder.CreateIndex(
                name: "IX_AssetType_providerid",
                table: "AssetType",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedAsset_approverid",
                table: "AssignedAsset",
                column: "approverid");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedAsset_assetid",
                table: "AssignedAsset",
                column: "assetid");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedAsset_providerid",
                table: "AssignedAsset",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedAsset_staffid",
                table: "AssignedAsset",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_audit_log_ProviderID",
                table: "audit_log",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_audit_log_userid",
                table: "audit_log",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Authorisation_hmoid",
                table: "Authorisation",
                column: "hmoid");

            migrationBuilder.CreateIndex(
                name: "IX_Bed_ProviderID",
                table: "Bed",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Bed_wardid",
                table: "Bed",
                column: "wardid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_accounttypeid",
                table: "Bill",
                column: "accounttypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_consultationid",
                table: "Bill",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_patientid",
                table: "Bill",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ProviderID",
                table: "Bill",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_staffid",
                table: "Bill",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_tariffid",
                table: "Bill",
                column: "tariffid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Detail_deptid",
                table: "Bill_Detail",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Detail_ProviderID",
                table: "Bill_Detail",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayable_billid",
                table: "BillPayable",
                column: "billid");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayable_patientid",
                table: "BillPayable",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayable_ProviderID",
                table: "BillPayable",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayable_staffid",
                table: "BillPayable",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_Biometric_patientid",
                table: "Biometric",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Biometric_ProviderID",
                table: "Biometric",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_BirthRegister_patientid",
                table: "BirthRegister",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_BirthRegister_ProviderID",
                table: "BirthRegister",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_BirthRegister_staffid",
                table: "BirthRegister",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_BreakBlockSchedule_locationid",
                table: "BreakBlockSchedule",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_BreakBlockSchedule_provid",
                table: "BreakBlockSchedule",
                column: "provid");

            migrationBuilder.CreateIndex(
                name: "IX_case_note_ProviderID",
                table: "case_note",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_case_note_userID",
                table: "case_note",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_case_note_utilizationID",
                table: "case_note",
                column: "utilizationID");

            migrationBuilder.CreateIndex(
                name: "IX_CentralStore_ProviderID",
                table: "CentralStore",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_Accountid",
                table: "CheckIn",
                column: "Accountid");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_Locationid",
                table: "CheckIn",
                column: "Locationid");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_Patientid",
                table: "CheckIn",
                column: "Patientid");

            migrationBuilder.CreateIndex(
                name: "IX_claims_diagnosisID",
                table: "claims",
                column: "diagnosisID");

            migrationBuilder.CreateIndex(
                name: "IX_claims_enrolleeid",
                table: "claims",
                column: "enrolleeid");

            migrationBuilder.CreateIndex(
                name: "IX_claims_ProviderID",
                table: "claims",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_claims_userid",
                table: "claims",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_ProviderID",
                table: "Consultation",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Check_consultationid",
                table: "Consultation_Check",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Check_patientid",
                table: "Consultation_Check",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Check_ProviderID",
                table: "Consultation_Check",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Complaints_consultationid",
                table: "Consultation_Complaints",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Complaints_patientid",
                table: "Consultation_Complaints",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Complaints_ProviderID",
                table: "Consultation_Complaints",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Dental_consultationid",
                table: "Consultation_Dental",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Dental_patientid",
                table: "Consultation_Dental",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Dental_ProviderID",
                table: "Consultation_Dental",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_DentalProcedure_consultationid",
                table: "Consultation_DentalProcedure",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_DentalProcedure_patientid",
                table: "Consultation_DentalProcedure",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_DentalProcedure_ProviderID",
                table: "Consultation_DentalProcedure",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Diagnosis_consultationid",
                table: "Consultation_Diagnosis",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Diagnosis_patientid",
                table: "Consultation_Diagnosis",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Diagnosis_ProviderID",
                table: "Consultation_Diagnosis",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Laboratory_deptid",
                table: "Consultation_Laboratory",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Laboratory_patientid",
                table: "Consultation_Laboratory",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Laboratory_patientorderid",
                table: "Consultation_Laboratory",
                column: "patientorderid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Laboratory_ProviderID",
                table: "Consultation_Laboratory",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_OtherDiagnosis_consultationid",
                table: "Consultation_OtherDiagnosis",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_OtherDiagnosis_patientid",
                table: "Consultation_OtherDiagnosis",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_OtherDiagnosis_ProviderID",
                table: "Consultation_OtherDiagnosis",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Prescription_consultationid",
                table: "Consultation_Prescription",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Prescription_patientid",
                table: "Consultation_Prescription",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Prescription_ProviderID",
                table: "Consultation_Prescription",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Problem_consultationid",
                table: "Consultation_Problem",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Problem_patientid",
                table: "Consultation_Problem",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Problem_ProviderID",
                table: "Consultation_Problem",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Procedure_consultationid",
                table: "Consultation_Procedure",
                column: "consultationid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Procedure_patientid",
                table: "Consultation_Procedure",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Procedure_ProviderID",
                table: "Consultation_Procedure",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Radiology_ProviderID",
                table: "Consultation_Radiology",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_consultation_utilization_diagnosisID",
                table: "consultation_utilization",
                column: "diagnosisID");

            migrationBuilder.CreateIndex(
                name: "IX_consultation_utilization_ProviderID",
                table: "consultation_utilization",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationCheckslist_CCLtypeid",
                table: "ConsultationCheckslist",
                column: "CCLtypeid");

            migrationBuilder.CreateIndex(
                name: "IX_CPTProcedure_cptcategoryid",
                table: "CPTProcedure",
                column: "cptcategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_CPTProcedure_cptsubcategoryid",
                table: "CPTProcedure",
                column: "cptsubcategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_CPTSubCategory_cptcategoryid",
                table: "CPTSubCategory",
                column: "cptcategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_data_synchronization_userid",
                table: "data_synchronization",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ProviderID",
                table: "Department",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_dependant_info_enrolleeid",
                table: "dependant_info",
                column: "enrolleeid");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_ProviderID",
                table: "diagnosis",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_utilization_diagnosisID",
                table: "diagnosis_utilization",
                column: "diagnosisID");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_utilization_utilizationID",
                table: "diagnosis_utilization",
                column: "utilizationID");

            migrationBuilder.CreateIndex(
                name: "IX_DispensingStore_drugid",
                table: "DispensingStore",
                column: "drugid");

            migrationBuilder.CreateIndex(
                name: "IX_DispensingStore_ProviderID",
                table: "DispensingStore",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_division_groupid",
                table: "division",
                column: "groupid");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_drugcategoryid",
                table: "Drug",
                column: "drugcategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_providerid",
                table: "Drug",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_supplierid",
                table: "Drug",
                column: "supplierid");

            migrationBuilder.CreateIndex(
                name: "IX_drug_dispense_userID",
                table: "drug_dispense",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_drug_dispense_utilizationID",
                table: "drug_dispense",
                column: "utilizationID");

            migrationBuilder.CreateIndex(
                name: "IX_drug_utilization_diagnosisID",
                table: "drug_utilization",
                column: "diagnosisID");

            migrationBuilder.CreateIndex(
                name: "IX_DrugOrders_AdminHandler",
                table: "DrugOrders",
                column: "AdminHandler");

            migrationBuilder.CreateIndex(
                name: "IX_DrugOrders_drugID",
                table: "DrugOrders",
                column: "drugID");

            migrationBuilder.CreateIndex(
                name: "IX_DrugOrders_OrderSupplierID",
                table: "DrugOrders",
                column: "OrderSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_DrugOrders_PharmacyHandler",
                table: "DrugOrders",
                column: "PharmacyHandler");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_divisionid",
                table: "enrollee",
                column: "divisionid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_enrolleetypeid",
                table: "enrollee",
                column: "enrolleetypeid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_groupid",
                table: "enrollee",
                column: "groupid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_networkid",
                table: "enrollee",
                column: "networkid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_plainid",
                table: "enrollee",
                column: "plainid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_providerid",
                table: "enrollee",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_userid",
                table: "enrollee",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_enrollee_type_ProviderID",
                table: "enrollee_type",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Fingerprint_patientid",
                table: "Fingerprint",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Fingerprint_ProviderID",
                table: "Fingerprint",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralSchedule_locationid",
                table: "GeneralSchedule",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_HMO_stateid",
                table: "HMO",
                column: "stateid");

            migrationBuilder.CreateIndex(
                name: "IX_HMO_typeid",
                table: "HMO",
                column: "typeid");

            migrationBuilder.CreateIndex(
                name: "IX_hmoMonthlyList_hmoid",
                table: "hmoMonthlyList",
                column: "hmoid");

            migrationBuilder.CreateIndex(
                name: "IX_HmoType_providerid",
                table: "HmoType",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_ICD10Diagnosis_icdcategoryid",
                table: "ICD10Diagnosis",
                column: "icdcategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_hmoid",
                table: "Insurance",
                column: "hmoid");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_patientid",
                table: "Insurance",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_stateid",
                table: "Insurance",
                column: "stateid");

            migrationBuilder.CreateIndex(
                name: "IX_LicenseManager_ProviderID",
                table: "LicenseManager",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Login_ProviderID",
                table: "Login",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProblemItem_medid",
                table: "MedicalProblemItem",
                column: "medid");

            migrationBuilder.CreateIndex(
                name: "IX_Messaging_ProviderID",
                table: "Messaging",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Messaging_recieverID",
                table: "Messaging",
                column: "recieverID");

            migrationBuilder.CreateIndex(
                name: "IX_Messaging_senderID",
                table: "Messaging",
                column: "senderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCategory_ordertypeid",
                table: "OrderCategory",
                column: "ordertypeid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderListing_ordercategoryid",
                table: "OrderListing",
                column: "ordercategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderListing_ordertypeid",
                table: "OrderListing",
                column: "ordertypeid");

            migrationBuilder.CreateIndex(
                name: "IX_PaRequest_AccountId",
                table: "PaRequest",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PaRequest_LocationId",
                table: "PaRequest",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PaRequest_PatientId",
                table: "PaRequest",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PaRequest_ProcedureId",
                table: "PaRequest",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_bloodgroupid",
                table: "Patient",
                column: "bloodgroupid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_cardtypeid",
                table: "Patient",
                column: "cardtypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_facilitatorid",
                table: "Patient",
                column: "facilitatorid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_genderid",
                table: "Patient",
                column: "genderid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_genotypeid",
                table: "Patient",
                column: "genotypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_leadid",
                table: "Patient",
                column: "leadid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_maritalstatusid",
                table: "Patient",
                column: "maritalstatusid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ProviderID",
                table: "Patient",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_refid",
                table: "Patient",
                column: "refid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_sponsid",
                table: "Patient",
                column: "sponsid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_stateid",
                table: "Patient",
                column: "stateid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedicalHistory_patientid",
                table: "Patient_MedicalHistory",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedicalHistory_problemid",
                table: "Patient_MedicalHistory",
                column: "problemid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedicalHistory_ProviderID",
                table: "Patient_MedicalHistory",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_completedby",
                table: "Patient_Order",
                column: "completedby");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_ordercategoryid",
                table: "Patient_Order",
                column: "ordercategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_orderlistid",
                table: "Patient_Order",
                column: "orderlistid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_orderstatusid",
                table: "Patient_Order",
                column: "orderstatusid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_ordertypeid",
                table: "Patient_Order",
                column: "ordertypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_patientid",
                table: "Patient_Order",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_ProviderID",
                table: "Patient_Order",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_raisedby",
                table: "Patient_Order",
                column: "raisedby");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Order_Details_patientorderid",
                table: "Patient_Order_Details",
                column: "patientorderid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Questionnaire_patientid",
                table: "Patient_Questionnaire",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Questionnaire_ProviderID",
                table: "Patient_Questionnaire",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Questionnaire_qcatid",
                table: "Patient_Questionnaire",
                column: "qcatid");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Questionnaire_qid",
                table: "Patient_Questionnaire",
                column: "qid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientQueue_AccountId",
                table: "PatientQueue",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientQueue_HospitalUnitId",
                table: "PatientQueue",
                column: "HospitalUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientQueue_LocationId",
                table: "PatientQueue",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientQueue_PatientId",
                table: "PatientQueue",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_deptid",
                table: "Personnel",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_designationid",
                table: "Personnel",
                column: "designationid");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_IdentificationModeid",
                table: "Personnel",
                column: "IdentificationModeid");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_ProviderID",
                table: "Personnel",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_titleid",
                table: "Personnel",
                column: "titleid");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_patientid",
                table: "Photo",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_procedure_ProviderID",
                table: "procedure",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_procedure_utilization_DiagnosisID",
                table: "procedure_utilization",
                column: "DiagnosisID");

            migrationBuilder.CreateIndex(
                name: "IX_procedure_utilization_ProcedureID",
                table: "procedure_utilization",
                column: "ProcedureID");

            migrationBuilder.CreateIndex(
                name: "IX_provider_change_enrolleeID",
                table: "provider_change",
                column: "enrolleeID");

            migrationBuilder.CreateIndex(
                name: "IX_provider_change_userid",
                table: "provider_change",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderSchedule_locationid",
                table: "ProviderSchedule",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderSchedule_provid",
                table: "ProviderSchedule",
                column: "provid");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderSchedule_specid",
                table: "ProviderSchedule",
                column: "specid");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaire_questioncategoryid",
                table: "Questionnaire",
                column: "questioncategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_benpackageid",
                table: "QueueManager",
                column: "benpackageid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_deptid",
                table: "QueueManager",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_fromPersonnelid",
                table: "QueueManager",
                column: "fromPersonnelid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_patientid",
                table: "QueueManager",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_ProviderID",
                table: "QueueManager",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_removedBy",
                table: "QueueManager",
                column: "removedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QueueManager_toPersonnelid",
                table: "QueueManager",
                column: "toPersonnelid");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingStore_ProviderID",
                table: "ReceivingStore",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_Material_patientid",
                table: "Reference_Material",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_Material_ProviderID",
                table: "Reference_Material",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_renewal_enrolleeid",
                table: "renewal",
                column: "enrolleeid");

            migrationBuilder.CreateIndex(
                name: "IX_renewal_userid",
                table: "renewal",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ProviderID",
                table: "Role",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_deptid",
                table: "Service",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ProviderID",
                table: "Service",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_servicetypeid",
                table: "Service",
                column: "servicetypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Tariff_ProviderID",
                table: "Service_Tariff",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Tariff_serviceid",
                table: "Service_Tariff",
                column: "serviceid");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Tariff_tariffid",
                table: "Service_Tariff",
                column: "tariffid");

            migrationBuilder.CreateIndex(
                name: "IX_Specialization_locationid",
                table: "Specialization",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializationSchedule_locationid",
                table: "SpecializationSchedule",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializationSchedule_specid",
                table: "SpecializationSchedule",
                column: "specid");

            migrationBuilder.CreateIndex(
                name: "IX_State_countryid",
                table: "State",
                column: "countryid");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_providerid",
                table: "Supplier",
                column: "providerid");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_suppliertypeid",
                table: "Supplier",
                column: "suppliertypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Tariff_ProviderID",
                table: "Tariff",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_transportation_diagnosisID",
                table: "transportation",
                column: "diagnosisID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Location_locationid",
                table: "User_Location",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_User_Location_userid",
                table: "User_Location",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_roleid",
                table: "User_Role",
                column: "roleid");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_userid",
                table: "User_Role",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_utilization_enrolleeid",
                table: "utilization",
                column: "enrolleeid");

            migrationBuilder.CreateIndex(
                name: "IX_utilization_referredFrom",
                table: "utilization",
                column: "referredFrom");

            migrationBuilder.CreateIndex(
                name: "IX_utilization_referredTo",
                table: "utilization",
                column: "referredTo");

            migrationBuilder.CreateIndex(
                name: "IX_utilization_userid",
                table: "utilization",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Verification_Log_patientid",
                table: "Verification_Log",
                column: "patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Verification_Log_ProviderID",
                table: "Verification_Log",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Verification_Log_userid",
                table: "Verification_Log",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accesscontrol_user");

            migrationBuilder.DropTable(
                name: "AccountCategory");

            migrationBuilder.DropTable(
                name: "Admission_Diagnosis");

            migrationBuilder.DropTable(
                name: "Antenatal_Record");

            migrationBuilder.DropTable(
                name: "app_setting");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "AppointmentSchedule");

            migrationBuilder.DropTable(
                name: "AssignedAsset");

            migrationBuilder.DropTable(
                name: "audit_log");

            migrationBuilder.DropTable(
                name: "Authorisation");

            migrationBuilder.DropTable(
                name: "Bill_Detail");

            migrationBuilder.DropTable(
                name: "BillPayable");

            migrationBuilder.DropTable(
                name: "Biometric");

            migrationBuilder.DropTable(
                name: "BirthRegister");

            migrationBuilder.DropTable(
                name: "BreakBlockSchedule");

            migrationBuilder.DropTable(
                name: "case_note");

            migrationBuilder.DropTable(
                name: "CentralStore");

            migrationBuilder.DropTable(
                name: "CheckIn");

            migrationBuilder.DropTable(
                name: "claims");

            migrationBuilder.DropTable(
                name: "Clinic");

            migrationBuilder.DropTable(
                name: "Consultation_Check");

            migrationBuilder.DropTable(
                name: "Consultation_Complaints");

            migrationBuilder.DropTable(
                name: "Consultation_Dental");

            migrationBuilder.DropTable(
                name: "Consultation_DentalProcedure");

            migrationBuilder.DropTable(
                name: "Consultation_Diagnosis");

            migrationBuilder.DropTable(
                name: "Consultation_Impression");

            migrationBuilder.DropTable(
                name: "Consultation_Laboratory");

            migrationBuilder.DropTable(
                name: "Consultation_OtherDiagnosis");

            migrationBuilder.DropTable(
                name: "Consultation_Prescription");

            migrationBuilder.DropTable(
                name: "Consultation_Problem");

            migrationBuilder.DropTable(
                name: "Consultation_Procedure");

            migrationBuilder.DropTable(
                name: "Consultation_Radiology");

            migrationBuilder.DropTable(
                name: "consultation_utilization");

            migrationBuilder.DropTable(
                name: "ConsultationCheckslist");

            migrationBuilder.DropTable(
                name: "CPTProcedure");

            migrationBuilder.DropTable(
                name: "data_synchronization");

            migrationBuilder.DropTable(
                name: "Dental_Procedure");

            migrationBuilder.DropTable(
                name: "dependant_info");

            migrationBuilder.DropTable(
                name: "DispensingStore");

            migrationBuilder.DropTable(
                name: "drug_dispense");

            migrationBuilder.DropTable(
                name: "drug_utilization");

            migrationBuilder.DropTable(
                name: "DrugOrders");

            migrationBuilder.DropTable(
                name: "DrugPricelist");

            migrationBuilder.DropTable(
                name: "DrugTherapeuticClass");

            migrationBuilder.DropTable(
                name: "Fingerprint");

            migrationBuilder.DropTable(
                name: "formdirect2");

            migrationBuilder.DropTable(
                name: "General_Examination");

            migrationBuilder.DropTable(
                name: "GeneralSchedule");

            migrationBuilder.DropTable(
                name: "hmoMonthlyList");

            migrationBuilder.DropTable(
                name: "hshhs");

            migrationBuilder.DropTable(
                name: "ICD10Diagnosis");

            migrationBuilder.DropTable(
                name: "id_generation");

            migrationBuilder.DropTable(
                name: "Injection_Taken");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "LicenseManager");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "MeasureUnit");

            migrationBuilder.DropTable(
                name: "Messaging");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "NextOfKinRelationship");

            migrationBuilder.DropTable(
                name: "Nursing_Record");

            migrationBuilder.DropTable(
                name: "PaRequest");

            migrationBuilder.DropTable(
                name: "Patient_MedicalHistory");

            migrationBuilder.DropTable(
                name: "Patient_Order_Details");

            migrationBuilder.DropTable(
                name: "Patient_Questionnaire");

            migrationBuilder.DropTable(
                name: "PatientQueue");

            migrationBuilder.DropTable(
                name: "PatientType");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Problem");

            migrationBuilder.DropTable(
                name: "procedure_utilization");

            migrationBuilder.DropTable(
                name: "ProcedurePricelist");

            migrationBuilder.DropTable(
                name: "provider_change");

            migrationBuilder.DropTable(
                name: "provider_network");

            migrationBuilder.DropTable(
                name: "ProviderSchedule");

            migrationBuilder.DropTable(
                name: "QueueManager");

            migrationBuilder.DropTable(
                name: "ReceivingStore");

            migrationBuilder.DropTable(
                name: "Reference_Material");

            migrationBuilder.DropTable(
                name: "renewal");

            migrationBuilder.DropTable(
                name: "Service_Tariff");

            migrationBuilder.DropTable(
                name: "SpecializationSchedule");

            migrationBuilder.DropTable(
                name: "temp");

            migrationBuilder.DropTable(
                name: "template_abdomen");

            migrationBuilder.DropTable(
                name: "template_activity");

            migrationBuilder.DropTable(
                name: "template_allergies");

            migrationBuilder.DropTable(
                name: "template_allreadyfordischarge");

            migrationBuilder.DropTable(
                name: "template_anthpropometry");

            migrationBuilder.DropTable(
                name: "template_antibiotics");

            migrationBuilder.DropTable(
                name: "template_arvdrugs");

            migrationBuilder.DropTable(
                name: "template_assesment");

            migrationBuilder.DropTable(
                name: "template_attitude");

            migrationBuilder.DropTable(
                name: "template_biodata");

            migrationBuilder.DropTable(
                name: "template_bloodgasanalysisform");

            migrationBuilder.DropTable(
                name: "template_bloodsugar");

            migrationBuilder.DropTable(
                name: "template_capturevitals");

            migrationBuilder.DropTable(
                name: "template_cathetercouldbepassedthrough");

            migrationBuilder.DropTable(
                name: "template_chromeform");

            migrationBuilder.DropTable(
                name: "template_chromiumform");

            migrationBuilder.DropTable(
                name: "template_clinicalnotes");

            migrationBuilder.DropTable(
                name: "template_colonoscopy");

            migrationBuilder.DropTable(
                name: "template_comment");

            migrationBuilder.DropTable(
                name: "template_consultantincharge");

            migrationBuilder.DropTable(
                name: "template_cotrimoxazole");

            migrationBuilder.DropTable(
                name: "template_dayodaysurgery");

            migrationBuilder.DropTable(
                name: "template_deliverydetails");

            migrationBuilder.DropTable(
                name: "template_detailsofresuscitation");

            migrationBuilder.DropTable(
                name: "template_diagnosisanddifferentials");

            migrationBuilder.DropTable(
                name: "template_dialysisprescription");

            migrationBuilder.DropTable(
                name: "template_dialysisvitaltest");

            migrationBuilder.DropTable(
                name: "template_diet");

            migrationBuilder.DropTable(
                name: "template_dietorder");

            migrationBuilder.DropTable(
                name: "template_dischargeplanning");

            migrationBuilder.DropTable(
                name: "template_expectedoutcomesofcare");

            migrationBuilder.DropTable(
                name: "template_firstexaminationatbirth");

            migrationBuilder.DropTable(
                name: "template_fluidfeeds");

            migrationBuilder.DropTable(
                name: "template_gastroscopy");

            migrationBuilder.DropTable(
                name: "template_generalapearances");

            migrationBuilder.DropTable(
                name: "template_homesupport");

            migrationBuilder.DropTable(
                name: "template_informationgiventopatientandcaregiver");

            migrationBuilder.DropTable(
                name: "template_informedofdischarge");

            migrationBuilder.DropTable(
                name: "template_inn");

            migrationBuilder.DropTable(
                name: "template_inpatientform");

            migrationBuilder.DropTable(
                name: "template_investigation");

            migrationBuilder.DropTable(
                name: "template_jaundice");

            migrationBuilder.DropTable(
                name: "template_laboratory");

            migrationBuilder.DropTable(
                name: "template_laboratory1");

            migrationBuilder.DropTable(
                name: "template_lastsawadoctoron");

            migrationBuilder.DropTable(
                name: "template_managementchangesinthelast24hrs");

            migrationBuilder.DropTable(
                name: "template_maternalrecords");

            migrationBuilder.DropTable(
                name: "template_medicalofficerandcarecoordinator");

            migrationBuilder.DropTable(
                name: "template_medicationanddressings");

            migrationBuilder.DropTable(
                name: "template_medicationandothertreatmentalreadygiven");

            migrationBuilder.DropTable(
                name: "template_medications");

            migrationBuilder.DropTable(
                name: "template_minivitals");

            migrationBuilder.DropTable(
                name: "template_mother");

            migrationBuilder.DropTable(
                name: "template_neuro");

            migrationBuilder.DropTable(
                name: "template_neurologic");

            migrationBuilder.DropTable(
                name: "template_neurologicexam");

            migrationBuilder.DropTable(
                name: "template_otherconcern");

            migrationBuilder.DropTable(
                name: "template_otherdetails");

            migrationBuilder.DropTable(
                name: "template_otherfluids");

            migrationBuilder.DropTable(
                name: "template_othermodification");

            migrationBuilder.DropTable(
                name: "template_outpatientappointmentmade");

            migrationBuilder.DropTable(
                name: "template_painassessmentscale");

            migrationBuilder.DropTable(
                name: "template_painassestmentscale");

            migrationBuilder.DropTable(
                name: "template_pastobstericform");

            migrationBuilder.DropTable(
                name: "template_pastobsterichistory");

            migrationBuilder.DropTable(
                name: "template_patientandcaregiver");

            migrationBuilder.DropTable(
                name: "template_patientdetail");

            migrationBuilder.DropTable(
                name: "template_patientdetails");

            migrationBuilder.DropTable(
                name: "template_patientinformation");

            migrationBuilder.DropTable(
                name: "template_physicalexamination");

            migrationBuilder.DropTable(
                name: "template_physicianincharge");

            migrationBuilder.DropTable(
                name: "template_plan");

            migrationBuilder.DropTable(
                name: "template_posttreatmentlabresult");

            migrationBuilder.DropTable(
                name: "template_presentingcomplaintsandhistoryofpresentillness");

            migrationBuilder.DropTable(
                name: "template_presentobsterichistory");

            migrationBuilder.DropTable(
                name: "template_primaryexaminationdetail");

            migrationBuilder.DropTable(
                name: "template_primaryexaminationdetails");

            migrationBuilder.DropTable(
                name: "template_psychological");

            migrationBuilder.DropTable(
                name: "template_result");

            migrationBuilder.DropTable(
                name: "template_resultinterpretation");

            migrationBuilder.DropTable(
                name: "template_resultsofpreviousinvestigationdone");

            migrationBuilder.DropTable(
                name: "template_sepsis");

            migrationBuilder.DropTable(
                name: "template_specimenrequired");

            migrationBuilder.DropTable(
                name: "template_surgeryform");

            migrationBuilder.DropTable(
                name: "template_teaching");

            migrationBuilder.DropTable(
                name: "template_testspecimen");

            migrationBuilder.DropTable(
                name: "template_tone");

            migrationBuilder.DropTable(
                name: "template_transportarrange");

            migrationBuilder.DropTable(
                name: "template_treatmentgiven");

            migrationBuilder.DropTable(
                name: "template_treatmentmanagementplan");

            migrationBuilder.DropTable(
                name: "template_typeofresuscitation");

            migrationBuilder.DropTable(
                name: "template_urinalysis");

            migrationBuilder.DropTable(
                name: "template_ventilation");

            migrationBuilder.DropTable(
                name: "template_vitals");

            migrationBuilder.DropTable(
                name: "TemplateCategory");

            migrationBuilder.DropTable(
                name: "TemplateMaster");

            migrationBuilder.DropTable(
                name: "transportation");

            migrationBuilder.DropTable(
                name: "User_Location");

            migrationBuilder.DropTable(
                name: "User_Role");

            migrationBuilder.DropTable(
                name: "Verification_Log");

            migrationBuilder.DropTable(
                name: "access_control");

            migrationBuilder.DropTable(
                name: "Admission");

            migrationBuilder.DropTable(
                name: "ReferringPhysician");

            migrationBuilder.DropTable(
                name: "Reminder");

            migrationBuilder.DropTable(
                name: "AppointmentStatus");

            migrationBuilder.DropTable(
                name: "VisitType");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "ConsultationChecks");

            migrationBuilder.DropTable(
                name: "CPTSubCategory");

            migrationBuilder.DropTable(
                name: "Drug");

            migrationBuilder.DropTable(
                name: "ICDCategory");

            migrationBuilder.DropTable(
                name: "HMO");

            migrationBuilder.DropTable(
                name: "MedicalProblemItem");

            migrationBuilder.DropTable(
                name: "Patient_Order");

            migrationBuilder.DropTable(
                name: "Questionnaire");

            migrationBuilder.DropTable(
                name: "HospitalUnit");

            migrationBuilder.DropTable(
                name: "procedure");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "BenefitPackage");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DropTable(
                name: "diagnosis_utilization");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Bed");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Consultation");

            migrationBuilder.DropTable(
                name: "Tariff");

            migrationBuilder.DropTable(
                name: "CPTCategory");

            migrationBuilder.DropTable(
                name: "DrugCategory");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "HmoType");

            migrationBuilder.DropTable(
                name: "MedicalProblemCategory");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "OrderListing");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "QuestionCategory");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "diagnosis");

            migrationBuilder.DropTable(
                name: "utilization");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "SupplierType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "IdentificationMode");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "OrderCategory");

            migrationBuilder.DropTable(
                name: "BloodGroup");

            migrationBuilder.DropTable(
                name: "HealthCareFacilitator");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "GenoType");

            migrationBuilder.DropTable(
                name: "LeadSource");

            migrationBuilder.DropTable(
                name: "maritalstatus");

            migrationBuilder.DropTable(
                name: "Referral");

            migrationBuilder.DropTable(
                name: "Sponsor");

            migrationBuilder.DropTable(
                name: "enrollee");

            migrationBuilder.DropTable(
                name: "provider");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropTable(
                name: "division");

            migrationBuilder.DropTable(
                name: "enrollee_type");

            migrationBuilder.DropTable(
                name: "network");

            migrationBuilder.DropTable(
                name: "plan");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "group");

            migrationBuilder.DropTable(
                name: "AccountManager");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
