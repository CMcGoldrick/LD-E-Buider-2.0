using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Middleware
{
    [Authorize]
    public class WebRequestMiddleware
    {
        private readonly RequestDelegate _next;
        public System.Security.Principal.IPrincipal User { get; set; }

        public WebRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                var show = httpContext;
                var b = User;
                //bool isAuthenticated = Users.Identity.IsAuthenticated;

                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await _next(httpContext);
                throw;
            }
        }

        //public void AnalyzeUserBrowser(HttpContext httpContext)
        //{
        //    var uaString = httpContext.Request.Headers["User-Agent"].ToString();

        //    // get a parser with the embedded regex patterns
        //    var uaParser = Parser.GetDefault();

        //    ClientInfo client = uaParser.Parse(uaString);
        //    var browser = client.UA.Family;

        //    //potentially add other browsers like linx, opera, konkur
        //    if (browser == "IE")
        //    {
        //        httpContext.Request.Path = "/unsupported-browser";
        //    }
        //}
    }
}
