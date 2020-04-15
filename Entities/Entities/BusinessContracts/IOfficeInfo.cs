using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.BusinessContracts
{
    public interface IOfficeInfo
    {
        IAddress address { get; set; }
        IContact contact { get; set; }
        [Required(ErrorMessage = "addressLine1 is required")]
        string officeNamme { get; set; }
        int officeType { get; set; }

    }
}
