using System;
using System.Collections.Generic;

#nullable disable

namespace SeftTraining.Data.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public int Status { get; set; }
    }
}
