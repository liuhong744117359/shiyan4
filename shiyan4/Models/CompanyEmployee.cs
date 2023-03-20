using System;
using System.Collections.Generic;

namespace Models
{
    public class CompanyEmployee
    {
        
        public int ID { get; set; }
        //
        /// <summary>
        /// 工号
        /// </summary>
        public int EmployeeID { get; set; }
        /*  //孵化公司ID
          public int ICompanyID { get; set; }
          public IncubationCompany incubationCompany { get; set; } = new IncubationCompany();*/

        //
        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyID { get; set; }
        public Company company { get; set; } = new Company();
        //
        /// <summary>
        /// 员工ID
        /// </summary>
        public int EID { get; set; }
        public Employee employee { get; set; } = new Employee();

        //public List<Project> projects { get; set; } = new List<Project>();
    }
}
