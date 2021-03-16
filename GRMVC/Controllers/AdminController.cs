using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRModels;
using GRBL;
using GRMVC.Models;
namespace GRMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: ManagerController
        private IGRBiz _GRBiz;
        private IMapper _mapper;
        public AdminController(IGRBiz GRBiz, IMapper mapper)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
        }
        public ActionResult AdminLoginPage()
        {
            return View();
        }

        public ActionResult Login(string Email)
        {
            if (ModelState.IsValid)
            {
                Manager manager = new Manager();
                if (Email == manager.Email)
                {
                    HttpContext.Session.SetString("CustomerEmail", manager.Email);
                    return Redirect("/");
                }
                return NotFound();
            }
            return BadRequest("Invalid model state");
        }
        // GET: ManagerController/Create
        public ActionResult CustomerInformation()
        {
            List<Customer> CustomerList = _GRBiz.GetCustomers();
            List<CustomerCRVM> CustomerCRVMList = new List<CustomerCRVM>();
            foreach (Customer customer in CustomerList)
            {
                CustomerCRVMList.Add(_mapper.cast2CustomerCRVM(customer));
            }
            return View(CustomerCRVMList);
        }

        // POST: ManagerController/Create
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

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManagerController/Edit/5
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

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManagerController/Delete/5
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
