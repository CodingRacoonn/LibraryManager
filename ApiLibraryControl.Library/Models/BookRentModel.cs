using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.Models
{
    public class BookRentModel
    {
        public int BookId { get; set; }
        public string UserId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int ProlongCount { get; set; }
    }
}
