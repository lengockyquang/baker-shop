﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace BakerShopApp.Interface
{
    public interface IGroupService
    {
        Task<ActionResult<object>> GetAll();
    }
}
