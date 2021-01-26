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
        public async Task<ActionResult<object>> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultToken = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return new ApiResponse("Username or password is incorrect.");
            }

            return new ApiResponse(success: true, results: new
            {
                Token = resultToken
            });
        }

        //[HttpGet("/api/check-login")]
        //[AllowAnonymous]
        //public async Task<IActionResult> CheckLogin([FromServices] ApiContext apiContext, [FromServices] IHttpUserAccessor accessor)
        //{
        //    await Task.CompletedTask;
        //    var identity = (ClaimsIdentity)HttpContext.User.Identity;
        //    var isLogined = identity.Claims.Count() > 0;
        //    var data = identity.Claims.Select(x => new { Name = x.Value, Type = x.Type });
        //    if (isLogined)
        //    {
        //        var user = accessor.GetUser();
        //        LogUserAccess(accessor.GetUserName().ToLower());
        //        return Ok(new
        //        {
        //            success = isLogined,
        //            data = GetUserData(accessor.GetUserName().ToLower(), apiContext, accessor, service),
        //        });
        //    }
        //    return Ok(new
        //    {
        //        success = isLogined
        //    });
        //}


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


        [HttpGet("check-login")]
        public ActionResult<object> CheckLogin()
        {
            var identity = User.Identity as ClaimsIdentity;

            if (identity != null && identity.Claims.Count() != 0)
            {
                IEnumerable<Claim> claims = identity.Claims;
                var userName = claims.Where(p => p.Type == ClaimTypes.NameIdentifier).FirstOrDefault()?.Value;
                var test = claims.ToList();


                return new ApiResponse(success: true, results: new
                {
                    data = userName
                });
            }

            return new ApiResponse("Bạn chưa đăng nhập!!");
        }
    }
}
