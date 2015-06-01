using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClinicalTrials.Data;

namespace ClinicalTrials.Controllers
{
    public class ProtocolFormElementOptionsController : ApiController
    {
         
        private IClinicalTrialsRepository _repo;
        public ProtocolFormElementOptionsController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        //public IEnumerable<ProtocolFormElementOption> Get(int formElementId)
        //{
            //return _repo.GetProtocolFormElementOptionsByFormElementId(formElementId);
        //}

    }
}
