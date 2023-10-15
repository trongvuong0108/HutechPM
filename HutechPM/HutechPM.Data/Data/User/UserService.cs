using HutechNote.Data.Data.User.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.User.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechNote.Data.Data.User
{
    public class ProjectService
    {
        
        public List<UserDTO> GetAllUsers() {
            return new List<UserDTO>();
        }

        public UserDTO GetUser(string id) 
        {
            return new UserDTO();
        }

        public List<UserDTO> GetUsersByProject()
        {
            return new List<UserDTO>();
        }

        public List<UserDTO> GetUserByName(string kw)
        {
            return new List<UserDTO>();
        }

        public ActionBaseResult CreateUser(CreateUserRequest user)
        {
            return new ActionBaseResult();
        }
    }
}
