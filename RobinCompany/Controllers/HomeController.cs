using RobinCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobinCompany.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCompanies()
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var companies = rc.Companies.OrderBy(x => x.CompanyName).ToList();
                return Json(new { data = companies }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Save(long Id)
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var companies = rc.Companies.Where(x => x.CompanyId == Id).FirstOrDefault();
                return View(companies);
            }
        }

        [HttpPost]
        public ActionResult Save(Company company)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (RobinCompanyEntities usp = new RobinCompanyEntities())
                {
                    if (company.CompanyId > 0)
                    {
                        try
                        {
                            var update = usp.uspUpdateCompany(company.CompanyName, company.Description, company.CompanyABNCAN, company.CompanyWebsite, company.CompanyId);
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
                            var insert = usp.uspInsertCompany(company.CompanyName, company.Description, company.CompanyABNCAN, company.CompanyWebsite);
                            status = true;
                        }
                        catch(Exception e)
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
                var company = rc.Companies.Where(x => x.CompanyId == Id).FirstOrDefault();
                if (company != null) {
                    return View(company);
                }
                else {
                    return HttpNotFound();
                }
            }
        }

        [HttpPost]
        public ActionResult Delete(Company company)
        {
            bool status = false;
            using (RobinCompanyEntities usp = new RobinCompanyEntities())
            {
                try
                {
                    var delete = usp.uspDeleteCompany(company.CompanyId);
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