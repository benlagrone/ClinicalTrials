using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClinicalTrials.Data;

namespace ClinicalTrials.Controllers
{
    public class TrialsController : Controller
    {
        private IClinicalTrialsRepository _repo;
        private ProtocolsController _apiController;

        public TrialsController(IClinicalTrialsRepository repo) 
        {
            _repo = repo;
            _apiController = new ProtocolsController(repo);
        }

        // GET: Trials
        public ActionResult Index(int protocolId = 0, bool includeFullProtocol = false)
        {
            if (protocolId == 0)
            {
                return RedirectToAction("GetList", new { start = 0, count = 50 });
            }
            else
            {
                IEnumerable<Protocol> pcol = _apiController.Get(protocolId, includeFullProtocol);
                return View(pcol);
            }
        }

        // GET: single trial
        public ActionResult GetDetails(int protocolId = 0)
        {
            IEnumerable<Protocol> pcols = _apiController.Get(protocolId);
            Protocol p = pcols.First();
            return View("Details",p);
        }

        // GET: Trial ids as paginated list
        public ActionResult GetList(int start, int count)
        {
            IEnumerable<Protocol> idList = _apiController.GetList(start, count);
            ViewBag.more = idList.Any();
            ViewBag.next = start + 1;
            ViewBag.count = count;
            return View("View",idList);
        }

    }
}