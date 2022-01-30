using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;


namespace entity_lib
{
    public class LibraryContext: DbContext
    {
        
        public LibraryContext(): base()
        {
            connectionString="Data Source=DESKTOP-RVN7H4P\\SQLSERVER;Initial Catalog=EntityLibrary;User ID =sa; Password =asm1378";
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "EFLib.db");
        }
        
        public string connectionString;
        public string DbPath;
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Shelf> Shelfs{get;set;}
        public DbSet<ShelfBook> ShelfBooks{get;set;}

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer($"Data Source={DbPath}");
           optionsBuilder.UseSqlServer("Data Source=DESKTOP-RVN7H4P\\SQLSERVER;Initial Catalog=EntityLibrary;User ID =sa; Password =asm1378");

        }   
        protected override void  OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(u=>u.ID);
            modelBuilder.Entity<User>().Property(u => u.UserName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.FamilyName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.UserName).IsRequired();
            modelBuilder.Entity<Book>().HasKey(b=>b.bookID);
            modelBuilder.Entity<Shelf>().HasKey(s=>s.shelfID);
            modelBuilder.Entity<ShelfBook>().HasKey(sb => new { sb.shelfBookID});
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Shelf>().ToTable("Shelfs");
            modelBuilder.Entity<ShelfBook>().ToTable("ShelfBooks");
            
            
    

        }
    }
}