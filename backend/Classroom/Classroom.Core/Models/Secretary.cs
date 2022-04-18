#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Secretary : BaseEntity
    {
        public override int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
