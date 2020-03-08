using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models {
    public class Class {

        public int Id{ get; set; }
        [StringLength(30)]
        public string Subject { get; set; }
        public int Section { get; set; }

        public virtual IEnumerable<Enrolled> Enrolleds { get; set;  }

        public Class() { }

    }
}
