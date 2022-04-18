using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.DataLayer;
using Classroom.Entities;
using Classroom.Entities.Models;

namespace Classroom.BusinessLayer
{
    public class AttachmentRepository : Repository<Attachment>
    {
        public AttachmentRepository(ClassroomContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
