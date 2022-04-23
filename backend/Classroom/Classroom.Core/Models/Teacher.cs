using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Classroom.Entities.Models
{
    [Table("Teacher")]
    public partial class Teacher : User
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }
        
        
        public short? Age { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
