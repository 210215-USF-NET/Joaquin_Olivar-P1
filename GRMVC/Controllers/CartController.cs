﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRBL;
using GRMVC.Models;
using GRModels;
using Serilog;
using Microsoft.Extensions.Logging;

namespace GRMVC.Controllers
{
    public class CartController : Controller
    {
        private IGRBiz _GRBiz;
        private IMapper _mapper;
        private readonly ILogger<HomeController> _logger;
        public CartController(IGRBiz GRBiz, IMapper mapper, ILogger<HomeController> logger)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: CartController
        [HttpGet]
        public ActionResult Checkout()
        {
            List<CartProduct> cpList = _GRBiz.GetCartProductsByCartID((int)HttpContext.Session.GetInt32("CartID"));
            List<CartCheckoutVM> cpvmList = new List<CartCheckoutVM>();
            foreach (CartProduct cp in cpList)
            {
                Record cpR = _GRBiz.SearchRecordByID(cp.RecID);
                cpvmList.Add(_mapper.cast2CartCheckoutVM(cp, cpR));
            }
            return View(cpvmList);
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


        public ActionResult BuyCart(List<CartCheckoutVM> DaCart)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    List<CartProduct> cpList = _GRBiz.GetCartProductsByCartID((int)HttpContext.Session.GetInt32("CartID"));
                    foreach (CartProduct cp in cpList)
                    {
                        Record cpR = _GRBiz.SearchRecordByID(cp.RecID);
                        DaCart.Add(_mapper.cast2CartCheckoutVM(cp, cpR));
                    }
                     decimal Total = 0;
                     foreach (CartCheckoutVM item in DaCart)
                     {
                         Total+=item.Price;
                     }

                    Order finalorder = _GRBiz.AddOrder((int)HttpContext.Session.GetInt32("CartID"),
                   (int)HttpContext.Session.GetInt32("CustomerID"), Total);
 
                    foreach (CartCheckoutVM item in DaCart)
                    {
                        _GRBiz.AddOrderProduct(finalorder.ID, item.RecID, item.RecQuan);
                        _GRBiz.PurgeCartProduct(_mapper.cast2CartProduct(item));
                    }
                    _logger.LogInformation($"Order purchased: {finalorder.CusID} bought {finalorder.ID} w/ prie {finalorder.TotalCost}");
                    return View("OrderConfirm");
                }
                catch
                {
                    return View();
                }
            }
            return BadRequest("Didn't work");
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
            return RedirectToAction(nameof(Checkout));
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
