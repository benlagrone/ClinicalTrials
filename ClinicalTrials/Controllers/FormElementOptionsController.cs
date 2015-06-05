using System;
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

        public IEnumerable<FormElementOption> Get(int FormElementId)
        {
            IQueryable<FormElementOption> results;
            results = _repo.GetFormElementOptions();
            var options = results.Where(t=>t.FormElementId == FormElementId);
            return options;
        }
    }
}
