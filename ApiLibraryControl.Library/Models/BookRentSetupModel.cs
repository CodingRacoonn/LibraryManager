using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.Models
{
    public class BookRentSetupModel
    {
        public int BookId { get; set; }
        public string UserId { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
    }
}
