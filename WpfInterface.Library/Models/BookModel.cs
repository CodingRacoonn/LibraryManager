using System;
using System.Collections.Generic;
using System.Text;

namespace WpfInterface.Library.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
