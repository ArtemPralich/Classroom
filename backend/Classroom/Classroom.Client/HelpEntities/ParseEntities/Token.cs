using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Client.HelpEntities.ParseEntities
{
    public class Token
    {
        public string token { get; set; }
        public string role { get; set; }
        public user user { get; set; }
    }

    public class user
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public string Id { get; set; }
    }
}
