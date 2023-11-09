using Microsoft.EntityFrameworkCore;

namespace DoctorApp.Models
{
    public class DoctorAppContext : DbContext
    {
        public DoctorAppContext(DbContextOptions<DoctorAppContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; } 
    }
}
