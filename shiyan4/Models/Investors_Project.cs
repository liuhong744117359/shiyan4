using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Investors_Project
    {
        public int ID { get; set; }

        /// <summary>
        /// 投资人ID
        /// </summary>
        public int IID { get; set; }
        public Investors investors { get; set; } = new Investors();
        /// <summary>
        /// 项目ID
        /// </summary>
        public int PID { get; set; }
        public Project project { get; set; } = new Project();
    }
}
