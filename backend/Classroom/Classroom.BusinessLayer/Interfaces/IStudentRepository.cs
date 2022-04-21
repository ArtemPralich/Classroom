using Classroom.DataLayer;
using Classroom.Entities.Models;
using Classroom.Entities.RequestFeatures;

namespace Classroom.BusinessLayer.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        PageList<Student> GetAllStudents(StudentParameters studentParameters);
    }
}
