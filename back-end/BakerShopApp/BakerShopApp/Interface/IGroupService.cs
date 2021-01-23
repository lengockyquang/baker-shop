using BakerShopApp.Forms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerShopApp.Interface
{
    public interface IGroupService
    {
        Task<ActionResult<object>> GetAll();
        Task<ActionResult<object>> Create(GroupForm form);
    }
}
