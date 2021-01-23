using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakerShopApp.Forms;
using BakerShopApp.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakerShopApp.Controllers
{
    [Route("api/group")]
    [ApiController]
    [Authorize]
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
