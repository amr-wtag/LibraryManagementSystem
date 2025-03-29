using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data;

public class LibraryDbContext : IdentityDbContext<User, Role, Guid>
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<BookReservation> BookReservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Update relationships to use BookReservation
        modelBuilder.Entity<BookReservation>()
            .HasOne(br => br.Book)
            .WithMany(b => b.BookReservations)
            .HasForeignKey(br => br.BookId);

        modelBuilder.Entity<BookReservation>()
            .HasOne(br => br.User)
            .WithMany(u => u.BookReservations)
            .HasForeignKey(br => br.UserId);

        // Call Seed Data
        LibraryDbSeeder.Seed(modelBuilder);
    }
}
