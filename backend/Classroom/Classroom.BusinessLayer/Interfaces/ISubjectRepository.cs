using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.DataLayer;
using Classroom.Entities.Models;

namespace Classroom.BusinessLayer.Interfaces
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        Subject GetSubjectById(int id);
    }
}
