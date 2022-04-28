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
        public IActionResult GetStudents()
        {
            
            var students = _repositoryManager.Student.GetAllStudents(new StudentParameters());

            return Ok(students);
        }
        
        [HttpGet("{groupId}", Name = "GetBySubject")]
        public IActionResult GetBySubject(int groupId)
        {

            var students = _repositoryManager.Student.Get(s => s.GroupId == groupId);
            return Ok(students);
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
             _repositoryManager.Student.Update(student);
             return Ok(student);
        }
        [HttpDelete("{id}")]
        public IActionResult Update(string id)
        {
            var st = _repositoryManager.Student.Get(s => s.Id == id).FirstOrDefault();
            _repositoryManager.Student.Delete(st);
            return Ok();
        }
    }
}
