using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IRepositoryManager _repositoryManager;
        private readonly UserManager<User> _userManager;
        public AttachmentController(IRepositoryManager repositoryManager, IWebHostEnvironment appEnvironment, UserManager<User> userManager )
        {
            _appEnvironment = appEnvironment;
            _repositoryManager = repositoryManager;
            _userManager = userManager;
        }
        [HttpGet("GetFile/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var attachment = _repositoryManager.Attachment.Get(a => a.Id == id).SingleOrDefault();
            string path = attachment.Path + attachment.Name;
            string fullPath = _appEnvironment.WebRootPath + path;
            var fileStream = System.IO.File.OpenRead(fullPath);
            return File(fileStream, "application/pdf");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var attachments = _repositoryManager.Attachment.Get(a => a.StudentId == id);
            return Ok(attachments);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [HttpGet, Authorize(Roles = "Student")]
        public async Task<IActionResult> AddFile()
        {
            IFormFile uploadedFile = Request.Form.Files.ToList().FirstOrDefault();
            int taaskId = 0;
            string usserId = "";
            if (Request.Headers.TryGetValue("taskId", out var taskId))
            {
                var q = taskId.ToArray();
                var w = q.LastOrDefault();
                taaskId = Convert.ToInt32(w.ToString());
            }
            if (Request.Headers.TryGetValue("userId", out var userId))
            {
                var q = userId.ToArray();
                var w = q.LastOrDefault();
                usserId = w.ToString();
            }

            if (uploadedFile != null)
            {
                string path = "\\Files\\" + uploadedFile.FileName;
                string fullPath = _appEnvironment.WebRootPath + path;
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
            }
            
            _repositoryManager.Attachment.Create(new Attachment() {Name = uploadedFile.FileName, Path = "/Files/", TaskId = taaskId, StudentId = userId });

            return Ok();
        }
        
        [HttpDelete("{id}"), Authorize(Roles = "Student")]
        public async Task<IActionResult> Delete(int id)
        {
            var attach = _repositoryManager.Attachment.Get(a => a.Id == id).SingleOrDefault();

            _repositoryManager.Attachment.Delete(attach);

            return Ok();
        }
    }

}
