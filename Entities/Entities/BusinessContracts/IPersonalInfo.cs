using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.BusinessContracts
{
    public interface IPersonalInfo
    {
        [Required(ErrorMessage = "lastName is required")]
        string lastName { get; set; }
        [Required(ErrorMessage = "firstName is required")]

        string firstName { get; set; }
        string middleName { get; set; }
        string suffix { get; set; }
        string dateofbirth { get; set; }
        [Required(ErrorMessage = "sex is required")]
        string sex { get; set; }

        IAddress address { get; set; }
        IContact contact { get; set; }

    }
}
