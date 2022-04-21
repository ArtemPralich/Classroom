using System.Linq;
using Classroom.BusinessLayer.Interfaces;
using Classroom.DataLayer;
using Classroom.Entities;
using Classroom.Entities.Models;
using Classroom.Entities.RequestFeatures;

namespace Classroom.BusinessLayer
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ClassroomContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public Subject GetSubjectById(int id)
        {
            return GetAll().Where(s => s.Id == id).SingleOrDefault();
        }
    }
}
