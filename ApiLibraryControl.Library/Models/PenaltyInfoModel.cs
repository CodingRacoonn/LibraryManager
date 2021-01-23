using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.Models
{
    public class PenaltyInfoModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Payment { get; set; }
    }
}
