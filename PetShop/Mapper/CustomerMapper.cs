using PetShop.Entities;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Mapper
{
    public static class CustomerMapper
    {
        public static Customer ToUser(AuthenticationRequest request)
        {
            return new Customer
            {
                Email = request.Email,
                Password = request.Password
            };
        }

        public static Customer ToUserExtension(this AuthenticationRequest request)
        {
            return new Customer
            {
                Email = request.Email,
                Password = request.Password
            };
        }
    }
}
