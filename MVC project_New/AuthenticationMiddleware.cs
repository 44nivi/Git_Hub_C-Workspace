using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVC_project_New
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                string token = context.Request.Headers["Authorization"];

                // Validate the token (This is a simplified example, in a real scenario, you'd validate the token against a token issuer)
                if (IsValidToken(token))
                {
                    // If the token is valid, create claims for the authenticated user
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Name, "John Doe"),
                        new Claim(ClaimTypes.Email, "john.doe@example.com"),
                        new Claim(ClaimTypes.Role, "Admin") // Example role
                    };

                    // Create an identity for the user
                    var identity = new ClaimsIdentity(claims, "custom");

                    // Set the current principal to the authenticated user
                    context.User = new ClaimsPrincipal(identity);
                }
            }

            return _next(context);
        }

        private bool IsValidToken(string token)
        {
            // In a real scenario, you'd validate the token against a token issuer
            return token.Equals("valid_token");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}
