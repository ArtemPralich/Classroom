using Microsoft.AspNetCore.Identity;

namespace Classroom.Entities.Models
{
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
