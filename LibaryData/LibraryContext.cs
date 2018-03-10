using LibaryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibaryData
{
    public class LibraryContext: DbContext
    {
         public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Book { get; set; }
        public DbSet<BranchHours> BranchHours { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistory { get; set; }
        public DbSet<Hold> Hold { get; set; }
        public DbSet<LibraryAsset> LibraryAsset { get; set; }
        public DbSet<LibraryBranch> LibraryBranch { get; set; }
        public DbSet<LibraryCard> LibraryCard { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Patron> Patron { get; set; }

    }
}
