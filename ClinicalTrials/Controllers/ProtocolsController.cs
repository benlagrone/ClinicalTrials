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
    public class ProtocolsController : ApiController
    {
        private IClinicalTrialsRepository _repo;

        public ProtocolsController(IClinicalTrialsRepository repo) 
        {
            _repo = repo;
        }

        public IEnumerable<Protocol> Get(int protocolId = 0, bool includeFullProtocol = false)
        {
            var results = _repo.GetProtocols();
            if (protocolId!=0){
                var singleProtocols = results.Where(t => t.Id == protocolId);  
                return singleProtocols;  
            } else {
                var allProtocols = results;
                return results;
            }
            
        }
    }
}
