using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<MemberDetails> Members { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Book)
            .WithMany(b => b.Transactions)
            .HasForeignKey(t => t.BookId);

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Member)
            .WithMany(b => b.Transactions)
            .HasForeignKey(t => t.MemberId);
    }
}
