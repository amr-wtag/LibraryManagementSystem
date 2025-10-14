using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Winforms.Models.BookReservations
{
    public class ReservationRequest
    {
        public Guid UserId { get; set; }
        public List<ReservationItem> Reservations { get; set; } = new();
    }
}
