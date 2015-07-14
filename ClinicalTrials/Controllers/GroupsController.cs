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
    public class GroupsController : ApiController
    {
        
        private IClinicalTrialsRepository _repo;

        public GroupsController(IClinicalTrialsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Group> Get(int groupId, bool includeFormElements = false)
        {
            IQueryable<Group> results;

            if (groupId < 1)
            {
                if (includeFormElements == true)
                {
                    results = _repo.GetGroupsIncludingFormElements();
                }
                else
                {
                    results = _repo.GetGroups();
                }

                var groups = results.OrderByDescending(t => t.Created)
                    .Take(25)
                    .ToList();

                return groups;
            }
            else 
            {
                if (includeFormElements == true)
                {
                    results = _repo.GetGroupsIncludingFormElements();
                }
                else
                {
                    results = _repo.GetGroups();
                }


                var groups = results.Where(t => t.Id == groupId);

                return groups;
            }
            }

        public IEnumerable<Group> GetGroupByName(string groupName, bool includeFormElements = false)
        {
            IQueryable<Group> results;

            //if (includeFormElements == true)
            //{
                results = _repo.GetGroupsIncludingFormElements();
            //}
            //else
            //{
               // results = _repo.GetGroups();
            //}


            var groups = results.Where(t => t.Title == groupName);

            return groups;
        }

        public HttpResponseMessage Post([FromBody]Group newGroup) 
        {
            if (newGroup.Created == default(DateTime))
            {
                newGroup.Created = DateTime.UtcNow;
            }
            if (_repo.AddGroup(newGroup) && _repo.Save())
            {
                return Request.CreateResponse(HttpStatusCode.Created, newGroup);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

    }
}
