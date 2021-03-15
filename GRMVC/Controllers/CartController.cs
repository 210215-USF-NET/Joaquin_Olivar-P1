using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRBL;
using GRMVC.Models;
using GRModels;

namespace GRMVC.Controllers
{
    public class CartController : Controller
    {
        private IGRBiz _GRBiz;
        private IMapper _mapper;
        public CartController(IGRBiz GRBiz, IMapper mapper)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
        }

        // GET: CartController
        [HttpGet]
        public ActionResult Checkout()
        {
            return View(_GRBiz.GetCartProductsByCartID((int)HttpContext.Session.GetInt32("CartID"))
                .Select(x => _mapper.cast2CartCheckoutVM(x)).ToList());
        }

        // GET: CartController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        
        public ActionResult Add2Cart(int RecID, int Quan, int CartID)
        {
            _GRBiz.AddToCartProducts(RecID, Quan, CartID);
            return Redirect("Checkout");
        }


        public ActionResult BuyCart()
        {
            //Order finalOrder = new Order();
            //OrderProduct orderProductList = new OrderProduct();
            //
            //_GRBiz.AddOrder();

            return View("OrderConfirm");
        }
        public ActionResult OrderConfirm()
        {
            return View();
        }
        // POST: CartController/Create
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
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

        // GET: CartController/Delete/5
        public ActionResult Delete(int ID)
        {
            _GRBiz.PurgeCartProduct(_GRBiz.GetCartProductByID(ID));
            return Redirect("Checkout");
        }

        // POST: CartController/Delete/5
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
