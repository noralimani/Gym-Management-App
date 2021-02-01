using GymManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagementSystem.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options)  : base(options)
        {
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Service> Services { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Member>().ToTable("Member");
        //    modelBuilder.Entity<Membership>().ToTable("Membership");
        //    modelBuilder.Entity<Staff>().ToTable("Staff");
        //}
    }
}
