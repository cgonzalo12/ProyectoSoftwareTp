using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Entities.TaskStatus;

namespace Infraestructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=GONZA-12\\SQLEXPRESS;Database=proyectotp1;User Id=proyectosoftware;Password=admin@123;");
            }
        }

        public DbSet<Proyects> Proyects { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Interactions> Interactions { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<CampaingTypes> CampaingTypes { get; set; }
        public DbSet<InterationTypes> InterationTypes { get; set; }
        public DbSet<TaskStatus> TaskStatus { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(t => t.TaskID);

                entity.HasOne<Users>(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.AssignetTo);

                entity.HasOne<Proyects>(t => t.Proyect)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectID);

                entity.HasOne<TaskStatus>(t => t.TaskStatus)
                .WithMany(ts=>ts.Tasks)
                .HasForeignKey(t=> t.Status);
            });
            modelBuilder.Entity<Proyects>(entity =>
            {
                entity.HasKey(p => p.ProjectID);

                entity.HasOne<Clients>(p => p.Client)
                .WithMany(c => c.Proyects)
                .HasForeignKey(p => p.ClientID);

                entity.HasOne<CampaingTypes>(p => p.CampaingTypes)
                .WithMany(ct => ct.Proyects)
                .HasForeignKey(p => p.CampaignType);

                entity.HasMany<Interactions>(p => p.Interactions)
                .WithOne(i => i.Proyect)
                .HasForeignKey(i => i.ProjectID);

                entity.HasMany<Tasks>(p => p.Tasks)
                .WithOne(t=>t.Proyect)
                .HasForeignKey(t=>t.ProjectID);

            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(c => c.ClientID);

                entity.HasMany<Proyects>(c => c.Proyects)
                      .WithOne(p => p.Client)
                      .HasForeignKey(p => p.ClientID);
            });
            modelBuilder.Entity<Interactions>(entity =>
            {
                entity.HasKey(i => i.InteractionID);

                entity.HasOne<Proyects>(i =>i.Proyect )
                      .WithMany(p => p.Interactions)
                      .HasForeignKey(p => p.ProjectID);

                entity.HasOne<InterationTypes>(i => i.InterationTypes)
                .WithMany(it => it.Interactions)
                .HasForeignKey(it => it.InteractionType);
            });
            //entidades static
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(u=>u.UserID);

                entity.HasMany<Tasks>(u => u.Tasks)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.AssignetTo);
                entity.HasData(
                    new Users (1,"Joe Done","jdone@marketing.com"),
                    new Users (2,"Nill Amstrong","namstrong@marketing.com"),
                    new Users (3,"Marlyn Morales", "mmorales@marketing.com" ),
                    new Users(4, "Antony Orué", "aorue@marketing.com"),
                    new Users(5, "Jazmin Fernandez", "jfernandez@marketing.com")
                );    
            });
            modelBuilder.Entity<TaskStatus>( entity =>
            {
                entity.HasKey(u => u.Id);

                entity.HasMany<Tasks>(ts => ts.Tasks)
                .WithOne(t => t.TaskStatus)
                .HasForeignKey(t => t.Status);
                entity.HasData(
                    new TaskStatus(1, "Pending"),
                    new TaskStatus(2, "In Progress"),
                    new TaskStatus(3, "Blocked"),
                    new TaskStatus(4, "Done"),
                    new TaskStatus(5, "Cancel")
                );
            });
            modelBuilder.Entity<CampaingTypes>(entity =>
            {
                entity.HasKey(ct => ct.Id);

                entity.HasMany<Proyects>(ct => ct.Proyects)
                .WithOne(p => p.CampaingTypes)
                .HasForeignKey(p => p.CampaignType);
                entity.HasData(
                    new CampaingTypes(1, "SEO"),
                    new CampaingTypes(2, "PPC"),
                    new CampaingTypes(3, "Social Media"),
                    new CampaingTypes(4, "Email Marketing")
                );
            });
            modelBuilder.Entity<InterationTypes>(entity =>
            {
                entity.HasKey(it => it.Id);

                entity.HasMany<Interactions>(it => it.Interactions)
                .WithOne(i => i.InterationTypes)
                .HasForeignKey(p => p.InteractionType);
                entity.HasData(
                    new InterationTypes(1, "Initial Meeting"),
                    new InterationTypes(2, "Phone call"),
                    new InterationTypes(3, "Email"),
                    new InterationTypes(4, "Presentation of Results")
                );
            });






        }

    }
}
