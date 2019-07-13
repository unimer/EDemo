using System;
using System.Collections.Generic;
using System.Text;

namespace DummyDB.Models
{
    class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int Team { get; set; }
    }
}
