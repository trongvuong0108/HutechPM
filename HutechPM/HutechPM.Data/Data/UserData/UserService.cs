using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.UserData.DTOs;
using HutechPM.Data.Entities;

namespace HutechPM.Data.UserData
{
    public class UserService
    {
        private UserRepository userRepository;
        public UserService(HutechNoteDbContext _dbContext) { this.userRepository = new UserRepository(_dbContext); }
        public bool login(string username, string password)
        {
            return userRepository.getAllUser().Any(x => x.userName.Equals(username) && x.password.Equals(password));
        }
        public List<User> GetAllUsers() 
        {
            return userRepository.getAllUser();
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
