using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinesApiProj.Models
{
    public class FineRules
    {
        public FineRules()
        {
            this.Fines = new HashSet<Fines>();
        }

        public int Id { get; set; }
        public string title { get; set; }
        public double amount { get; set; }
        public virtual ICollection<Fines> Fines { get; set; }
    }
}