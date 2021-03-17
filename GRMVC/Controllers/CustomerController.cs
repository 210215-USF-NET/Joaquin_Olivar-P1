using GRMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRBL;
using GRModels;
using Serilog;
using Microsoft.Extensions.Logging;

namespace GRMVC.Controllers
{
    public class CustomerController : Controller
    {
        private IGRBiz _GRBiz;
        private IMapper _mapper;
        private readonly ILogger<HomeController> _logger;
        public CustomerController(IGRBiz GRBiz, IMapper mapper, ILogger<HomeController> logger)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
            _logger = logger;
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
                    newCustomerModel = _GRBiz.AddCustomer(_mapper.cast2Customer(newCustomer));
                    _GRBiz.newCart(newCustomerModel.ID);
                    _logger.LogInformation($"New customer: Customer: {newCustomer.FirstName} {newCustomer.LastName} w/ Email: {newCustomer.Email}");
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
        public ActionResult CustomerInfo()
        {
            return View(_mapper.cast2CustomerCRVM(_GRBiz.GetCustomerByEmail(HttpContext.Session.GetString("CustomerEmail"))));
        }
        public ActionResult OrderHistory()
        {
            return View(_GRBiz.GetOrdersByID((int)HttpContext.Session.GetInt32("CustomerID"))
                .Select(x=>_mapper.cast2OrderCRVM(x)).ToList());
        }
        public ActionResult Details(int ID)
        {
            List<OrderProduct> opList = _GRBiz.GetOrderProductsByID(ID);
            List<OrderProductCRVM> opvmList = new List<OrderProductCRVM>();
            foreach (OrderProduct op in opList)
            {
                Record opR = _GRBiz.SearchRecordByID(op.RecID);
                opvmList.Add(_mapper.cast2OrderProductCRVM(op, opR));
            }
            return View(opvmList);
        }
        public ActionResult OrderHistorySorted(int sort)
        {
            List<OrderCRVM> oList = _GRBiz.GetOrdersByID((int)HttpContext.Session.GetInt32("CustomerID"))
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
                    break;
            }
            return View(oList);
        }
    }
}
    
