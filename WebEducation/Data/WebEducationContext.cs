using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEducation.Models;

namespace WebEducation.Data
{
    public class WebEducationContext : DbContext
    {
        public WebEducationContext (DbContextOptions<WebEducationContext> options)
            : base(options)
        {
        }

        public DbSet<WebEducation.Models.Major> Majors { get; set; }
        public DbSet<WebEducation.Models.Student> Students { get; set; }
        public DbSet<WebEducation.Models.Class> Classes { get; set; }
        public DbSet<WebEducation.Models.Enrolled> Enrolleds { get; set; }

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Enrolled>(e => {
                e.ToTable("Enrolleds");
                e.HasKey(x => x.Id);
                e.HasOne(x => x.Class).WithMany(x => x.Enrolleds)
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
                e.HasOne(x => x.Student).WithMany(x => x.Enrolleds)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
            });


        }
    }
}
