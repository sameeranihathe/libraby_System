using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibaryData.Models
{
    public class Book: LibraryAsset
    {
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string DeweyIndrx { get; set; }
    }
}
