using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Data.ProjectData;
using HutechPM.Data.Data.UserData.DTOs;
using HutechPM.Data.Entities;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

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
            return users.FirstOrDefault(x => x.userName.Equals(username) && x.password.Equals(password));
        }


        public async Task<ActionBaseResult> CreateUser(UserDTO userDTO)
        {
            User user = new User(new Guid(), userDTO.userName, userDTO.password, userDTO.email, userDTO.phone, userDTO.fullName, userDTO.address);
            ActionBaseResult result = await userRepository.createUser(user);
            return result;
        }
        public async Task<ActionBaseResult> updateUser(User user)
        {
            return await userRepository.updateUser(user);
        }


        public async Task<List<UserDTO>> getListUserDTO(List<User> users)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (User user in users)
            {
                UserDTO userDTO = new UserDTO();
                userDTO.userName = user.userName;
                userDTO.email = user.email;
                if (user.gender == false)
                {
                    userDTO.genderDTO = "Female";
                }
                else
                {
                    userDTO.genderDTO = "Male";
                }
                ProjectDetail findUserRole = await userRepository.findProjetRoleOfOwner(user);
                if (findUserRole != null)
                {
                    userDTO.projectRole = findUserRole.projectRole;
                    userDTO.projectName = findUserRole.project.projectName;
                }
                int count = 0;
                foreach (ProjectTask projectTask in await userRepository.GetProjectTask())
                {
                    if (projectTask.projectDetail.user.userId == user.userId)
                    {
                        count++;
                    }
                }
                userDTO.quantityTask = count;
                userDTO.avatar = user.avatar;
                userDTOs.Add(userDTO);
            }
            return userDTOs;
        }


        public async Task<List<UserDTO>> getUserProfile(User user)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            UserDTO userDTO = new UserDTO();
            userDTO.userName = user.userName;
            userDTO.email = user.email;
            userDTO.phone = user.phone;
            userDTO.fullName = user.fullName;
            userDTO.address = user.address;
            if (user.gender == false)
            {
                userDTO.genderDTO = "Female";
            }
            else
            {
                userDTO.genderDTO = "Male";
            }
            userDTO.isActive = user.isActive;
            userDTO.avatar = user.avatar;
            userDTOs.Add(userDTO);
            return userDTOs;
        }
        public async Task<User> findUserByEmail(string email)
        {
            return await userRepository.findUserByEmail(email);
        }
    
    }
}

