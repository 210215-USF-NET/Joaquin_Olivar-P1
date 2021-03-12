using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRBL;
using GRMVC.Models;

namespace GRMVC.Controllers
{
    public class RecordController : Controller
    {
        private IGRBiz _GRBiz;
        private IMapper _mapper;
        public RecordController (IGRBiz GRBiz, IMapper mapper)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
        }
        // GET: RecordController
        //Thursday lecture, around 1:20:00, actions discussion
        public ActionResult Index()
        {
            return View(_GRBiz.GetRecords().Select(record => _mapper.cast2RecordIndexVM(record)).ToList());
        }

        // GET: RecordController/Details/5
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2RecordCRVM(_GRBiz.SearchRecordByName(name)));
        }

        // GET: RecordController/Create
        public ActionResult Create()
        {
            return View("AddRecord");
        }

        // POST: RecordController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecordCRVM newRecord)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _GRBiz.AddRecord(_mapper.cast2Record(newRecord));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: RecordController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecordController/Edit/5
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

        // GET: RecordController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecordController/Delete/5
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
