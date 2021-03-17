using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using GRModels;
using GRMVC.Models;
using System.Collections.Generic;
using GRBL;
using System.Linq;
using System.Threading.Tasks;

namespace GRMVC.Controllers
{
    public class LocationController : Controller
    {
        private IGRBiz _GRBiz;
        private IMapper _mapper;
        public LocationController(IGRBiz GRBiz, IMapper mapper)
        {
            _GRBiz = GRBiz;
            _mapper = mapper;
        }
        public ActionResult Locations()
        {
            return View();
        }

        // GET: LocationController/Details/5
        public ActionResult LocationsInventory(int localID)
        {
            List<LocationProduct> localproducts = new List<LocationProduct>();
            List<LocationInvCRVM> localinv = new List<LocationInvCRVM>();
            switch (localID)
            {
                case 0:
                    localproducts = _GRBiz.GetLocationProducts(100).ToList();
                    foreach (LocationProduct lp in localproducts)
                    {
                        Record lpR = _GRBiz.SearchRecordByID(lp.RecID);
                        localinv.Add(_mapper.cast2LocationInvCRVM(lp, lpR));
                    }
                    break;
                case 1:
                    localproducts = _GRBiz.GetLocationProducts(200).ToList();
                    foreach (LocationProduct lp in localproducts)
                    {
                        Record lpR = _GRBiz.SearchRecordByID(lp.RecID);
                        localinv.Add(_mapper.cast2LocationInvCRVM(lp, lpR));
                    }
                    break;
            }
            return View(localinv);

        }

        // GET: LocationController/Create
        public ActionResult Add2Philly(int RecID, int RecQuan)
        {
            Location Philly = _GRBiz.GetThisLocation(100);
            _GRBiz.AddLocationProduct(Philly.ID, RecID, RecQuan);
            return View("Locations");
        }
        public ActionResult Add2NYC(int RecID, int RecQuan)
        {
            Location NYC = _GRBiz.GetThisLocation(200);
            _GRBiz.AddLocationProduct(NYC.ID, RecID, RecQuan);
            return View("Locations");
        }
    }
}
       
