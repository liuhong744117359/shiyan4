using System;
using System.Collections.Generic;

namespace Models
{
    public class Company
    {
        public int Id { get; set; }
        //公司名称
        public string CompanyName { get; set; }
        //统一社会信用代码 unified social credit code
        public string socialCreditCode { get; set; }
        //公司注册地址
        public string Address { get; set; }
        //法定代表人姓名
        public string LegalPersonName { get; set; }     
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 公司类型 1-孵化公司   2-创业公司
        /// </summary>
        public int CompanyType { get; set; }
        public List<CompanyEmployee> employeeManagements { get; set; } = new List<CompanyEmployee>();
        /// <summary>
        /// 一个公司对应多个项目
        /// </summary>
        public List<Project> projects { get; set; }
    }
}
