using Api.Base;
using BakerShopApp.Interface;
using BakerShopApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

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
            var data = await _context.Groups.ToListAsync();
            return new ApiResponse(data);
        }
    }
}
