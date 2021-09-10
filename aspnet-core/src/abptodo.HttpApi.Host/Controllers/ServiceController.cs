using abptodo.Emailing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abptodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ServiceController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;
        public ServiceController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public ActionResult SendEmail([FromBody] string message)
        { 
            return Ok();
        }
    }
}
