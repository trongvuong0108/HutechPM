using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.UserData.DTOs;
using HutechPM.Data.Entities;

namespace HutechPM.Data.UserData
{
    public class UserService
    {
        private readonly UserRepository userRepository;
        public UserService(HutechNoteDbContext context) { this.userRepository = new UserRepository(context); }
        public bool login(string username, string password)
        {
            return userRepository.getAllUser().Any(x => x.userName.Equals(username) && x.password.Equals(password));
        }

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

        public ActionBaseResult CreateUser(UserDTO userDTO)
        {
            User user = new User(new Guid(), userDTO.userName, userDTO.password, userDTO.email, userDTO.phone, userDTO.fullName, userDTO.address);
            userRepository.createUser(user);
            return new ActionBaseResult();
        }
    }
}
