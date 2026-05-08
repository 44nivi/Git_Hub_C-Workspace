using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MVC_project_New.Controllers;
using System.Text;
using System.Threading.Tasks;

namespace MVC_project_New 
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware:IMiddleware
    {
         public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            string authHeader = context.Request.Headers["Authorization"];

            if (authHeader != null && authHeader.StartsWith("Basic "))
            {
                // Extract credentials from the Authorization header
                var encodedUsernamePassword = authHeader.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries)[1]?.Trim();
                var decodedUsernamePassword = Encoding.UTF8.GetString(Convert.FromBase64String(encodedUsernamePassword));
                var username = decodedUsernamePassword.Split(':', 2)[0];
                var password = decodedUsernamePassword.Split(':', 2)[1];

                // Authentication logic
                if (IsAuthenticated(username, password))
                {
                    await next(context);
                    return;
                }
            }

            // Return 401 Unauthorized if authentication fails
            context.Response.Headers["WWW-Authenticate"] = "Basic";
            context.Response.StatusCode = 401;
        }

        private bool IsAuthenticated(string username, string password)
        {
            // Example hardcoded authentication logic
            return username == "admin" && password == "password";
        }

    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    
}
