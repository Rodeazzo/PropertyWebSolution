using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropertyWebApplication.Models
{
    public class Locality
    {
        /// Id is the primary key. It should be named Id
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Your locality name is too short!")]
        public string Name { get; set; }

        /// <summary>
        /// Since we are using the virtual keyword, the Properties for a locality are ONLY loaded when needed
        /// </summary>
        public virtual ICollection<Property> Properties { get; set; }
    }
}