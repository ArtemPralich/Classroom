using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using Task = Classroom.Entities.Models.Task;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public TaskController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTasks(string id)
        {
            var tasks = _repositoryManager.Task.Get(g => g.StudentId == id).ToList();

            return tasks != null ? Ok(tasks) : Ok(null);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Classroom.Entities.Models.Task task)
        {
            var subj = _repositoryManager.Subject.Get(s => s.Id == task.SubjectId).SingleOrDefault();
            var students = _repositoryManager.Student.Get(s => s.GroupId == subj.GroupId).ToList();
            List<Classroom.Entities.Models.Task> tasks = new List<Task>();
            foreach (var student in students)
            {
                var t = new Classroom.Entities.Models.Task()
                {
                    SubjectId = task.SubjectId,
                    StudentId = student.Id,
                    Title = task.Title,
                    
                };
                tasks.Add(t);
            }
            _repositoryManager.Task.CreateRange(tasks);
            return Ok();
        }

        [HttpPut]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateTask([FromBody] Task task)
        {

            var tsk = _repositoryManager.Task.Get(t => t.Id == task.Id ).SingleOrDefault();
            tsk.Mark = task.Mark;
            _repositoryManager.Task.Update(tsk);
            return NoContent();
        }
    }
}
