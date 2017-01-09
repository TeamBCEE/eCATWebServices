using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breeze.WebApi2;
using Ecat.LogicLib.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecat.WebApp.Controllers
{
    [Route("breeze/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpGet]
        public string Metadata()
        {
            return _userLogic.Metadata;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
