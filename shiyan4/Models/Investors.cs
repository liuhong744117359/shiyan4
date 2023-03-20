using System;
using System.Collections.Generic;

namespace Models
{
    public class Investors
    {
        public int Id { get; set; }
        //投资方的名称（如果为个人则是姓名）
        public string InvestorsName { get; set; }
        //投资方的联系地址
        public string Address { get; set; }
        //电话
        public string Tel { get; set; }

        public List<Investors_Project> investorsProjects { get; set; } = new List<Investors_Project>();
    }
}
