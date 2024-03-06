using SelfTrainProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTrainProject.Abstract
{
    public interface IUserService
    {
        void UserRegister(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);

    }
}
