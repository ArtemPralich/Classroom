using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Teacher : BaseEntity
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }

        public override int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public short? Age { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
