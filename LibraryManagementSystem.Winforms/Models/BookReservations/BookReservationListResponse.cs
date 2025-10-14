using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Winforms.Models.BookReservations
{
    public class BookReservationListResponse
    {
        [JsonPropertyName("$values")]
        public List<BookReservation> BookReservations { get; set; } = new();
    }
}
