﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExtJsDataGridMvcApp.Models;

namespace ExtJsDataGridMvcApp.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Load()
        {
            var contact = new List<Contact> {
                new Contact("Smith","95746325","smith@me.com", new DateTime(1977,1, 14), false, 2),
                new Contact("Adam","87291034","adam@me.com", new DateTime(1976,8, 14), false, 0),
                new Contact("Eve","98271345","eve@me.com", new DateTime(1975,5, 14), false, 1),
                new Contact("Chun Li","81728312","chun.li@me.com", new DateTime(1979,10, 14), true, 1)
            };
            return Json(new
            {
                total = contact.Count,
                data = contact,
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(List<Contact> data)
        {
            //insert Create code
            return Json(new
            {
                data = new Contact(data[0].Name, data[0].Phone, data[0].Email, data[0].BirthDate, data[0].IsMarried, data[0].NoOfCar),
                success = true,
                message = "Create method called successfully"
            });
        }

        [HttpPost]
        public JsonResult Update(List<Contact> data)
        {
            //insert Update code
            return Json(new
            {
                success = true,
                message = "Update method called successfully"
            });
        }

        [HttpPost]
        public JsonResult Delete(List<string> data)
        {
            //insert Delete code
            return Json(new
            {
                success = true,
                message = "Delete method called successfully"
            });
        }
    }
}
