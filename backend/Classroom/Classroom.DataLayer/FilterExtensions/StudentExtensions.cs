using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.Entities.Models;

namespace Classroom.DataLayer.FilterExtensions
{
    public static class StudentExtensions
    {
        public static IQueryable<Student> SelectByGroup(this IQueryable<Student> students, string GroupName)
        {
            if (string.IsNullOrWhiteSpace(GroupName))
                return students;
            return students.Where(s => s.Group.Number == GroupName);
        }
    }
}
