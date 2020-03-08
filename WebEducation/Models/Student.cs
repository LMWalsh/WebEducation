using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models {
    public class Student {      

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Firstname { get; set; }
        [StringLength(30)]
        [Required]
        public string Lastname { get; set; }
        public int SAT { get; set; }       
        public double GPA { get; set; } 
        public int? MajorId { get; set; }
        public virtual Major Major { get; set; } //sets foreign key

        public virtual IEnumerable<Enrolled>Enrolleds { get; set; }

        public Student() { }
    }
}
