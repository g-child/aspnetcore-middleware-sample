using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KNK.aspnetcore_middleware_sample.Models;
using Microsoft.AspNetCore.Http;

namespace KNK.aspnetcore_middleware_sample.Middleware
{
    public class ApplicationUserMiddleware
    {
        private readonly RequestDelegate _next;

        public ApplicationUserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationUser applicationUser)
        {
            // Get User Information from `context.User`.
            // In this code, set dummy value like this.
            applicationUser.Id = Guid.NewGuid().ToString("N");
            applicationUser.Name = "John Du";
            applicationUser.Groups = new List<string> { "group-1", "group-2", "group-3" };

            await _next.Invoke(context);
        }
    }
}
