using AuditBenchmarkModule.Models;
using AuditBenchmarkModule.Provider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AuditBenchmarkModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {
        private readonly IBenchmarkProvider objProvider;
        public AuditBenchmarkController(IBenchmarkProvider _objProvider)
        {
            objProvider = _objProvider;
        }
        [HttpGet]
        public IActionResult AuditBenchmark()
        {
            List<AuditBenchmark> listOfProvider = new List<AuditBenchmark>();            
            try
            {
                listOfProvider = objProvider.GetBenchmark();
                return Ok(listOfProvider);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
