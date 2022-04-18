using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces;
using Classroom.Entities;

namespace Classroom.BusinessLayer.Common
{
    public class RepositoryManager
    {
        private IAttachmentRepository _attachmentRepository;
        private IGroupRepository _groupRepository;
        private ISecretaryRepository _secretaryRepository;
        private IStudentRepository _studentRepository;
        private ITaskRepository _taskRepository;
        private ITeacherRepository _teacherRepository;

        private readonly ClassroomContext _classroomContext;

        public RepositoryManager(ClassroomContext repositoryContext)
        {
            _classroomContext = repositoryContext;
        }
        public IAttachmentRepository Attachment
        {
            get
            {
                return _attachmentRepository ?? new AttachmentRepository(_classroomContext);
            }
        }
        public IGroupRepository Group
        {
            get
            {
                return _groupRepository ?? new GroupRepository(_classroomContext);
            }
        }
        public ISecretaryRepository Secretary
        {
            get
            {
                return _secretaryRepository ?? new SecretaryRepository(_classroomContext);
            }
        }
        public IStudentRepository Student
        {
            get
            {
                return _studentRepository ?? new StudentRepository(_classroomContext);
            }
        }
        public ITaskRepository Task
        {
            get
            {
                return _taskRepository ?? new TaskRepository(_classroomContext);
            }
        }
        public ITeacherRepository Teacher
        {
            get
            {
                return _teacherRepository ?? new TeacherRepository(_classroomContext);
            }
        }
    }
}
