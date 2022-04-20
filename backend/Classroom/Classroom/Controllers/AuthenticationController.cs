using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Common;
using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _repositoryManager;
        public AuthenticationController(UserManager<User> userManager, IRepositoryManager repositoryManager)
        {
            _userManager = userManager;
            _repositoryManager = repositoryManager;
        }
        [HttpPost]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser()
        {
            var user = new Student()
            {
                UserName = "qweqwe", Firstname = "qweqwe", Lastname = "asdasd", Email = "rerererer@mail.ru", Id = Guid.NewGuid().ToString(),
                PhoneNumber = "23232232"
            };
            //_repositoryManager.Student.CreateStudent(user);
            var result = await _userManager.CreateAsync(user, "11password");
            //if (!result.Succeeded)
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.TryAddModelError(error.Code, error.Description);
            //    }
            //    return BadRequest(ModelState);
            //}
            return StatusCode(201);
        }

    }
}
