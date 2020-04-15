using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.BusinessEntities;
using BusinessLayer.Services.ServiceContracts;


namespace WebApi.Controllers.Template
{
    public class ControllerTemplate<T,S> : ControllerBase
        where T : class
        where S : IDataService<T>
    {
        private S _service;
        public S service
        {
            get
            {
                if (_service == null)
                {
                    // determine type here
                    var type = typeof(S);

                    // create an object of the type
                    _service = (S)Activator.CreateInstance(type);
                    
                }
                   

                return _service;
            }
        }


        // POST: api/Payer
        [HttpPost]
        public IActionResult Update([FromBody] T value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = service.update(value);
                    return Accepted("Datbase Updated");
                }
                else
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message, StatusCode = 500 });
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int value)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (service.delete(value) != 200)
                    {
                        return new UnprocessableEntityResult();
                    }
                }
                else
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }
                return Ok("Data deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message, StatusCode = 500 });
            }
        }


        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = service.getAll();
                    return Ok(result);
                }
                else
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message, StatusCode = 500 });
            }

        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var result = service.get(id);
                    return Ok(result);
                }
                else
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message, StatusCode = 500 });
            }


        }


    }
}
