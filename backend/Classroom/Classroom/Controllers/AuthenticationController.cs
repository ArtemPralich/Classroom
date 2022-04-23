using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities;
using Classroom.Entities.Models;
using Classroom.Entities.Models.ModelsDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IAuthenticationManage _authenticationManage;

        public AuthenticationController(UserManager<User> userManager, IRepositoryManager repositoryManager, 
                                        RoleManager<IdentityRole> roleManager, IAuthenticationManage authenticationManage)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _repositoryManager = repositoryManager;
            _authenticationManage = authenticationManage;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserAuthenDto
            user)
        {
            if (!await _authenticationManage.ValidateUser(user))
            {
                return Unauthorized();
            }
            return Ok(new { Token = await _authenticationManage.CreateToken() });
        }

        [HttpGet, Authorize(Roles = "Student")]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetRoles(string role)
        {
            var isExists = await  _roleManager.RoleExistsAsync(role);
            return Ok(isExists);
        }

        [HttpPost("CreateRoles")]
        public async Task<IActionResult> CreateRoles()
        {
            var isExists = await _roleManager.CreateAsync(new IdentityRole(){ Name = "qwe"});
            return Ok(isExists);
        }


        [HttpPost]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterStudent([FromBody]StudentCreateDto studentDto)
        {
            var user = new Student()
            {
                UserName = studentDto.UserName, 
                Firstname = studentDto.Firstname,
                Lastname = studentDto.Lastname,
                Email = studentDto.Email,
                GroupId = studentDto.GroupId,
                PhoneNumber = studentDto.PhoneNumber,
                Age = studentDto.Age,

            };
            //_repositoryManager.Student.CreateStudent(user);
            var result = await _userManager.CreateAsync(user, studentDto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            else
            {
                var savedUser = await _userManager.FindByNameAsync(user.UserName);
                await _userManager.AddToRolesAsync(savedUser,  studentDto.Roles);
            }
            return StatusCode(201);
        }
    }
}
