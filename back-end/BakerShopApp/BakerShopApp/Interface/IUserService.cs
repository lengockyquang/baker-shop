using BakerShopApp.Forms;
using BakerShopApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerShopApp.Interface
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
