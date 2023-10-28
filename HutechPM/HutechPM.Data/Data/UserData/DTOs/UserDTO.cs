using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechNote.Data.Data.UserData.DTOs
{
    public class UserDTO
    {
        public string userName { set; get; }
        public string email { set; get; }
        public string phone { set; get; }
        public string password { set; get; }
        public string fullName { set; get; }
        public string address { set; get; }

        public UserDTO(string userName, string email, string phone, string password, string fullName, string address)
        {
            this.userName = userName;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.fullName = fullName;
            this.address = address;
        }
        public UserDTO() { 
        }
    }
}
