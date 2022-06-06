using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models {
    public class Master {
        public int MasterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int ZipCode { get; set; }
        public int CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyAddress3 { get; set; }
        public int CompanyZipCode { get; set; }
        public DateTime DateOfLastSalary { get; set; }
        public int TotalSalary { get; set; }
        public double CPFContribution { get; set; }
        public double NetSalary { get; set; }

        public Master() { }
    }
}
