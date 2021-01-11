using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakerShopApp.Services;
using Microsoft.AspNetCore.Mvc;
using static BakerShopApp.Interface.SomeInterfaces;

namespace BakerShopApp.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        private IProductService _productService;

        ITransientService _transientService1;
        ITransientService _transientService2;

        IScopedService _scopedService1;
        IScopedService _scopedService2;

        ISingletonService _singletonService1;
        ISingletonService _singletonService2;


        public HomeController(IProductService productService,
                          ITransientService transientService1,
                          ITransientService transientService2,
                           IScopedService scopedService1,
                            IScopedService scopedService2,
                            ISingletonService singletonService1,
                            ISingletonService singletonService2
            )
        {
            _productService = productService;

            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

        }

        //[Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            var data = _productService.getAll();

            return Ok(new
            {
                success = true,
                data
            });
        }

        [Route("test")]
        [HttpGet]
        public IActionResult Test()
        {
            var dataTransient1 = _transientService1.GetID();
            var dataTransient2 = _transientService2.GetID();

            var dataScope1 = _scopedService1.GetID();
            var dataScope2 = _scopedService2.GetID();

            var dataSingleton1 = _singletonService1.GetID();
            var dataSingleton2 = _singletonService2.GetID();


            return Ok(new
            {
                success = true,
                dataTransient1,
                dataTransient2,

                dataScope1,
                dataScope2,

                dataSingleton1,
                dataSingleton2,
            });
        }

    }
}
