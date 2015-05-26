using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClinicalTrials.Data;

namespace ClinicalTrials.Controllers
{
    public class FormElementsController : ApiController
    {

        private IClinicalTrialsRepository _repo;
        public FormElementsController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<FormElement> Get(int groupId)
        {
            return _repo.GetFormElementsByGroup(groupId);
        }

        public HttpResponseMessage Post(int groupId, [FromBody]FormElement newFormElement)
        {
            if (newFormElement.Created == default(DateTime))
            {
                newFormElement.Created = DateTime.UtcNow;
            }

            newFormElement.GroupId = groupId;

            if (_repo.AddFormElement(newFormElement) && _repo.Save())
            {
                return Request.CreateResponse(HttpStatusCode.Created, newFormElement);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
