using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.Entities.Models.ModelsDto;

namespace Classroom.BusinessLayer.Interfaces
{
    public interface IAuthenticationManage
    {
        Task<bool> ValidateUser(UserAuthenDto userForAuth);
        Task<string> CreateToken();

    }
}
