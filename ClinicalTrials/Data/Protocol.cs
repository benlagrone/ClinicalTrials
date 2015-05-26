using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrials.Data
{
    public class Protocol
    {
        public int Id {get; set;}
        public string ProtocolId {get; set;} 
        public string NCTNum_1 {get; set;} 
        public string ptitle {get; set;} 
        public string display4 {get; set;} 
        public string display2 {get; set;} 
        public string display6 {get; set;} 
        public string protocol_desc {get; set;} 
        public string disease {get; set;} 
        public string phase {get; set;} 
        public string agents {get; set;} 
        public string location {get; set;} 
        public string l_stay {get; set;}
        public string sponsor { get; set; } 
        public string retrn_visit {get; set;} 
        public string home_care {get; set;} 
        public string ch_name {get; set;} 
        public string ch_dept {get; set;} 
        public string ch_phone {get; set;} 
        public string refer_phone {get; set;} 
        public string ProtObj {get; set;} 
        public string ProtObjText {get; set;} 
        public string regDate {get; set;} 
        public string irbappDate {get; set;} 
        public string NCIStudyType {get; set;} 
        public string RecruitStat {get; set;} 
        public string ProjAccrual {get; set;} 
        public string inclusion {get; set;} 
        public string exclusion {get; set;} 
        public string NCTNum {get; set;} 
        public string Link {get; set;} 
        public string LinkText {get; set;} 
        public string Results {get; set;} 
        public string ResultsText {get; set;} 
        public string testField {get; set;} 
    
        public virtual ICollection<FormElementOption> FormElementOptions { get; set; }

    }
}