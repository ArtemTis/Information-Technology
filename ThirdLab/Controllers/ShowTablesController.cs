using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdLab.Models;

namespace ThirdLab.Controllers
{
    public class ShowTablesController : Controller
    {
        TradingCompanyAll tca = new TradingCompanyAll();
        public ActionResult CustomersTable()
        {
            return View(tca.AllCustomers);
        }
        public ActionResult OrderTable()
        {
            return View(tca.AllOrders);
        }
        protected override void Dispose(bool disposing)
        {
            tca.Dispose();
            base.Dispose(disposing);

        }
        [HttpGet]
        public ActionResult createStringCustomers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult createStringCustomers(Customers cust)
        {
            tca.Entry(cust).State = EntityState.Added;
            tca.SaveChanges();
            return RedirectToAction("createStringCustomers");
        }
        [HttpGet]
        public ActionResult createStringOrders()
        {
            return View();
        }
        [HttpPost]
        public ActionResult createStringOrders(Orders order)
        {
            tca.Entry(order).State = EntityState.Added;
            tca.SaveChanges();
            return RedirectToAction("createStringOrders");
        }
        [HttpGet]
        public ActionResult deleteCustomerString(int id)
        {
            Customers cust = tca.AllCustomers.Find(id);
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }
        [HttpPost, ActionName("deleteCustomerString")]
        public ActionResult deleteConfirmedCustomer(int id)
        {
            Customers cust = tca.AllCustomers.Find(id);
            if (cust == null)
            {
                return HttpNotFound();
            }
            tca.AllCustomers.Remove(cust);
            tca.SaveChanges();
            return RedirectToAction("deleteCustomerString");
        }

        [HttpGet]
        public ActionResult deleteOrderString(int id)
        {
            Orders order = tca.AllOrders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }
        [HttpPost, ActionName("deleteOrderString")]
        public ActionResult deleteConfirmedOrder(int id)
        {
            Orders order = tca.AllOrders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            tca.AllOrders.Remove(order);
            tca.SaveChanges();
            return RedirectToAction("deleteOrderString");
        }


        [HttpGet]
        public ActionResult updateCustomerString(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Customers cust = tca.AllCustomers.Find(id);
            if (cust != null)
            {
                return View(cust);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult updateCustomerString(Customers cust)
        {
            tca.Entry(cust).State = EntityState.Modified;
            tca.SaveChanges();
            return RedirectToAction("updateCustomerString");
        }


        [HttpGet]
        public ActionResult updateOrderString(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Orders order = tca.AllOrders.Find(id);
            if (order != null)
            {
                return View(order);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult updateOrderString(Orders order)
        {
            tca.Entry(order).State = EntityState.Modified;
            tca.SaveChanges();
            return RedirectToAction("updateOrderString");
        }

        //////////
        [HttpGet]
        public ActionResult redirectCustomerUpdate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult redirectCustomerUpdate(string inputName)
        {
            return RedirectToAction("updateCustomerString/"+inputName);
        }
        [HttpGet]
        public ActionResult redirectOrderUpdate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult redirectOrderUpdate(string inputName)
        {
            return RedirectToAction("updateOrderString/" + inputName);
        }
        [HttpGet]
        public ActionResult redirectCustomerDelete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult redirectCustomerDelete(string inputName)
        {
            return RedirectToAction("deleteCustomerString/" + inputName);
        }
        [HttpGet]
        public ActionResult redirectOrderDelete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult redirectOrderDelete(string inputName)
        {
            return RedirectToAction("deleteOrderString/" + inputName);
        }
    }
}