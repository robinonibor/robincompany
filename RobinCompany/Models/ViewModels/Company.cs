using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobinCompany.Models
{
    [MetadataType(typeof(CompanyEntity))]
    public partial class Company
    {
    }

    public class CompanyEntity
    {
        [Required (AllowEmptyStrings = false, ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Company ABN/CAN is required")]
        public string CompanyABNCAN { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Company Website is required")]
        public string CompanyWebsite { get; set; }
    }
}