using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EMAProject.Domain.Entities;

namespace EMAProject.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "6AB1B3A7-8C92-43EA-B6FB-8B6A0FCC8A49",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "5C036923-6C06-4585-8B6B-0C0F7185D68A",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "test@mail.com",
                NormalizedEmail = "TEST@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "bruhpword"),
                SecurityStamp = string.Empty

            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "EB9D83A2-A48F-4B0C-81CA-67F4AFEBA00C",
                UserId = "5C036923-6C06-4585-8B6B-0C0F7185D68A"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = "F80BC210-BF07-4C29-B412-DA35CB2B3FDB",
                CodeWord = "PageIndex",
                Title = "MainPage"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = "B8BC4020-B3FD-4928-B83D-F6E41616F657",
                CodeWord = "PageServices",
                Title = "OurServices"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = "E8E1F1B0-BEA1-4228-B7EA-40A979A2F4DA",
                CodeWord = "PageContatcs",
                Title = "Contactcs"
            });
        }
    }
}
