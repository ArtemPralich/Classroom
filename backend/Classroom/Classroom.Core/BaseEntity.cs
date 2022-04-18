using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }
    }
}
