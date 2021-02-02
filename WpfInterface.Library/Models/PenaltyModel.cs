using System;
using System.Collections.Generic;
using System.Text;

namespace WpfInterface.Library.Models
{
    public class PenaltyModel
    {
        public int BookRentId { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public decimal Payment { get; set; }
    }
}
