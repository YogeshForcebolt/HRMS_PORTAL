using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_PORTAL.Models
{
    public class Employee    {
        public int EmpId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpMiddleName { get; set; }
        public string EmpLastName { get; set; }

        public DateTime EmpDob { get; set; }
        public String EmpGender { get; set; }
        public String EmpEmail { get; set; }
        public Double EmpMobileNumbers { get; set; }
        public int EmpMobileNumber { get; set; }
        public String EmpAddress { get; set; }
        public String EmpCity { get; set; }
        public String EmpState { get; set; }
        public int EmpPinCode { get; set; }
        public int EmpDesignation { get; set; }

        public Double EmpAadharCardNumber { get; set; }
        public String  EmpPanCardNumber { get; set; }
    }
}
