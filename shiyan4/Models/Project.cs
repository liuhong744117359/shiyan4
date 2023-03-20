using System;
using System.Collections.Generic;

namespace Models
{
    public class Project
    {
        //项目
        public int ID { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 员工
        /// </summary>
        public int EID { get; set; }
        public Employee employee { get; set; } = new Employee();
      

        //公司ID
        /// <summary>
        /// 公司
        /// </summary>
        public int CompanyID { get; set; }
        public Company company { get; set; }

        public List<Investors_Project> investorsProjects { get; set; } = new List<Investors_Project>();
    }
}
