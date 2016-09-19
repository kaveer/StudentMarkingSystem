using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkingSystem
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public int UserInfoId { get; set; }

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserAddress { get; set; }
        public int Contact { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }

        public string UserStatus { get; set; }
        public string UserType { get; set; }
    }
}