using medicloud.emr.api.Data;
using medicloud.emr.api.DataContextRepo;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Helpers;
using medicloud.emr.api.Mocks;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Text;

namespace medicloud.emr.api
{
    public class Startup
    {
        readonly string corsPolicy = "CorsPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var jwtSettings = Configuration.GetSection(nameof(JwtSettings))
                                        .Get<JwtSettings>();

            var emailSettings = Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailSettings);

            services.AddControllers(setupActions =>
            {
                setupActions.ReturnHttpNotAcceptable = true;
                //setupAction
            })//.AddXmlDataContractSerializerFormatters()

            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.IgnoreNullValues = true;
                options.JsonSerializerOptions.WriteIndented = true;


                // .SerializerSettings.DefaultValueHandling = DefaultValueHandling.Include;
                //options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            }).AddNewtonsoftJson(c =>
            {
                c.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            });

            services.AddCors(options =>
            {
                options.AddPolicy(corsPolicy,
                                  builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

                //.WithOrigins(new[] { "http://localhost:4200", "http://test.medicloud.ng/lagoonhis", "http://localhost:58213",
                //                                      "https://hnlhisdev.azurewebsites.net",
                //                                      "http://localhost", "http://test.medicloud.ng/lagoonhisdev" })
                //.AllowAnyMethod().AllowAnyHeader()) ; ;
                // new[] { "GET", "POST", "PUT", "DELETE", "OPTIONS" }
                                                 
            });

          

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Medisamrts Emr Api",
                    Description = "API to serve data to the medismart emr UI",

                });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = jwtSettings.Audience,
                    ValidIssuer = jwtSettings.Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret))
                };
            });

            services.AddScoped<MockDataRepository>();
            services.AddTransient<IPatientRepo, PatientRepo>();
            services.AddScoped<ITitleRepo, TitleRepo>();
            services.AddTransient<IPatientServices, PatientService>();
            services.AddScoped<IBloodGroupRepo, BloodGroupRepo>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ICheckInRepository, CheckInRepository>();
            services.AddScoped<IPatientQueueRepository, PatientQueueRepository>();
            services.AddScoped<IPaRequestRepository, PaRequestRepository>();
            services.AddScoped<IHospitalUnitRepository, HospitalUnitRepository>();
            services.AddScoped<IPayerInsuranceRepository, PayerInsuranceRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<ISetupRepository, SetupRepository>();
            services.AddScoped<IOrderListingRepository, OrderListingRepository>();
            services.AddScoped<IConsultationDiagnosisRepository, ConsultationDiagnosisRepository>();

            services.AddScoped<IOrderInvestigationRepository, OrderInvestigationRepository>();
            services.AddScoped<IBillingRepository, BillingRepository>();
            services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();
            services.AddSingleton<IVitalRepo, VitalRepo>();
            services.AddScoped<ISoapRepository, SoapRepository>();
            services.AddScoped<IVitalSignsRepository, VitalSignsRepository>();
            services.AddScoped<IMRPRepository, MRPRepository>();

            const string connectionString = "lagoonDB";
            services.AddDbContext<DataContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString(connectionString), sqlServerOptionsAction: action =>
                        {
                            action.EnableRetryOnFailure();
                        }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(corsPolicy);
            app.UseStatusCodePages("text/plain", "HTTP Error with {0} Status Code");

          
            app.UseExceptionMiddleware();

            app.UseRouting();


            app.UseAuthentication();

            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Medismarts Emr");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
