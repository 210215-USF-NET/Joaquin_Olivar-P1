using GRMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRBL;
using GRModels;

namespace GRMVC.Controllers
{
    public class CustomerController : Controller
    {
        private IGRBiz _GRBiz;
        private IMapper _mapper;
    public CustomerController(IGRBiz GRBiz, IMapper mapper)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
        }
        // GET: CustomerController
        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult Homepage()
        {
            return View("../Home/Index");
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCRVM newCustomer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Customer newCustomerModel = new Customer(); 
                    newCustomerModel = _GRBiz.AddCustomer(_mapper.cast2CustomerCRVM(newCustomer));
                    _GRBiz.newCart(newCustomerModel.ID);
                    return RedirectToAction(nameof(Homepage));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(CustomerCRVM custVM)
        {
            if (ModelState.IsValid)
            {
                Customer customer = _GRBiz.GetCustomerByEmail(custVM.Email);
                if (customer == null)
                {
                    return NotFound();
                }
                HttpContext.Session.SetString("CustomerEmail", customer.Email);
                HttpContext.Session.SetInt32("CustomerID", customer.ID);
                Cart customerCart = _GRBiz.GetCartByCustomer(customer.ID);
                HttpContext.Session.SetInt32("CartID", customerCart.ID);
                return Redirect("/");
            }
            return BadRequest("Invalid model state");
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("CustomerEmail");
            HttpContext.Session.Remove("CustomerID");
            HttpContext.Session.Remove("CartID");
            return Redirect("/");
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
