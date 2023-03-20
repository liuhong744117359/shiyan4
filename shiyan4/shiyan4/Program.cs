using Models;
using System;
using System.Collections.Generic;

namespace shiyan4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDbContext testDbContext = new TestDbContext("Server =LAPTOP-A5JCDVPV; Database = shiyan4; Trusted_Connection = True;");
            testDbContext.Database.EnsureDeleted();
            testDbContext.Database.EnsureCreated();
            Console.WriteLine("创建成功!");
            Company company1 = new Company
            {
                CompanyName="服装公司",
                socialCreditCode="159-966-2775",
                Address="重庆市巴南区",
                LegalPersonName="张三",
                Tel="12345678910",
                CompanyType=2
            };
            Company company2 = new Company
            {
                CompanyName = "食品公司",
                socialCreditCode = "168-976-78953",
                Address = "重庆市大足区",
                Tel = "14725836989",
                CompanyType = 1
            };
            Employee employee1 = new Employee
            {
                CID = "500138199704257845",
                Name="张三",
                Sex="男",
                Tel="14523657895",
                
            };
            //添加公司员工表
            CompanyEmployee companyEmployee1 = new CompanyEmployee
            {
                EmployeeID=209001,
                //CompanyID=company1.Id,
                company=company1,
                employee=employee1
            };
            //添加投资人
            Investors investors1 = new Investors
            {
                InvestorsName = "李四",
                Address = "重庆",
                Tel = "15768954569"
            };
            Investors investors2 = new Investors
            {
                InvestorsName = "重庆工程",
                Address = "重庆巴南",
                Tel = "15768954569"
            };
            Project project1 = new Project
            {
                Name="项目一",
                employee = employee1,
                company = company2
            };
            Project project2 = new Project
            {
                Name = "项目二",
                employee = employee1,
                company = company1
            };
            Investors_Project investors_Project1 = new Investors_Project
            {
                investors=investors1,
                project=project1
            };
            Investors_Project investors_Project2 = new Investors_Project
            {
                investors = investors2,
                project = project1
            };
            Investors_Project investors_Project3 = new Investors_Project
            {
                investors = investors1,
                project = project2
            };
            testDbContext.AddRange(company1,company2,employee1,companyEmployee1, investors1, investors2, project1, investors_Project1, investors_Project2, investors_Project3);
            testDbContext.SaveChanges();
            Console.WriteLine("添加成功!");
        }
      
    }
}
