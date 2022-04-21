using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities.Models;
using Classroom.Entities.RequestFeatures;
using Microsoft.AspNetCore.Identity;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public StudentController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public IActionResult GetStudents([FromQuery] StudentParameters studentParameters)
        {
            var students = _repositoryManager.Student.GetAllStudents(studentParameters);

            return Ok(students);
        }
    }
}
