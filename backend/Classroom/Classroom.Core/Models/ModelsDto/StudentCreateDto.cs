using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Entities.Models.ModelsDto
{
    public class StudentCreateDto
    {
        public short? Age { get; set; }
        public int? GroupId { get; set; }
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<string> Roles { get; set; }
        public string Password { get; set; }
    }
}
