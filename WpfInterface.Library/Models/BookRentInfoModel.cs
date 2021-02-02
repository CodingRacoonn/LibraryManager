using System;
using System.Collections.Generic;
using System.Text;

namespace WpfInterface.Library.Models
{
    public class BookRentInfoModel
    {
        public int BookId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int ProlongCount { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Publisher { get; set; }
    }
}
