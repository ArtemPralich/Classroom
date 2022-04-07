using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public short? Course { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
