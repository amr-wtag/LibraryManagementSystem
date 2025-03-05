using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
    }
}
