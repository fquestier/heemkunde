using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Heemkunde.AspNetCore.WebApp.Models;
using Object = Heemkunde.AspNetCore.WebApp.Models.Object;

namespace Heemkunde.AspNetCore.WebApp.Data
{
    public class HeemkundeDbContext : IdentityDbContext
    {
        public HeemkundeDbContext(DbContextOptions<HeemkundeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Object> Objects { get; set; }
        public DbSet<ObjectCategory> ObjectCategories { get; set; }
        public DbSet<ObjectElement> ObjectElements { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
    }
}
