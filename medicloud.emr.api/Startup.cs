using System.IO;
using System.Text;
using medicloud.emr.api.Data;
using medicloud.emr.api.DataContextRepo;
using medicloud.emr.api.Helpers;
using medicloud.emr.api.Mocks;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

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
        private SwaggerSettings swaggerSettings;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("lagoonDB");
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connection, x => x.MigrationsAssembly("medicloud.emr.api")));

            var jwtSettings = Configuration.GetSection(nameof(JwtSettings))
                                        .Get<JwtSettings>();

            services.AddControllers(setupActions =>
            {
                setupActions.ReturnHttpNotAcceptable = true;
            })//.AddXmlDataContractSerializerFormatters()
            //.AddNewtonsoftJson();
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.IgnoreNullValues = true;
                options.JsonSerializerOptions.WriteIndented = true;

                // .SerializerSettings.DefaultValueHandling = DefaultValueHandling.Include;
                //options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });

            services.AddCors(options =>
            {
                options.AddPolicy(corsPolicy, 
                                  builder => builder.WithOrigins(new[] { "http://localhost:4200", "http://test.medicloud.ng/lagoonhis" })
                                                    .WithMethods(new[] { "GET", "POST", "PUT", "DELETE", "OPTIONS" }).AllowAnyHeader());
            });

            swaggerSettings = new SwaggerSettings();

            Configuration.Bind(nameof(SwaggerSettings), swaggerSettings);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "medicloud.emr.api",
                    Description = "Medi-cloud EMR documented api ",
                    //TermsOfService = "None",
                    //Contact = new Contact() {  }
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
            services.AddSingleton<IPatientRepo, PatientRepo>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ICheckInRepository, CheckInRepository>();
            services.AddScoped<IPatientQueueRepository, PatientQueueRepository>();
            services.AddScoped<IPaRequestRepository, PaRequestRepository>();
            services.AddScoped<IHospitalUnitRepository, HospitalUnitRepository>();

 
            const string connectionString = "lagoonDB";
            services.AddDbContext<DataContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString(connectionString)));

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

            app.UseStaticFiles();
            //app.UseExceptionMiddleware();

            

            app.UseRouting();

            

            //app.UseSwagger(c =>
            //{
            //    c.RouteTemplate = swaggerSettings.RouteTemplate;
            //});

            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint(swaggerSettings.RouteEndpoint, swaggerSettings.Title);
            //});
            app.UseAuthentication();
            
            app.UseAuthorization();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Medi-Cloud EMR");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
