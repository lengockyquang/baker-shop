using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakerShopApp.Forms;
using BakerShopApp.Interface;
using BakerShopApp.Services;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using static BakerShopApp.Interface.SomeInterfaces;

namespace BakerShopApp.Controllers
{
    [ApiController]
    [Route("api/group")]
    public class UserController : Controller
    {
        private readonly ApiContext _context;

        public UserController(ApiContext context)
        {
            _context = context;

        }


        [Route("create")]
        [HttpPost]
        public async Task<ActionResult<object>> CheckAuthen([FromBody] UserForm form)
        {
            if (form != null && form.UserName != null && form.Password != null)
            {

            }
            throw new NotImplementedException();

        }


    }
}
