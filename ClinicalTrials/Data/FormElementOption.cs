using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrials.Data
{
    public class FormElementOption
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string ValueId { get; set; }
        public string GroupId { get; set; }
        public DateTime Created { get; set; }

        public virtual int? FormElementId { get; set; }
        public virtual int? ChildFormElementId { get; set; }
        public virtual ICollection<ChildFormElement> ChildFormElements { get; set; }
        public virtual ICollection<Protocol> Protocols { get; set; }
    }
}