using Microsoft.AspNetCore.Http;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Models;
using Microsoft.Extensions.Options;
using PetShop.IServices;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace PetShop.Helpers
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Models.AppSettings _appSettings;


        public JwtMiddleware(RequestDelegate del, IOptions<Models.AppSettings> options)
        {
            _next = del;
            _appSettings = options.Value;
        }

        public async Task Invoke(HttpContext context, ICustomerService customerService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                AttachUserToContextByToken(context, customerService, token);

            await _next(context);
        }

        private void AttachUserToContextByToken(HttpContext context, ICustomerService customerService, string token)
        {
            try
            {
                var key = Encoding.ASCII.GetBytes("abcdefsjfhgjdkskdslskld");
                var tokenHandler = new JwtSecurityTokenHandler();
                tokenHandler.ValidateToken(token, new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                }, out SecurityToken securityToken);

                var jwtToken = (JwtSecurityToken)securityToken;
                var customerId = int.Parse(jwtToken.Claims.FirstOrDefault(x => x.Type == "id").Value);

                context.Items["Customer"] = customerService.GetById(customerId);

            }
            catch (Exception ex)
            {

            }
        }

    }
}
