using Microsoft.AspNetCore.Identity;
using ProjetoRole.Migrations;

namespace ProjetoRole.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
