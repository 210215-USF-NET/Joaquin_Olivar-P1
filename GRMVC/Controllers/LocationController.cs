using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using GRModels;
using GRMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRMVC.Controllers
{
    public class LocationController : Controller
    {
        // GET: LocationController
        public ActionResult Locations()
        {
            return View();
        }

        // GET: LocationController/Details/5
        public ActionResult LocationsInventory(int localID)
        {
            List<LocationInvCRVM> localinv = new List<LocationInvCRVM>();
           /* List<OrderCRVM> oList = _GRBiz.GetOrdersByID((int)HttpContext.Session.GetInt32("CustomerID"))
                    .Select(x => _mapper.cast2OrderCRVM(x)).ToList();
             switch (sort)
             {
                 case 0:
                     oList = oList.OrderBy(x => x.TotalCost).ToList();
                     break;
                 case 1:
                     oList = oList.OrderBy(x => x.TotalCost).ToList();
                     oList.Reverse();
                     break;
                 case 2:
                     oList = oList.OrderBy(x => x.OrDate).ToList();
                     break;
                 case 3:
                     oList = oList.OrderBy(x => x.OrDate).ToList();
                     oList.Reverse();
                     break; */
            return View(localinv);
           
        }

        // GET: LocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
