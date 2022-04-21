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
        [HttpPost]
        public IActionResult CreateSubject(SubjectDto subjectDto)
        {
            var subject = new Subject()
            {
                TeacherId = subjectDto.TeacherId,
                Year = subjectDto.Year,
                Title = subjectDto.Title
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
