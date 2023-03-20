using System;
using System.Collections.Generic;

namespace Models
{
    public class IncubationCompany
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
        //联系电话
        public string Tel { get; set; }

        public List<EmployeeManagement> employeeManagements { get; set; } = new List<EmployeeManagement>();
    }
}
