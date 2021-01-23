using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Api.Base;
using BakerShopApp.Forms;
using BakerShopApp.Interface;
using BakerShopApp.Models;
using BakerShopApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models;

namespace BakerShopApp.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly ApiContext _context;
        private IConfiguration _configuration;
        private readonly IUserService _userService;


        public UserController(ApiContext context, IConfiguration configuration, IUserService userService)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;

        }

        private async Task<User> GetUser(string userName, string password)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.UserName == userName && password == password);
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultToken = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("Username or password is incorrect.");
            }
            return Ok(new { token = resultToken });
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request)
        {
            //P@ssword123
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Register(request);
            if (!result)
            {
                return BadRequest("Register is unsuccessful.");
            }
            return Ok();

        }
    }
}
