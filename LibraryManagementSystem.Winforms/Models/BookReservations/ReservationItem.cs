using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Winforms.Models.BookReservations
{
    public class ReservationItem
    {
        public Guid BookId { get; set; }

        public DateTime DueDate {  get; set; }
    }
}
