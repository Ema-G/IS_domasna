using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Web.Models
{
    public class UserRoles
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int RoleId { get; set; }
        public ApplicationUser User { get; set; }
        public Roles Role { get; set; }
    }
}
