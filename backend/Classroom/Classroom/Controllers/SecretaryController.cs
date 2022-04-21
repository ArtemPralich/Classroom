using Classroom.Entities.Models;
using Classroom.Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretaryController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public SecretaryController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
    }
}
