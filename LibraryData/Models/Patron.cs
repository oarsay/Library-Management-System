using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Patron
    {
        public int Id{ get; set;}
        public string FirstName{ get; set; } = default!;
        public string Lastname{ get; set; } = default!;
        public string Address{ get; set; } = default!;
        public DateTime DateOfBirth{ get; set;}
        public string TelephoneNumber{ get; set; } = default!;

        public virtual LibraryCard LibraryCard { get; set;}
        public virtual LibraryBranch HomeLibraryBranch { get; set; }
    }
}
