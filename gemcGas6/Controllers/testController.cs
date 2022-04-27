﻿using Microsoft.AspNetCore.Mvc;
using gemcGas.Models;

namespace gemcGas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class testController : ControllerBase
    {
        // GET
        [HttpGet()]
        public ActionResult<test> Get()
        {
            var result = new test
            {
                message = "good"
            };
            return result;
        }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class test2Controller : ControllerBase
    {
        // GET
        [HttpGet()]
        public ActionResult<test> Get()
        {
            var result = new test
            {
                message = "test2"
            };
            return result;
        }
    }
}