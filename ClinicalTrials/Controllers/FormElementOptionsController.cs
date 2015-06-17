﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClinicalTrials.Data;
using System.Web.Http.Cors;

namespace ClinicalTrials.Controllers
{
    [EnableCors(origins: "http://gynonc.azurewebsites.net", headers: "*", methods: "*")]
    public class FormElementOptionsController : ApiController
    {
        
        private IClinicalTrialsRepository _repo;

        public FormElementOptionsController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        //not finding action
        [ActionName("GetOptions")]
        public IEnumerable<FormElementOption> GetOptions(int formElementId)
        {
            return _repo.GetFormElementOptionsByFormElementId(formElementId);
        }
    }
}
