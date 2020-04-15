using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.BusinessContracts
{
    public interface IAddress
    {
        [Required(ErrorMessage = "addressLine1 is required")]
        string addressLine1 { get; set; }
        string addressLine2 { get; set; }
        string state { get; set; }
        [Required(ErrorMessage = "zip is required")]
        string zip { get; set; }
        [Required(ErrorMessage = "city is required")]
        string city { get; set; }

    }
}
