using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrials.Data
{
    public class ChildFormElement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FormId { get; set; }
        public string Type { get; set; }
        public string Placeholder { get; set; }
        public string IconClass { get; set; }
        public DateTime Created { get; set; }

        public virtual int FormElementOptionId { get; set; }

        public virtual ICollection<FormElementOption> FormElementOptions { get; set; } 
    }
}