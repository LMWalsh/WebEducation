using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebEducation.Models {
    public class Major {

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Description { get; set; }
        public int MinSat { get; set; }
              

        public Major() { }

    }
}
