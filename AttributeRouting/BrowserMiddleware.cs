using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AttributeRouting
{
    public class BrowserMiddleware
    {
        private readonly RequestDelegate _next;

        public BrowserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var userAgent = context.Request.Headers["User-Agent"].ToString();
            if (userAgent.Contains("Postman"))
            {
                await _next(context);
            }
            else
            {
                await context.Response.WriteAsync("Error");
            }
        }
    }
}