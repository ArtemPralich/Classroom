using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.Entities.Models;

namespace Classroom.BusinessLayer.Interfaces
{
    public interface IStudentRepository
    {
        void CreateStudent(Student student);
    }
}
