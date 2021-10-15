using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMainBusinessLayer mainBL;
        public OrdersController(IMainBusinessLayer mainBL)
        {
            this.mainBL = mainBL;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var results = this.mainBL.FetchCustomers();
            return Ok(results);
        }
    }
}
