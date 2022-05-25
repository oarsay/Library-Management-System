using System.Collections.Generic;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext() { }

        public LibraryDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedInitialAssetStatuses(modelBuilder);
            LinkAssets(modelBuilder);
            LinkAssetTags(modelBuilder);
        }

        private static void LinkAssets(ModelBuilder modelBuilder)
        {

        }

        private static void LinkAssetTags(ModelBuilder modelBuilder)
        {

        }

        private static void SeedInitialAssetStatuses(ModelBuilder modelBuilder)
        {

        }
    }
}