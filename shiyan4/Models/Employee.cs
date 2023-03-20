using System;
using System.Collections.Generic;

namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        /// <summary>
        /// 身份证号
        /// </summary>
        public string CID { get; set; }
       
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }

        public List<CompanyEmployee> employeeManagements { get; set; } = new List<CompanyEmployee>();

        public List<Project> projects { get; set; } = new List<Project>();
       

    }
}
