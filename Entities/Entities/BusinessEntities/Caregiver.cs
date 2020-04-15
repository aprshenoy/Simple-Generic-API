using System;
using System.Collections.Generic;
using System.Text;
using Entities.BusinessContracts;

namespace Entities.BusinessEntities
{
  public class Caregiver
    {
        public IPersonalInfo  personalInfo {get;set;}
        public string discipline { get; set; }
        public string ssn { get; set; }
        public string payroll { get; set; }
        public string pager { get; set; }
        public string emergencyContact { get; set; }
        public string region { get; set; }
        public string comments { get; set; }
    }
}
