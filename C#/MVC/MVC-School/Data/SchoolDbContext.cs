using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_School.Models;

namespace MVC_School.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Studenten { set; get; }
        public DbSet<Locatie> Locaties { set; get; }
        public DbSet<Docent> Docenten { set; get; }
        public DbSet<Vak> Vakken { set; get; }
        public DbSet<VakStudent> VakStudenten { set; get; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<VakStudent>()
                .HasKey(vs => new { vs.StudentId, vs.VakId });
        }
    }
}
