using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.BusinessLayer.Interfaces.Common
{
    public interface IRepositoryManager
    {
        IAttachmentRepository Attachment { get; }
        IGroupRepository Group { get;  }
        ISecretaryRepository Secretary { get;  }
        IStudentRepository Student { get;  }
        ITaskRepository Task { get;  }
        ITeacherRepository Teacher { get;  }

    }
}
