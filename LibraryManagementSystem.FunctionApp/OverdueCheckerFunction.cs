using LibraryManagementAPI.Data;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LibraryManagementSystem.FunctionApp;

public class OverdueCheckerFunction
{
    private readonly LibraryDbContext  _libraryDbContext;
    private ILogger<OverdueCheckerFunction> _logger;

    public OverdueCheckerFunction(LibraryDbContext libraryDbContext, ILogger<OverdueCheckerFunction> logger)
    {
        _libraryDbContext = libraryDbContext;
        _logger = logger;
    }

    [FunctionName("CheckOverdueBookReservations")]
    public async Task Run([TimerTrigger("* * * * * *")] TimerInfo timer)
    {
        _logger.LogInformation("Checking overdue book reservation");
        
        var today = DateTime.UtcNow.Date;

        // var overdueBookReservations = await _libraryDbContext.BookReservations
        //     .Where(r =>
        //         r.Status == "Issued"
        //         && r.DueDate < today
        //         && !r.IsMarkedOverdue).ToListAsync();
        //
        // await _libraryDbContext.SaveChangesAsync();
        
        var overdueReservations = await _libraryDbContext.BookReservations
            .Where(r => r.ReturnDate < DateTime.UtcNow && r.Status != "Overdue")
            .ToListAsync();

        foreach (var reservation in overdueReservations)
        {
            reservation.Status = "Overdue";
            // no IsMarkedOverdue flag, so rely on status
        }
        
        _logger.LogInformation($"{overdueReservations.Count} reservations marked as overdue.");

        await _libraryDbContext.SaveChangesAsync();


    }
    
}
