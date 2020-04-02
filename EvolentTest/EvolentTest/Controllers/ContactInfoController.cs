using EvolentTest.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolentTest.Controllers
{
    public class ContactInfoController : Controller
    {
        IcontactRepository repository;
        public ContactInfoController() {
            repository = new ContactRepository();
        }
        public ActionResult Index()
        {           
           IEnumerable<ContactInfo> lstContact = repository.GetContactInfos();
            return View(lstContact);
        }

        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public JsonResult Create(ContactInfo contactInfo)
        {     
          contactInfo.Status = true;
           var NewContact=  repository.Add(contactInfo);
            return Json(true);
        }
        [HttpGet]
        public ActionResult EditContact(int ContactId)
        {
             
            var ContactDetails= repository.GetById(ContactId);
            return View(ContactDetails);
        }
        [HttpPost]
        public ActionResult UpdateContact(ContactInfo contact)
        {
            repository.UpdateContactInfo(contact);
            return Json(true);
        }


        [HttpGet]
        public JsonResult InActivatedContact(int ContactId)
        {
            repository.InActivatedContact(ContactId);
            return Json(true,JsonRequestBehavior.AllowGet);
        }
    }
}