using System;
using System.Collections.Generic;
using System.Text;

namespace WpfInterface.Library.Models
{
    public class LoggedUserModel : ILoggedUserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Token { get; set; }
    }
}
