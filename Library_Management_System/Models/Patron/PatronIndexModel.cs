using System;
using System.Collections.Generic;


namespace Library_Management_System.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}
