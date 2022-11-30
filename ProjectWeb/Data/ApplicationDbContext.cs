using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Record> Records { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCategory(builder);
            SeedRecord(builder);
            SeedTemplate(builder);
        }

        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Nghị định"},
                new Category() { Id = 2, Name = "Quyết định" },
                new Category() { Id = 3, Name = "Thông báo" },
                new Category() { Id = 4, Name = "Thông tư" }
                );
        }

        private void SeedRecord(ModelBuilder builder)
        {
            builder.Entity<Record>().HasData(
                new Record() { id = 1, document_name = "abcd", document_id = "12345678", book_number = "b-123", version = "#123", last_fix = 15, tag = "Đất đai", CategoryId = 1, Dear_to = "Phòng đào tạo\nPhòng cộng tác sinh viên", Destination = "Abcd\nEfgh", Content = "aaaaaaaaaaaaaaaaaaaa", signed_day = new DateTime(2015, 02, 02)},
                new Record() { id = 2, document_name = "efgh", document_id = "87654321", book_number = "b-321", version = "#321", last_fix = 10, tag = "Đất đai", CategoryId = 2, Dear_to = "Phòng đào tạo\nPhòng cộng tác sinh viên", Destination = "Abcd\nEfgh", Content = "aaaaaaaaaaaaaaaaaaaa", signed_day = new DateTime(2016, 02, 02) },
                new Record() { id = 3, document_name = "jklm", document_id = "12345", book_number = "b-456", version = "#456", last_fix = 20, tag = "Sở giáo dục", CategoryId = 3, Dear_to = "Phòng đào tạo\nPhòng cộng tác sinh viên", Destination = "Abcd\nEfgh", Content = "aaaaaaaaaaaaaaaaaaaa", signed_day = new DateTime(2017, 02, 02) }
                );
        }

        private void SeedTemplate(ModelBuilder builder)
        {
            builder.Entity<Template>().HasData(
                new Template() { id = 1, url = "https://wallpapercave.com/dwp1x/wp4033162.jpg", name = "Template 1" },
                new Template() { id = 2, url = "https://wallpapercave.com/dwp1x/wp4033170.jpg", name = "Template 2" },
                new Template() { id = 3, url = "https://wallpapercave.com/dwp1x/wp4033182.jpg", name = "Template 3" },
                new Template() { id = 4, url = "https://getwallpapers.com/wallpaper/full/8/5/9/184657.jpg", name = "Template 4" },
                new Template() { id = 5, url = "https://getwallpapers.com/wallpaper/full/6/6/7/184805.jpg", name = "Template 5" },
                new Template() { id = 6, url = "https://getwallpapers.com/wallpaper/full/e/5/b/184912.jpg", name = "Template 6" }
                );
        }
    }
}
