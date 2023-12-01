using Microsoft.EntityFrameworkCore;

namespace PatientDonation.web.Models
{
    public class PDContext :DbContext

    {
        public PDContext(DbContextOptions<PDContext> options) : base(options) { }

        public DbSet<Needy> Needies { get; set; }

        public DbSet<Donar> Donars { get; set; }

        public DbSet<Authority> Authorities { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Register> Registers { get; set; }

        public DbSet<Contact> contacts { get; set; }
        
    
    
    }
}
