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
    public class TaskController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public TaskController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
    }
}
