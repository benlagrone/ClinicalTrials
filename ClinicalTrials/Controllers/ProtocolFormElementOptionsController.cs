using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClinicalTrials.Controllers
{
    public class ProtocolFormElementOptionsController : ApiController
    {
         private IClinicalTrialsRepository _repo;

        public ProtocolFormElementOptionssController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ProtocolFormElementOptoin> Get(int formElementId)
        {
            return _repo.GetProtocolFormElementOptionsByGroup(groupId);
        }

    }
}
