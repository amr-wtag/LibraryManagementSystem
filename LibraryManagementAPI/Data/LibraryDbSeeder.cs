using Bogus;
using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data;

public static class LibraryDbSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var passwordHasher = new PasswordHasher<User>();

        // Generate Roles
        var adminRole = new Role { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" };
        var librarianRole = new Role { Id = Guid.NewGuid(), Name = "Librarian", NormalizedName = "LIBRARIAN" };
        var userRole = new Role { Id = Guid.NewGuid(), Name = "User", NormalizedName = "USER" };

        var roles = new List<Role> { adminRole, librarianRole, userRole };
        modelBuilder.Entity<Role>().HasData(roles);

        // Generate Users
        var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => Guid.NewGuid())
            .RuleFor(u => u.UserName, f => f.Internet.UserName())
            .RuleFor(u => u.FullName, f => f.Name.FullName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email.ToUpper())
            .RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName.ToUpper())
            .RuleFor(u => u.EmailConfirmed, f => true);

        var users = userFaker.Generate(5);
        foreach (var user in users) user.PasswordHash = passwordHasher.HashPassword(user, "Password123!");

        modelBuilder.Entity<User>().HasData(users);

        // Assign Roles to Users (First User -> Admin, Second -> Librarian, Rest -> User)
        var userRoles = new List<IdentityUserRole<Guid>>
        {
            new() { UserId = users[0].Id, RoleId = adminRole.Id },
            new() { UserId = users[1].Id, RoleId = librarianRole.Id }
        };

        for (var i = 2; i < users.Count; i++)
            userRoles.Add(new IdentityUserRole<Guid> { UserId = users[i].Id, RoleId = userRole.Id });

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(userRoles);

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
    }
}
