using Bogus;
using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data;

public class LibraryDbContext : IdentityDbContext<User, Role, Guid>
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Book)
            .WithMany(b => b.Transactions)
            .HasForeignKey(t => t.BookId);

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.User)
            .WithMany(b => b.Transactions)
            .HasForeignKey(t => t.UserId);

        // Call Seed Data
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        var passwordHasher = new PasswordHasher<User>();

        // Generate Roles
        var roles = new List<Role>
        {
            new Role { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" },
            new Role { Id = Guid.NewGuid(), Name = "Librarian", NormalizedName = "LIBRARIAN" },
            new Role { Id = Guid.NewGuid(), Name = "User", NormalizedName = "USER" }
        };
        modelBuilder.Entity<Role>().HasData(roles);

        // Generate Users
        var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => Guid.NewGuid())
            .RuleFor(u => u.UserName, f => f.Internet.UserName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email.ToUpper())
            .RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName.ToUpper())
            .RuleFor(u => u.EmailConfirmed, f => true);

        var users = userFaker.Generate(5);
        foreach (var user in users)
        {
            user.PasswordHash = passwordHasher.HashPassword(user, "Password123!");
        }

        modelBuilder.Entity<User>().HasData(users);

        // Generate Books with Categories
        var bookCategories = new[] { "Fiction", "Science", "History", "Technology", "Mystery" };

        var bookFaker = new Faker<Book>()
            .RuleFor(b => b.Id, f => Guid.NewGuid())
            .RuleFor(b => b.Title, f => f.Lorem.Sentence(3))
            .RuleFor(b => b.Author, f => f.Name.FullName())
            .RuleFor(b => b.Category, f => f.PickRandom(bookCategories))
            .RuleFor(b => b.CopiesAvailable, f => f.Random.Int(1, 20));

        var books = bookFaker.Generate(10);
        modelBuilder.Entity<Book>().HasData(books);


        var transactionFaker = new Faker<Transaction>()
            .RuleFor(t => t.Id, f => Guid.NewGuid())
            .RuleFor(t => t.BookId, f => f.PickRandom(books).Id)
            .RuleFor(t => t.UserId, f => f.PickRandom(users).Id)
            .RuleFor(t => t.IssuedDate, f => f.Date.Past(1).ToUniversalTime()) // ✅ Convert to UTC
            .RuleFor(t => t.DueDate,
                (f, t) => t.IssuedDate.AddDays(f.Random.Int(7, 30)).ToUniversalTime()) // ✅ Convert to UTC
            .RuleFor(t => t.ReturnDate, (f, t) =>
                f.Random.Bool(0.7f)
                    ? t.DueDate.AddDays(f.Random.Int(-5, 5)).ToUniversalTime()
                    : null) // ✅ Convert to UTC
            .RuleFor(t => t.Status,
                (f, t) => t.ReturnDate == null ? "Issued" : f.PickRandom(new[] { "Issued", "Returned", "Overdue" }));

        var transactions = transactionFaker.Generate(15);
        modelBuilder.Entity<Transaction>().HasData(transactions);
    }
}
