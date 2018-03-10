using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibaryData.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        [Required]
        public LibraryAsset libraryAsset { get; set; }

        [Required]
        public LibraryCard LibraryCard { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        public DateTime? CheckedIn { get; set; }

    }
}
