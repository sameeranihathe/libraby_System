using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibaryData.Models
{
    public class LibraryBranch
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30,ErrorMessage ="Limit Branch NAme to 30 characters")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }

        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual IEnumerable<Patron> Patrons { get; set; }
        public virtual IEnumerable<LibraryAsset> LibraryAsset { get; set; }

        public string ImageUrl { get; set; }
    }
}