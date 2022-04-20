using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Classroom.Entities.Models
{
    [Table("Student")]
    public partial class Student : User
    {
        public Student()
        {
            Attachments = new HashSet<Attachment>();
        }

        public override string Id { get; set; }
        public short? Age { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
