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


        public async Task<List<User>> GetAllUsers()
        {
            return await userRepository.getAllUser();
        }

        public async Task<bool> login(string username, string password)
        {
            var users = await userRepository.getAllUser();
            return users.Any(x => x.userName.Equals(username) && x.password.Equals(password));
        }
        public async Task<User> getUser(string username, string password)
        {
            var users = await userRepository.getAllUser();
            return users.FirstOrDefault(x => x.userName.Equals(username) && x.password.Equals(password));        }


        public async Task<ActionBaseResult> CreateUser(UserDTO userDTO)
        {
            User user = new User(new Guid(), userDTO.userName, userDTO.password, userDTO.email, userDTO.phone, userDTO.fullName, userDTO.address);
            ActionBaseResult result =  await userRepository.createUser(user);
            return result;
        }
    }
}
