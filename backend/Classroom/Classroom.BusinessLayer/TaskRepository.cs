using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces;
using Classroom.DataLayer;
using Classroom.Entities;
using Task = Classroom.Entities.Models.Task;

namespace Classroom.BusinessLayer
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        public TaskRepository(ClassroomContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
