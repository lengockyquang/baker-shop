using Api.Base;
using BakerShopApp.Forms;
using BakerShopApp.Interface;
using BakerShopApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerShopApp.Services
{
    public class GroupService : IGroupService
    {
        private readonly ApiContext _context;
        public GroupService(ApiContext context)
        {
            _context = context;
        }
            
        public async Task<ActionResult<object>> GetAll()
        {
            //var data = await _context.Group.ToListAsync();
            //return new ApiResponse(data);
            return new ApiResponse();

        }

        public async Task<ActionResult<object>> Create(GroupForm form)
        {
            var model = new Group()
            {
                Name = form.Name
            };

            _context.Group.Add(model);

            await _context.SaveChangesAsync();
            return new ApiResponse(model);
        }
    }
}
