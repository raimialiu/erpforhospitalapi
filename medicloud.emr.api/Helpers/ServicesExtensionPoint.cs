using medicloud.emr.api.DTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace medicloud.emr.api.Helpers
{
    public static class ServicesExtensionPoint
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HandleException>();
        }
    }
    public class HandleException
    {
        private RequestDelegate next;
      
        public HandleException(RequestDelegate _next)
        {
            next = _next;
            
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception es)
            {
                // var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                var trace = new StackTrace(es, true);
                var exceptionDetails = trace.GetFrames()
                                                .Select(x => new
                                                {
                                                    FileName = x.GetFileName(),
                                                    LineNumber = x.GetFileLineNumber(),
                                                    ColumnNUmber = x.GetFileColumnNumber(),
                                                    Method = x.GetMethod().ToString(),
                                                    Class = x.GetMethod().DeclaringType.FullName

                                                }).FirstOrDefault();

                context.Request.RouteValues.TryGetValue("controller", out var controllerName);
                string controllerMethodName = "";
                string currentControllerName = "";
                var endpoint = context.GetEndpoint();
                if (endpoint != null)
                {
                    var controllerActionDescriptor = endpoint.Metadata.GetMetadata<ControllerActionDescriptor>();
                    if (controllerActionDescriptor != null)
                    {
                        currentControllerName = controllerActionDescriptor.ControllerName;
                        controllerMethodName = controllerActionDescriptor.ActionName;
                    }
                }
                var messageObject = new
                {
                    occurAt = DateTime.Now.ToString(),
                    exceptionDetails = new
                    {
                        ErrorMessage = es.Message,
                        OriginatingClass = exceptionDetails.Class,
                        FileName = exceptionDetails.FileName,
                        LineNumber = exceptionDetails.LineNumber,
                        ColumnNumber = exceptionDetails.ColumnNUmber,
                        MethodThatThrowException = exceptionDetails.Method
                    },
                    RequestDetails = new
                    {
                        HttpMethod = context.Request.Method,
                        Path = context.Request.Path.ToString(),
                        ControllerMethodName = controllerMethodName,
                        ControllerName = currentControllerName
                    }

                };

                //if(!File.Exists("LogFiles.txt"))
                //{
                //   // File.Create("LogFiles.txt");
                //    //File.WriteAllText("LogFiles.txt", "\n");
                //    FileStream fs = new FileStream("LogFiles.txt", FileMode.CreateNew, FileAccess.ReadWrite);
                //    StreamWriter writer = new StreamWriter(fs);
                //    writer.WriteLine(JsonConvert.SerializeObject(messageObject));
                //    //File.WriteAllText("LogFiles.txt", JsonConvert.SerializeObject(messageObject));
                //    writer.Close();
                //    fs.Close();
                //}
                //else
                //{
                //   // FileStream fs = new FileStream("LogFiles.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                //    //StreamWriter writer = new StreamWriter(fs);
                //    //writer.WriteLine("\n");
                //    //writer.WriteLine(JsonConvert.SerializeObject(messageObject));
                //    //writer.Close();
                //    //File.AppendAllText("LogFiles.txt", "\n");
                //    File.AppendAllText("LogFiles.txt", "\n"+JsonConvert.SerializeObject(messageObject));
                //}
                
                // log Exception details

                await HandleExceptionAsync(context, es);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception es)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var response = BaseResponse.GetResponse(null, "something went wrong", "99");

            return context.Response.WriteAsync(response.ToString());
        }
    }
}
