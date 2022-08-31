using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBook> CustomerBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data for Books
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 1, BookName = "The Hobbit", Author = "J.R.R. Tolkien", IsOnLoan = true});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 2, BookName = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", IsOnLoan = true});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 3, BookName = "The Two Towers", Author = "J.R.R. Tolkien", IsOnLoan = false});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 4, BookName = "The Return of the King", Author = "J.R.R. Tolkien", IsOnLoan = true});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 5, BookName = "To Kill A Mockingbird", Author = "Harper Lee", IsOnLoan = false});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 6, BookName = "The Great Gatsby", Author = "F.Scott Fitzgerald", IsOnLoan = false});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 7, BookName = "Oliver Twist", Author = "Charles Dickens", IsOnLoan = true});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 8, BookName = "Frankenstein", Author = "Mary Shelley", IsOnLoan = false});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 9, BookName = "Wuthering Heights", Author = "Emily Brönte", IsOnLoan = false});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 10, BookName = "Moby Dick", Author = "Heman Melville", IsOnLoan = true});
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 11, BookName = "Song of Solomon", Author = "Toni Morrison", IsOnLoan = false});

            //Seed Data for Customers
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 1,
                FullName = "Hanna Lahtinen",
                Adress = "Skamman 13",
                City = "Varberg",
                ZipCode = "43246",
                Email = "HannaH@gmail.com"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 2,
                FullName = "Jennifer Gergi",
                Adress = "Storgatan 6",
                City = "Varberg",
                ZipCode = "43246",
                Email = "J.Gergi@gmail.com"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 3,
                FullName = "Markus Winborg",
                Adress = "Varberg",
                City = "Storgatan 2",
                ZipCode = "43246",
                Email = "Winborg.98@hotmail.com"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 4,
                FullName = "Sofia Karlsson",
                Adress = "Skammerhult 16",
                City = "Nösslinge",
                ZipCode = "43299",
                Email = "SofiaKarlsson98@gmail.com",
                PhoneNumber = "0738428987"
            });




            //Seed Data For CustomerBook

            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook
            {
                CustomerBookID = 1,
                CustomerID = 1,
                BookID = 1,
                BookBorrowed = new DateTime(2022,07,23),
                BookReturned = new DateTime(2022,08,23)
            });
            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook
            {
                CustomerBookID = 2,
                CustomerID = 1,
                BookID = 2,
                BookBorrowed = new DateTime(2022, 08, 24)
            });
        }
    }
}
