using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Entities.RequestFeatures
{
    public class StudentParameters : RequestParameters
    {
        public StudentParameters()
        {
            OrderBy = "GroupId";
        }

        public string Group { get; set; } = "";
        public string SearchTerm { get; set; }
    }
}
