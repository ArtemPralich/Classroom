using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Group : BaseEntity
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public override int Id { get; set; }
        public string Number { get; set; }
        public short? Course { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
