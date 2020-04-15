using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.BusinessContracts
{
   public interface IContact
    {
        string email { get; set; }
        [Required(ErrorMessage = "Cellphone is required")]
        string cellPhone { get; set; }
        string otherPhone { get; set; }
        [Required(ErrorMessage = "Contact name is required")]
        string contactName { get; set; }
        string contactNumber { get; set; }
    }
}
