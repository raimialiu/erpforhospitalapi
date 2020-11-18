﻿using medicloud.emr.api.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class BaseResponse
    {
        public object data { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string statusCode { get; set; }
        public BaseResponse(object data, string description, string statusCode)
        {
            this.data = data; this.description = description; 
            this.message = statusCode == "00" ? "success" :"failed";
            this.statusCode = statusCode;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static BaseResponse GetResponse(object data, string description, string statusCode)
                => new BaseResponse(data, description, statusCode);
    }

    public class Register
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public IFormFile Image { get; set; }
        public string ImageLocation { get; set; }

        public async Task UploadImage(IWebHostEnvironment environment)
        {
            string folder = Path.Combine(environment.WebRootPath, "images");
            string fileName = $"{Guid.NewGuid()}_{Image.FileName}";
            string fullPath = Path.Combine(folder, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await Image.CopyToAsync(stream);
            }

            ImageLocation = Path.Combine("images", fileName); ;
        }

        public bool ValidateExtension()
        {
            var validExtensions = new[] { "jpg", "png", "jpeg" };
            var extension = Image.FileName.Split('.')[^1].ToLowerInvariant();
            return validExtensions.Contains(extension);
        }
    }

    public class ErrorResponse
    {
        public string ErrorMessage { get; set; }
    }

    public class LoginResponse
    {
        private readonly IConfiguration _configuration;
        public LoginResponse(UserDTO dto, IConfiguration configuration)
        {
            _configuration = configuration;
            User = dto;
            Token = GenerateToken();
        }
        public string Token { get; private set; }
        public UserDTO User { get; private set; }

        private string GenerateToken()
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, User.Id.ToString()),
                new Claim(ClaimTypes.Name, User.Firstname),
            };

            var jwtSettings = _configuration.GetSection(nameof(JwtSettings))
                                        .Get<JwtSettings>();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddMinutes(20),
                SigningCredentials = credentials,
                Issuer = jwtSettings.Issuer,
                Audience = jwtSettings.Audience
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
