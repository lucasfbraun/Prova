using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Prova.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Faixa> Faixas { get; set; }
        public DbSet<TipoDeAssociacao>Tipos { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }
    }
}