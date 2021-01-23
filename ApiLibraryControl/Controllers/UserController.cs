using ApiLibraryControl.Library.DataAccess;
using ApiLibraryControl.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserData _data;

        public UserController(IUserData data)
        {
            _data = data;
        }

        [Route("AddUser")]
        [HttpPost]
        public void AddUser(UserModel model)
        {
            //dbcontext cośtam takiego
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Xd = User.FindFirstValue(ClaimTypes.Name);
           // _data.AddUser(model);
        }

        [Route("hello")]
        [HttpGet]
        public void Test()
        {
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Xd = User.FindFirstValue(ClaimTypes.Name);
            var Ud = User.FindFirstValue(ClaimTypes.Email);
            string xd = $"{Id}";
        }


        [Route("GetUserById/{id}")]
        [HttpGet]
        public UserModel GetUserById(string id)
        {
            var output = _data.GetUserById(id);
            return output;
        }
    }
}
