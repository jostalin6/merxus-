using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatterPillerDevelopement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet("Ping")]
        public ActionResult<string> HealthCheck()
        {
            return "Pong";
        }


        [HttpPost("value")]
        public string Post(string value)
        {
            
            if (value.ToUpper() == "PING")
                return "Pong";

            return "Your request cannot proccessed!";
        }


    }
}