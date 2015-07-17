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
    public class ChildFormElementController : ApiController
    {

        private IClinicalTrialsRepository _repo;

        public ChildFormElementController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ChildFormElement> Get(int formElementOptionId)
        {
            var results = _repo.GetFormElements();
            var groups = results.Where(t => t.FormElementOptionId == formElementOptionId);
            return groups;
        }
    }
}
