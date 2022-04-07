using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Student
    {
        public Student()
        {
            Attachments = new HashSet<Attachment>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public short? Age { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
