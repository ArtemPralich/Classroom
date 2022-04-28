using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities.Models;
using Classroom.Entities.Models.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public SubjectController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubject(string id)
        {
            var subjects = _repositoryManager.Subject.Get(g => g.TeacherId == id).ToList();

            return subjects != null ? Ok(subjects) : Ok(null);
        }

        [HttpPost]
        public IActionResult CreateSubject(SubjectDto subjectDto)
        {
            var subject = new Subject()
            {
                TeacherId = subjectDto.TeacherId,
                Year = subjectDto.Year,
                Title = subjectDto.Title,
                GroupId = subjectDto.GroupId
            };
            _repositoryManager.Subject.Create(subject);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSubject(int id)
        {
            var subject = _repositoryManager.Subject.GetSubjectById(id);
            _repositoryManager.Subject.Delete(subject);
            return Ok();
        }
    }
}
