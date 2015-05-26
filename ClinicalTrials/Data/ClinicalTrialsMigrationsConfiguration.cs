using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace ClinicalTrials.Data
{
    public class ClinicalTrialsMigrationsConfiguration
      : DbMigrationsConfiguration<ClinicalTrialsContext>
    {
        public ClinicalTrialsMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ClinicalTrialsContext context)
        {
            base.Seed(context);

#if DEBUG

            //if (context.Groups.Count() == 0) {
            
            //Start Group 1
            var group = new Group()
            {//Start Group 1
                Title = "GynOnc",
                Created = DateTime.Now,
                FormElements = new List<FormElement>()
            };//Ends group
            //Add Group 
            context.Groups.Add(group);

            group.FormElements.Add(
                new FormElement
                {
                    Title = "Search",
                    FormId = "search",
                    Type = "text",
                    Placeholder = "Select options below or search here",
                    IconClass = "search",
                    Created = DateTime.Now,
                    ParentId = group.Id,
                    FormElementOptions = null,

                }
                );
            group.FormElements.Add(
                new FormElement()
                        {
                            Title = "Target",
                            FormId = "target",
                            Type = "select",
                            Placeholder = "Select a Disease Site",
                            IconClass = "crosshairs",
                            Created = DateTime.Now,
                            ParentId = group.Id,
                            FormElementOptions = new List<FormElementOption>()
                                {
                                    new FormElementOption()
                                    //Begin Ovary Form element option
                                {
                                    Label = "Ovary",
                                    Value = "ovary",
                                    Group = null,
                                    Created = DateTime.Now,
                                    ChildFormElementId = null,
                                    ChildFormElements = new List<ChildFormElement>()
                                    {
                                    new ChildFormElement()
                                            {
                                                Title="Histology",
                                                FormId = "histology",
                                                Type="select",
                                                Placeholder="Select a Histology",
                                                IconClass="crosshairs",
                                                Created = DateTime.Now,
                                                FormElementOptions = new List<FormElementOption>()
                                                {
                                                    new FormElementOption()
                                                    {
                                                        Value = "highgradeserrous",
                                                        Label = "High Grade Serous",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "lowgrade",
                                                        Label = "Low Grade",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "clearcell",
                                                        Label = "Clear Cell",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "endometrial",
                                                        Label = "Endometrial",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "mucinous",
                                                        Label = "Mucinous",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "mixed",
                                                        Label = "Mixed",
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "germcell",
                                                        Label = "Germ Cell",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "stromal",
                                                        Label = "Stromal",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "smallcell",
                                                        Label = "Small Cell",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "metastatic",
                                                        Label = "metastatic",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "sarcoma",
                                                        Label = "Sarcoma",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "other",
                                                        Label = "Other",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  null
                                                    }
                                                }//end FormElementOptions
                                            },// end ChildFormElement
                                            new ChildFormElement()
                                            {
                                                Title="Type of Trial",
                                                FormId = "typeoftrial",
                                                Type="select",
                                                Placeholder="Select a Type of Trial",
                                                IconClass="crosshairs",
                                                Created = DateTime.Now,
                                                FormElementOptions = new List<FormElementOption>()
                                                 {
                                                    new FormElementOption()
                                                    {
                                                        Value = "primarytreatment",
                                                        Label = "Primary Treatment",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                Title="Measurable Disease",
                                                                FormId = "measurabledisease",
                                                                Type="select",
                                                                Placeholder="Does the patient have a measurable disease?",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "yes",
                                                                        Label = "Yes",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "no",
                                                                        Label = "No",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            }
                                                        }//end childformelements
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "primarymaintenance",
                                                        Label = "Primary Maintenance",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                Title="Macro-Positive",
                                                                FormId = "macropositive",
                                                                Type="select",
                                                                Placeholder="Patient is...",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "micro-positive",
                                                                        Label = "Micro-Positive",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "macro-positive",
                                                                        Label = "Macro-Positive",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "negative",
                                                                        Label = "Negative",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "unknown",
                                                                        Label = "Unknown",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "recurrence",
                                                        Label = "Recurrence",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                Title="Platinum Sensitive",
                                                                FormId = "platinumsensitive",
                                                                Type="select",
                                                                Placeholder="Patient is...",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                        {
                                                                            Label="PlatinumSensitive",
                                                                            Value="Platinum Sensitive",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        },
                                                                    new FormElementOption()
                                                                        {
                                                                            Label="PlatinumResistant",
                                                                            Value="Platinum Resistant",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        },
                                                                    new FormElementOption()
                                                                        {
                                                                            Label="Skip",
                                                                            Value="Skip this Criteria",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        }
                                                                }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                Title="Has Measurable Diseas",
                                                                FormId = "measurabledisease",
                                                                Type="select",
                                                                Placeholder="Select an option",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "yes",
                                                                        Label = "Yes",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "no",
                                                                        Label = "No",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "unknown",
                                                                        Label = "Unknown",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "skip",
                                                                        Label = "Skip This Criteria",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                Title="Number of Prior Therapies for Recurrence",
                                                                FormId = "recurrance",
                                                                Type="select",
                                                                Placeholder="Select a number",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "0",
                                                                        Label = "0",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "1",
                                                                        Label = "1",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "2",
                                                                        Label = "2",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "3plus",
                                                                        Label = "3+",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            },
                                                        }
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "recurrencemaintenance",
                                                        Label = "Recurrence Maintenance",
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  null
                                                    }
                                                 }
                                            }
                                    },
                                    //begin protocols responses
                                    Protocols = new List<Protocol>()
                                    {
                                        new Protocol()
                                        {
                                            ProtocolId = "foo1", 
                                            NCTNum_1 = "foo", 
                                            ptitle = "foo", 
                                            display4 = "foo", 
                                            display2 = "foo", 
                                            display6 = "foo", 
                                            protocol_desc = "foo", 
                                            disease = "foo", phase = "foo", 
                                            agents = "foo", location = "foo", 
                                            l_stay = "foo", sponsor = "foo", 
                                            retrn_visit = "foo", 
                                            home_care = "foo", 
                                            ch_name = "foo", 
                                            ch_dept = "foo", 
                                            ch_phone = "foo", 
                                            refer_phone = "foo", 
                                            ProtObj = "foo", 
                                            ProtObjText = "foo", 
                                            regDate = "foo", 
                                            irbappDate = "foo", 
                                            NCIStudyType = "foo", 
                                            RecruitStat = "foo", 
                                            ProjAccrual = "foo", 
                                            inclusion = "foo", 
                                            exclusion = "foo", 
                                            NCTNum = "foo", 
                                            Link = "foo", 
                                            LinkText = "foo", 
                                            Results = "foo", 
                                            ResultsText = "foo", 
                                            testField = "foo"
                                        },
                                        new Protocol()
                                        {
                                            ProtocolId = "foo2", 
                                            NCTNum_1 = "foo", 
                                            ptitle = "foo", 
                                            display4 = "foo", 
                                            display2 = "foo", 
                                            display6 = "foo", 
                                            protocol_desc = "foo", 
                                            disease = "foo", phase = "foo", 
                                            agents = "foo", location = "foo", 
                                            l_stay = "foo", sponsor = "foo", 
                                            retrn_visit = "foo", 
                                            home_care = "foo", 
                                            ch_name = "foo", 
                                            ch_dept = "foo", 
                                            ch_phone = "foo", 
                                            refer_phone = "foo", 
                                            ProtObj = "foo", 
                                            ProtObjText = "foo", 
                                            regDate = "foo", 
                                            irbappDate = "foo", 
                                            NCIStudyType = "foo", 
                                            RecruitStat = "foo", 
                                            ProjAccrual = "foo", 
                                            inclusion = "foo", 
                                            exclusion = "foo", 
                                            NCTNum = "foo", 
                                            Link = "foo", 
                                            LinkText = "foo", 
                                            Results = "foo", 
                                            ResultsText = "foo", 
                                            testField = "foo"
                                        }
                                    }
                                },//End Ovary Form Element Option
                                new FormElementOption()
                                //begin endometrial form element option
                                {
                                    Label = "Endometrial",
                                    Value = "endometrial",
                                    Group = null,
                                    Created = DateTime.Now,
                                    ChildFormElementId = null,
                                    ChildFormElements = new List<ChildFormElement>()
                                    {
                                        
                                        new ChildFormElement()
                                            {
                                                FormId= "histology", 
                                                Title= "Histology", 
                                                Type= "select", 
                                                Placeholder= "Select a Disease Site", 
                                                IconClass= "crosshairs",
                                                Created = DateTime.Now,
                                                FormElementOptions = new List<FormElementOption>()
                                                {
                                                    new FormElementOption()
                                                    {
                                                        Value="endometrioid",
                                                        Label="Endometrioid",
                                                        Group="epithelial",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="MMMT",
                                                        Label="MMMT",
                                                        Group="epithelial",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="squamous",
                                                        Label="Squamous",
                                                        Group="epithelial",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="mixed",
                                                        Label="Mixed",
                                                        Group="epithelial",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="USC",
                                                        Label="USC",
                                                        Group="epithelial",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="clearcell",
                                                        Label="Clear Cell",
                                                        Group="epithelial",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="LMS",
                                                        Label="LMS",
                                                        Group="sarcoma",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="ESS",
                                                        Label="ESS",
                                                        Group="sarcoma",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="MMMT",
                                                        Label="MMMT",
                                                        Group="sarcoma",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="Neuroendocrine",
                                                        Label="Neuroendocrine",
                                                        Group="other",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value="NOS",
                                                        Label="NOS",
                                                        Group="other",
                                                        Created = DateTime.Now,
                                                        ChildFormElementId = null,
                                                        ChildFormElements = new List<ChildFormElement>()
                                                            {}
                                                    }
                                                                       
                                                }//end formelement options
                                            },
                                        new ChildFormElement()
                                            {
                                                Title="Type of Trial",
                                                FormId = "typeoftrial",
                                                Type="select",
                                                Placeholder="Select a Type of Trial",
                                                IconClass="crosshairs",
                                                Created = DateTime.Now,
                                                FormElementOptions = new List<FormElementOption>()
                                                {
                                                    new FormElementOption()
                                                    {
                                                        Value = "primarytreatment",
                                                        Label = "Primary Treatment",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                Title="Measurable Disease",
                                                                FormId = "measurabledisease",
                                                                Type="select",
                                                                Placeholder="Does the patient have a measurable disease?",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "yes",
                                                                        Label = "Yes",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "no",
                                                                        Label = "No",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "unknown",
                                                                        Label = "Unknown",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "skipcriteria",
                                                                        Label = "Skip This Criteria",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            }
                                                        }//end childformelements
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "primarymaintenance",
                                                        Label = "Primary Maintenance",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                Title="Has Measurable Diseas",
                                                                FormId = "measurabledisease",
                                                                Type="select",
                                                                Placeholder="Select an option",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "yes",
                                                                        Label = "Yes",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "no",
                                                                        Label = "No",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "unknown",
                                                                        Label = "Unknown",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "skip",
                                                                        Label = "Skip This Criteria",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "recurrence",
                                                        Label = "Recurrence",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                Title="Has Measurable Disease",
                                                                FormId = "measurabledisease",
                                                                Type="select",
                                                                Placeholder="Select an option",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "yes",
                                                                        Label = "Yes",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "no",
                                                                        Label = "No",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "unknown",
                                                                        Label = "Unknown",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "skip",
                                                                        Label = "Skip This Criteria",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                Title="Number of Prior Therapies for Recurrence",
                                                                FormId = "numberOfPriorTherapiesForRecurrence",
                                                                Type="select",
                                                                Placeholder="Select an number",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                {
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "0",
                                                                        Label = "0",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "1",
                                                                        Label = "1",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "2",
                                                                        Label = "2",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    },
                                                                    new FormElementOption()
                                                                    {
                                                                        Value = "3plus",
                                                                        Label = "3+",
                                                                        Group = null,
                                                                        Created = DateTime.Now,
                                                                        ChildFormElements  =  null
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "recurrencemaintenance",
                                                        Label = "Recurrence Maintenance",
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "numberofpriortherapies",
                                                                Title = "Number of Prior Therapies for Recurrence",
                                                                Type = "select",
                                                                Placeholder = "Select a Number of Therapies",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                        new FormElementOption()
                                                                        {
                                                                            Value = "0",
                                                                            Label = "0",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        },
                                                                        new FormElementOption()
                                                                        {
                                                                            Value = "1",
                                                                            Label = "1",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        },
                                                                        new FormElementOption()
                                                                        {
                                                                            Value = "2",
                                                                            Label = "2",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        },
                                                                        new FormElementOption()
                                                                        {
                                                                            Value = "3plus",
                                                                            Label = "3+",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        }
                                                                    }//end formelementoptions
                                                            }//end childformelement
                                                        }//end childformelements
                                                    },//end formelementoption
                                                 }//FormElementOptions
                                                },//ChildformElement
                                    
                                        
                                        new ChildFormElement()
                                            {
                                                FormId= "stageofdisease", 
                                                Title="Stage of Disease", 
                                                Type= "select", 
                                                Placeholder= "Select a Disease Site", 
                                                IconClass= "crosshairs",
                                                Created = DateTime.Now,
                                                FormElementOptions = new List<FormElementOption>()
                                                {
                                                    new FormElementOption()
                                                    {
                                                        Value = "I",
                                                        Label = "I",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "II",
                                                        Label = "II",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "III",
                                                        Label = "III",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  null
                                                    },
                                                    new FormElementOption()
                                                    {
                                                        Value = "IV",
                                                        Label = "IV",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  null
                                                    }
                                        }//FormElementOptions
                                    }//end child form element
                                    },//ChildformElements
                                    //begin protocols responses
                                    Protocols = new List<Protocol>()
                                    {
                                        new Protocol()
                                        {
                                            ProtocolId = "foo3", 
                                            NCTNum_1 = "foo", 
                                            ptitle = "foo", 
                                            display4 = "foo", 
                                            display2 = "foo", 
                                            display6 = "foo", 
                                            protocol_desc = "foo", 
                                            disease = "foo", phase = "foo", 
                                            agents = "foo", location = "foo", 
                                            l_stay = "foo", sponsor = "foo", 
                                            retrn_visit = "foo", 
                                            home_care = "foo", 
                                            ch_name = "foo", 
                                            ch_dept = "foo", 
                                            ch_phone = "foo", 
                                            refer_phone = "foo", 
                                            ProtObj = "foo", 
                                            ProtObjText = "foo", 
                                            regDate = "foo", 
                                            irbappDate = "foo", 
                                            NCIStudyType = "foo", 
                                            RecruitStat = "foo", 
                                            ProjAccrual = "foo", 
                                            inclusion = "foo", 
                                            exclusion = "foo", 
                                            NCTNum = "foo", 
                                            Link = "foo", 
                                            LinkText = "foo", 
                                            Results = "foo", 
                                            ResultsText = "foo", 
                                            testField = "foo"
                                        },
                                        new Protocol()
                                        {
                                            ProtocolId = "foo4", 
                                            NCTNum_1 = "foo", 
                                            ptitle = "foo", 
                                            display4 = "foo", 
                                            display2 = "foo", 
                                            display6 = "foo", 
                                            protocol_desc = "foo", 
                                            disease = "foo", phase = "foo", 
                                            agents = "foo", location = "foo", 
                                            l_stay = "foo", sponsor = "foo", 
                                            retrn_visit = "foo", 
                                            home_care = "foo", 
                                            ch_name = "foo", 
                                            ch_dept = "foo", 
                                            ch_phone = "foo", 
                                            refer_phone = "foo", 
                                            ProtObj = "foo", 
                                            ProtObjText = "foo", 
                                            regDate = "foo", 
                                            irbappDate = "foo", 
                                            NCIStudyType = "foo", 
                                            RecruitStat = "foo", 
                                            ProjAccrual = "foo", 
                                            inclusion = "foo", 
                                            exclusion = "foo", 
                                            NCTNum = "foo", 
                                            Link = "foo", 
                                            LinkText = "foo", 
                                            Results = "foo", 
                                            ResultsText = "foo", 
                                            testField = "foo"
                                        }
                                    }
                                },//end endometrial option
                                //begin Cervix
                                 new FormElementOption()
                                                    {
                                                        Value = "cervix",
                                                        Label = "Cervix",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "histology",
                                                                Title = "Histology",
                                                                Type = "select",
                                                                Placeholder = "Select a Number of Therapies",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "squammous",
                                                                            Label = "Squammous",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "adeno",
                                                                            Label = "Adeno",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "adenosquamous",
                                                                            Label = "Adenosquamous",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "neuroendocrine",
                                                                            Label = "Cervix",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "smallCell",
                                                                            Label = "Small Cell",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "sarcoma",
                                                                            Label = "Sarcoma",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "other",
                                                                            Label = "Other",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        }

                                                                    }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "typeoftrial",
                                                                Type="select",
                                                                Placeholder="Select a Type of Trial",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "primarytreatment",
                                                                            Label = "Primary Treatment",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  new List<ChildFormElement>()
                                                                            {
                                                                                new ChildFormElement()
                                                                                {
                                                                                    Title="Measurable Disease",
                                                                                    FormId = "measurabledisease",
                                                                                    Type="select",
                                                                                    Placeholder="Does the patient have a measurable disease?",
                                                                                    IconClass="crosshairs",
                                                                                    Created = DateTime.Now,
                                                                                    FormElementOptions = new List<FormElementOption>()
                                                                                    {
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "yes",
                                                                                            Label = "Yes",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        },
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "no",
                                                                                            Label = "No",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        },
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "unknown",
                                                                                            Label = "Unknown",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        },
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "skipcriteria",
                                                                                            Label = "Skip This Criteria",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "primarymaintenance",
                                                                            Label = "Primary Maintenance",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  new List<ChildFormElement>()
                                                                            {
                                                                                new ChildFormElement()
                                                                                {
                                                                                    Title="Has Measurable Diseas",
                                                                                    FormId = "measurabledisease",
                                                                                    Type="select",
                                                                                    Placeholder="Select an option",
                                                                                    IconClass="crosshairs",
                                                                                    Created = DateTime.Now,
                                                                                    FormElementOptions = new List<FormElementOption>()
                                                                                    {
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "yes",
                                                                                            Label = "Yes",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        },
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "no",
                                                                                            Label = "No",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        },
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "unknown",
                                                                                            Label = "Unknown",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        },
                                                                                        new FormElementOption()
                                                                                        {
                                                                                            Value = "skip",
                                                                                            Label = "Skip This Criteria",
                                                                                            Group = null,
                                                                                            Created = DateTime.Now,
                                                                                            ChildFormElements  =  null
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "recurrence",
                                                                            Label = "Recurrence",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  new List<ChildFormElement>()
                                                                            {
                                                                                    new ChildFormElement()
                                                                                    {
                                                                                        Title="Has Measurable Disease",
                                                                                        FormId = "measurabledisease",
                                                                                        Type="select",
                                                                                        Placeholder="Select an option",
                                                                                        IconClass="crosshairs",
                                                                                        Created = DateTime.Now,
                                                                                        FormElementOptions = new List<FormElementOption>()
                                                                                        {
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "yes",
                                                                                                Label = "Yes",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "no",
                                                                                                Label = "No",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "unknown",
                                                                                                Label = "Unknown",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "skip",
                                                                                                Label = "Skip This Criteria",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            }
                                                                                        }
                                                                                    },
                                                                                    new ChildFormElement()
                                                                                    {
                                                                                        Title="Number of Prior Therapies for Recurrence",
                                                                                        FormId = "numberOfPriorTherapiesForRecurrence",
                                                                                        Type="select",
                                                                                        Placeholder="Select an number",
                                                                                        IconClass="crosshairs",
                                                                                        Created = DateTime.Now,
                                                                                        FormElementOptions = new List<FormElementOption>()
                                                                                        {
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "0",
                                                                                                Label = "0",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "1",
                                                                                                Label = "1",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "2",
                                                                                                Label = "2",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "3plus",
                                                                                                Label = "3+",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                        
                                                                    },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "recurrenceMaintenance",
                                                                            Label = "Recurrence Maintenance",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  new List<ChildFormElement>()
                                                                            {
                                                                            new ChildFormElement()
                                                                                    {
                                                                                        Title="Has Measurable Disease",
                                                                                        FormId = "measurabledisease",
                                                                                        Type="select",
                                                                                        Placeholder="Select an option",
                                                                                        IconClass="crosshairs",
                                                                                        Created = DateTime.Now,
                                                                                        FormElementOptions = new List<FormElementOption>()
                                                                                        {
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "yes",
                                                                                                Label = "Yes",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "no",
                                                                                                Label = "No",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "unknown",
                                                                                                Label = "Unknown",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "skip",
                                                                                                Label = "Skip This Criteria",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            }
                                                                                        }
                                                                                    },
                                                        
                                                                                        new ChildFormElement()
                                                                                        {
                                                                                            FormId = "numberofpriortherapies",
                                                                                            Title = "Number of Prior Therapies for Recurrence",
                                                                                            Type = "select",
                                                                                            Placeholder = "Select a Number of Therapies",
                                                                                            IconClass="crosshairs",
                                                                                            Created = DateTime.Now,
                                                                                            FormElementOptions = new List<FormElementOption>()
                                                                                                {
                                                                                                    new FormElementOption()
                                                                                                    {
                                                                                                        Value = "0",
                                                                                                        Label = "0",
                                                                                                        Group = null,
                                                                                                        Created = DateTime.Now,
                                                                                                        ChildFormElements  =  null
                                                                                                    },
                                                                                                    new FormElementOption()
                                                                                                    {
                                                                                                        Value = "1",
                                                                                                        Label = "1",
                                                                                                        Group = null,
                                                                                                        Created = DateTime.Now,
                                                                                                        ChildFormElements  =  null
                                                                                                    },
                                                                                                    new FormElementOption()
                                                                                                    {
                                                                                                        Value = "2",
                                                                                                        Label = "2",
                                                                                                        Group = null,
                                                                                                        Created = DateTime.Now,
                                                                                                        ChildFormElements  =  null
                                                                                                    },
                                                                                                    new FormElementOption()
                                                                                                    {
                                                                                                        Value = "3plus",
                                                                                                        Label = "3+",
                                                                                                        Group = null,
                                                                                                        Created = DateTime.Now,
                                                                                                        ChildFormElements  =  null
                                                                                                    }
                                                                                              }//end number of prior therapies options
                                                                                     }//end numberofpriortherapies childform element
                                                                            }
                                                                        },

                                                                    }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "stageOfDisease",
                                                                Title = "Histology",
                                                                Type = "select",
                                                                Placeholder = "Select a Number of Therapies",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "early",
                                                                            Label = "Early",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "advanced",
                                                                            Label = "Advanced",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        }
                                                                    }//end stageofdisease options
                                                            }//end stageofdisease Childformelement
                                                    }

                                },//end cervix
                                new FormElementOption()
                                                    {
                                                        Value = "otherGyn",
                                                        Label = "Other Gyn",
                                                        Group = null,
                                                        Created = DateTime.Now,
                                                        ChildFormElements  =  new List<ChildFormElement>()
                                                        {
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "diseasesite",
                                                                Title = "Disease Site",
                                                                Type = "select",
                                                                Placeholder = "Select a Disease Site",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "vulva",
                                                                            Label = "Vulva",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                         new FormElementOption()
                                                                        {
                                                                            Value = "Vagina",
                                                                            Label = "vagina",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                         new FormElementOption()
                                                                        {
                                                                            Value = "GTD",
                                                                            Label = "GTD",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                         new FormElementOption()
                                                                        {
                                                                            Value = "other",
                                                                            Label = "Other",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                    }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "histology",
                                                                Title = "Histology",
                                                                Type = "select",
                                                                Placeholder = "Select a Number of Therapies",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "squammous",
                                                                            Label = "Squammous",
                                                                            Group = "Epithelial",
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "non-squammous",
                                                                            Label = "Non-Squammous",
                                                                            Group = "Epithelial",
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "Melanoma",
                                                                            Label = "melanoma",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "sarcoma",
                                                                            Label = "Sarcoma",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "other",
                                                                            Label = "Other",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  = null
                                                                        }
                                                                    }
                                                            },
                                                            new ChildFormElement()
                                                            {
                                                                FormId = "typeoftrial",
                                                                Type="select",
                                                                Placeholder="Select a Type of Trial",
                                                                IconClass="crosshairs",
                                                                Created = DateTime.Now,
                                                                FormElementOptions = new List<FormElementOption>()
                                                                    {
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "primarytreatment",
                                                                            Label = "Primary Treatment",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  null
                                                                        },
                                                                     new FormElementOption()
                                                                        {
                                                                            Value = "recurrence",
                                                                            Label = "Recurrence",
                                                                            Group = null,
                                                                            Created = DateTime.Now,
                                                                            ChildFormElements  =  new List<ChildFormElement>()
                                                                            {
                                                                                    new ChildFormElement()
                                                                                    {
                                                                                        Title="Number of Prior Therapies for Recurrence",
                                                                                        FormId = "numberOfPriorTherapiesForRecurrence",
                                                                                        Type="select",
                                                                                        Placeholder="Select an number",
                                                                                        IconClass="crosshairs",
                                                                                        Created = DateTime.Now,
                                                                                        FormElementOptions = new List<FormElementOption>()
                                                                                        {
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "0",
                                                                                                Label = "0",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "1",
                                                                                                Label = "1",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "2",
                                                                                                Label = "2",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            },
                                                                                            new FormElementOption()
                                                                                            {
                                                                                                Value = "3plus",
                                                                                                Label = "3+",
                                                                                                Group = null,
                                                                                                Created = DateTime.Now,
                                                                                                ChildFormElements  =  null
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                        
                                                                    }
                                                                        
                                                                    }
                                                            }
                                                    }

                                }//end other
                        }
                        }
                );

            group.FormElements.Add(
                new FormElement()
                        {
                            Title="BioMarker Driven Trials",
                            FormId = "",
                            Type="select",
                            Placeholder="Select a Genomic Target",
                            IconClass="bug",
                            Created = DateTime.Now,
                            ParentId = group.Id,
                            FormElementOptions = new List<FormElementOption>()
                            {  
                                new FormElementOption()
                                {
                                    Label ="BRCA12",
                                    Created = DateTime.Now,
                                    Value ="BRCA 1/2",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="BRCA2",
                                    Created = DateTime.Now,
                                    Value ="BRCA 2",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="EphA2",
                                    Created = DateTime.Now,
                                    Value ="EphA2",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="Pik3Ca",
                                    Created = DateTime.Now,
                                    Value ="Pik3Ca",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="PTEN",
                                    Created = DateTime.Now,
                                    Value ="PTEN",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="KRAS",
                                    Created = DateTime.Now,
                                    Value ="KRAS",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="BRAF",
                                    Created = DateTime.Now,
                                    Value ="BRAF",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="FGFR",
                                    Created = DateTime.Now,
                                    Value ="FGFR",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="P53",
                                    Created = DateTime.Now,
                                    Value ="P53",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
        
                                {
                                    Label ="WT1",
                                    Created = DateTime.Now,
                                    Value ="WT1",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="ERPRARLH",
                                    Created = DateTime.Now,
                                    Value ="ERPRARLH",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="other",
                                    Created = DateTime.Now,
                                    Value ="other",
                                    ChildFormElements =  null
                                },
                                new FormElementOption()
                                {
                                    Label ="skip",
                                    Created = DateTime.Now,
                                    Value ="Skip this criteria",
                                    ChildFormElements =  null
                                }
                            }
                        }
                );

            context.SaveChanges();

            //Start group 2
            var group2 = new Group()
            {
                Title = "Myeloma",
                Created = DateTime.Now,
                FormElements = new List<FormElement>()
            };
            context.Groups.Add(group2);
            //};


            if (context.Topics.Count() == 0)
            {
                var topic = new Topic()
                {
                    Title = "I love MVC",
                    Created = DateTime.Now,
                    Body = "I love ASP.NET MVC and I want everyone to know it",
                    Replies = new List<Reply>()
          {
            new Reply()
            {
               Body = "I love it too!",
               Created = DateTime.Now
            },
            new Reply()
            {
               Body = "Me too",
               Created = DateTime.Now
            },
            new Reply()
            {
               Body = "Aw shucks",
               Created = DateTime.Now
            },
          }
                };

                context.Topics.Add(topic);

                var anotherTopic = new Topic()
                {
                    Title = "I like Ruby too!",
                    Created = DateTime.Now,
                    Body = "Ruby on Rails is popular"
                };

                context.Topics.Add(anotherTopic);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
#endif
        }
    }
}
