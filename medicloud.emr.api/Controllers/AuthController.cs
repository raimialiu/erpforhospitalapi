using System;
using System.Threading.Tasks;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository, IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
            _authRepository = authRepository;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser(LoginRequest model)
        {
            try
            {
                var user = await _authRepository.LoginUser(model.Username.Trim(), model.Password.Trim());
                if (user == null) return BadRequest(new ErrorResponse { ErrorMessage = "Invalid Username/Password" });

                return Ok(new LoginResponse(user, _configuration));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromForm] Register model) 
        {
            var isValidUsername = await _authRepository.UniqueUsername(model.Username.Trim());
            if (!isValidUsername) return BadRequest(new ErrorResponse { ErrorMessage = "Username has been taken" });

            if (model.Image != null)
            {
                bool isValidExtension = model.ValidateExtension();
                if (!isValidExtension) return BadRequest(new ErrorResponse { ErrorMessage = "Invalid File Format" });

                const int maxSize = 50000;
                if (model.Image.Length > maxSize) return BadRequest(new ErrorResponse { ErrorMessage = "Image exceeds the max size" });

                await model.UploadImage(_environment);
            }

            await _authRepository.RegisterUser(model);

            return NoContent();
        }  
    }
}
