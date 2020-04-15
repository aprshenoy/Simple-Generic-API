using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.BusinessEntities;

namespace WebApi.Controllers.Settings
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PayerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Update([FromBody] Caregiver value)
        {
            throw new NotImplementedException();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
