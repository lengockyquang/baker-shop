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
    public class GroupController : Controller
    {
        private IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [Route("")]
        [HttpGet]
        public async Task<ActionResult<object>> Index()
        {
            return await _groupService.GetAll();
        }

        [Route("create")]
        [HttpPost]
        public async Task<ActionResult<object>> Create([FromBody] GroupForm form)
        {
            return await _groupService.Create(form);
        }


    }
}
