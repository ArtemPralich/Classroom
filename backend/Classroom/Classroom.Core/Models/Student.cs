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
            Tasks = new HashSet<Task>();
        }
        
        public short? Age { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
