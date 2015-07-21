using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ClinicalTrials.Controllers
{
    [EnableCors(origins: "http://gynonc.azurewebsites.net", headers: "*", methods: "*")]
    public class ProtocolsController : ApiController
    {
        private IClinicalTrialsRespository _repo;

        public ProtocolsController(IClinicalTrialsRepository repo) 
        {
            _repo = repo;
        }

        public IEnumerable<Protocol> Get(int protocolId, bool includeFullProtocol = false)
        {
            var results = _repo.GetProtocols();
            var single = results.Where(t => t.Id == protocolId);
            return single;
        }
    }
}
