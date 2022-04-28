using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities.Models;
using Classroom.Entities.Models.ModelsDto;
using Classroom.Entities.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public GroupController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var groups = _repositoryManager.Group.GetAll();
            return Ok(groups);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GroupDto group)
        {
            var g = new Group() {Course = group.Course, Number = group.Number};
            _repositoryManager.Group.Create(g);
            return Ok();
        }

        [HttpDelete("{id}"), Authorize(Roles = "Secretary")]
        public async Task<IActionResult> Delete(int id)
        {
            var attach = _repositoryManager.Group.Get(a => a.Id == id).SingleOrDefault();

            _repositoryManager.Group.Delete(attach);

            return Ok();
        }
    }
}
