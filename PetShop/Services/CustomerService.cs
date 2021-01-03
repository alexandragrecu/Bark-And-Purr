using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PetShop.Entities;
using PetShop.IRepositories;
using PetShop.IServices;
using PetShop.Mapper;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public CustomerService(ICustomerRepository userRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = userRepository;
            this._appSettings = options.Value;
        }

        public bool Register(AuthenticationRequest request)
        {
            var entity = CustomerMapper.ToUserExtension(request);

            _repository.Add(entity);
            return _repository.SaveChanges();
        }

        public AuthenticationResponse Login(AuthenticationRequest request)
        {
            // find user
            var user = _repository.GetByEmailAndPassword(request.Email, request.Password);
            if (user == null)
                return null;

            // attach token
            var token = GenerateJwtForUser(user);

            // return user & token
            return new AuthenticationResponse
            {
                Id = user.Id,
                Email = user.Email,
                Type = user.Type,
                Token = token
            };
        }

        private string GenerateJwtForUser(Customer user)
        {

            // var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
           var key = Encoding.ASCII.GetBytes("abcdefsjfhgjdkskdslskld");

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public bool Delete(int id)
        {
            var customer = this.GetById(id);
            _repository.Delete(customer);
            return _repository.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Customer customer)
        {
            _repository.Add(customer);
            return _repository.SaveChanges();
        }

        public bool Update(Customer customer)
        {
            _repository.Update(customer);
            return _repository.SaveChanges();
        }
    }
}
