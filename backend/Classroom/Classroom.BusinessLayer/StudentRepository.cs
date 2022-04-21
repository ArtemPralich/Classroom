using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces;
using Classroom.DataLayer;
using Classroom.DataLayer.FilterExtensions;
using Classroom.Entities;
using Classroom.Entities.Models;
using Classroom.Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;

namespace Classroom.BusinessLayer
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ClassroomContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public PageList<Student> GetAllStudents(StudentParameters studentParameters)
        {
            var students = GetAll().Include(s => s.Group).SelectByGroup(studentParameters.Group).ToList();

            return PageList<Student>.ToPagedList(students, studentParameters.PageNumber,
                studentParameters.PageSize);
        }

        //public Student CreateStudent(Crea studentParameters)
        //{
        //    var students = GetAll().Include(s => s.Group).SelectByGroup(studentParameters.Group).ToList();

        //    return PageList<Student>.ToPagedList(students, studentParameters.PageNumber,
        //        studentParameters.PageSize);
        //}
    }
}
