using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Client.HelpEntities.ParseEntities
{
    public class Task
    {
        public int? Id { get; set; }
        public short? Mark { get; set; }
        public string Title { get; set; }
        public short? Progress { get; set; }
        public int SubjectId { get; set; }
        public short? Type { get; set; }
    }
}
