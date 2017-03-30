using RobinCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobinCompany.Controllers
{
    public class ContactController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetContacts()
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var contacts = rc.Contacts.OrderBy(x => x.ContactFirstName).ToList();
                return Json(new { data = contacts }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Save(long Id)
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var contact = rc.Contacts.Where(x => x.ContactId == Id).FirstOrDefault();
                return View(contact);
            }
        }

        [HttpPost]
        public ActionResult Save(Contact contact)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (RobinCompanyEntities usp = new RobinCompanyEntities())
                {
                    if (contact.ContactId > 0)
                    {
                        try
                        {
                            var update = usp.uspUpdateContacts(contact.ContactId, contact.ContactTitleId, contact.ContactFirstName, contact.ContactLastName,
                                contact.TypeOfContract.ToString(), contact.Email, contact.PhoneNumber, contact.Department, true);
                            status = true;
                        }
                        catch (Exception e)
                        {
                            var a = e;
                            status = false;
                        }
                    }
                    else
                    {
                        try
                        {
                            var insert = usp.uspInsertContact(contact.ContactTitleId, contact.ContactFirstName, contact.ContactLastName, contact.TypeOfContract.ToString(), contact.Email, contact.PhoneNumber, contact.Department, true);
                            status = true;
                        }
                        catch (Exception e)
                        {
                            var a = e;
                            status = false;
                        }
                    }

                }
            }
            return new JsonResult { Data = new { status = status } };
        }

        [HttpGet]
        public ActionResult Delete(long Id)
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var contact = rc.Contacts.Where(x => x.ContactId == Id).FirstOrDefault();
                if (contact != null)
                {
                    return View(contact);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }

        [HttpPost]
        public ActionResult Delete(Contact contact)
        {
            bool status = false;
            using (RobinCompanyEntities usp = new RobinCompanyEntities())
            {
                try
                {
                    var delete = usp.uspDeleteContact(contact.ContactId);
                    status = true;
                }
                catch
                {
                    status = false;
                }
            }

            return new JsonResult { Data = new { status = status } };
        }
    }
}