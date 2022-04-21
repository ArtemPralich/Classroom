using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Entities.Models.ModelsDto
{
    public class SubjectDto
    {
        public string Title { get; set; }
        public string TeacherId { get; set; }
        public short? Year { get; set; }
    }
}
