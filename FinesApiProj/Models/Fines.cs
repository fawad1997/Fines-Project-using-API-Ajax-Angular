using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinesApiProj.Models
{
    public class Fines
    {
        public int Id { get; set; }
        public string studentname { get; set; }
        public Nullable<System.DateTime> dateoffine { get; set; }
        public string status { get; set; }
        public Nullable<int> rule_id { get; set; }

        public virtual FineRules FineRules { get; set; }
    }
}