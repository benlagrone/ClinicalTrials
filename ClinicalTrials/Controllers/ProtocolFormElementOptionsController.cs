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
    public class ProtocolFormElementOptionsController : ApiController
    {
         
        private IClinicalTrialsRepository _repo;

        public ProtocolFormElementOptionsController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ProtocolFormElementOption> Get(int formElementOptionId)
        {
            var results = _repo.GetProtocolFormElementOptions();
            var groups = results.Where(t => t.FormElementOption_Id == formElementOptionId);
            return groups;
        }

    }
}
