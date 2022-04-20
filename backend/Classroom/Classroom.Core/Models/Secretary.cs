using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Classroom.Entities.Models
{
    [Table("Secretary")]
    public partial class Secretary : User
    {
        public override string Id { get; set; }
    }
}
