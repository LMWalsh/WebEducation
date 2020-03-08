using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebEducation.Models {
    public class Enrolled {

        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }

        [JsonIgnore]
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }

        public Enrolled() { }
    }
}
