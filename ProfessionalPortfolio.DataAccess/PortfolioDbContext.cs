using Microsoft.EntityFrameworkCore;
using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.DataAccess
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {

        }

        public PortfolioDbContext()
        {

        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkingExperience> WorkingExperiences { get; set; }
    }
}
