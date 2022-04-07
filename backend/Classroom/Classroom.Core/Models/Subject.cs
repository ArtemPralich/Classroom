using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int TeacherId { get; set; }
        public short? Year { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
