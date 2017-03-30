using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobinCompany.Models
{
    [MetadataType(typeof(ContractEntity))]
    public partial class Contract
    {
    }

    public class ContractEntity
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Type is required")]
        public string ContractType { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is required")]
        public string ContractPrice { get; set; }
    }
}