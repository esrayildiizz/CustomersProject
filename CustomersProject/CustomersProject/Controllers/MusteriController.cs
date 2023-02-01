
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersProject.Controllers
{
    public class MusteriController : Controller
    {
        private CustomerProjectEntities1 _db = new CustomerProjectEntities1();

        [HttpGet]
        public ActionResult Index()
        {
            var listele = _db.Musteris.ToList();
            return View(listele);
        }
        [HttpGet]
        public JsonResult FaturaListele(int id)  //
        {
            var faturalistele = _db.sp_fatura_tarih(id).FirstOrDefault();
            return new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = faturalistele };

        }



    }
}