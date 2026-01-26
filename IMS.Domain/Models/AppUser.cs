using IMS.Domain.Enum;
using Microsoft.AspNetCore.Identity;

namespace IMS.Domain.Models
{
    public class AppUser : IdentityUser
    {
        public Profile Profile { get; set; }

    }
}