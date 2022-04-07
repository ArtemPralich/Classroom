using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Task
    {
        public Task()
        {
            Attachments = new HashSet<Attachment>();
        }

        public int Id { get; set; }
        public short? Mark { get; set; }
        public short? Progress { get; set; }
        public int SubjectId { get; set; }
        public short? Type { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
