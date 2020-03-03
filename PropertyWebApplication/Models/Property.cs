using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PropertyWebApplication.Models
{
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int LocalityId { get; set; }
        public Locality Locality { get; set; }

        [Required][Range(100.0, 10000000.0, ErrorMessage = "The price for a property needs to be between 100 and 10,000,000")]
        public decimal Price { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(DataType.Date)]
        public DateTime Registered { get; set; }

        public String ImageUrl { get; set; }
    }
}