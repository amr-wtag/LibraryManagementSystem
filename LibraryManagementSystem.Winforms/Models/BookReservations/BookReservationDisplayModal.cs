namespace LibraryManagementSystem.Winforms.Models.BookReservations
{
    public class BookReservationDisplayModal
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? Status { get; set; }

        public string? BookTitle { get; set; }
    }
}
