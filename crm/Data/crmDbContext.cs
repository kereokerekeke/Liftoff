using crm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Data
{
    public class crmDbContext: DbContext
    {

        public crmDbContext(DbContextOptions<crmDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientAllergy>()
                .HasKey(c => new { c.PatientId, c.AllergyId });

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<PatientAllergy> PatientAllergies { get; set; }

        //entities
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
    }


}
