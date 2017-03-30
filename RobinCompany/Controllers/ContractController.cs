using RobinCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobinCompany.Controllers
{
    public class ContractController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetContracts()
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var contracts = rc.Contracts.OrderBy(x => x.ContractType).ToList();
                return Json(new { data = contracts }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Save(long Id)
        {
            using (RobinCompanyEntities rc = new RobinCompanyEntities())
            {
                var contract = rc.Contracts.Where(x => x.ContractId == Id).FirstOrDefault();
                return View(contract);
            }
        }

        [HttpPost]
        public ActionResult Save(Contract contract)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (RobinCompanyEntities usp = new RobinCompanyEntities())
                {
                    if (contract.ContractId > 0)
                    {
                        try
                        {
                            var update = usp.uspUpdateContract(contract.ContractId, contract.ContractType, contract.ContractSignedDate, contract.ContractEndDate, contract.ContractRenewalDate, contract.ContractPrice);
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
                            var insert = usp.uspInsertContract(contract.ContractType, contract.ContractSignedDate, contract.ContractEndDate, contract.ContractRenewalDate, contract.ContractPrice);
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
                var contract = rc.Contracts.Where(x => x.ContractId == Id).FirstOrDefault();
                if (contract != null)
                {
                    return View(contract);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }

        [HttpPost]
        public ActionResult Delete(Contract contract)
        {
            bool status = false;
            using (RobinCompanyEntities usp = new RobinCompanyEntities())
            {
                try
                {
                    var delete = usp.uspDeleteContract(contract.ContractId);
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