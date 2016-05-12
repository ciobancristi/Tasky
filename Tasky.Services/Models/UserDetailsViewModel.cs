using System;

namespace Tasky.Services.Models
{
    public class UserDetailsViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
