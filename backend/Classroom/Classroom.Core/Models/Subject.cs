using System.Collections.Generic;

#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Subject : BaseEntity
    {
        public Subject()
        {
            Tasks = new HashSet<Task>();
        }

        public override int Id { get; set; }
        public string Title { get; set; }
        public string TeacherId { get; set; }
        public int GroupId { get; set; }
        public short? Year { get; set; }

        public virtual Group Group { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
