using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalTrials.Data
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<FormElement> FormElements { get; set; } 
    }
}