using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public TeacherController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
    }
}
