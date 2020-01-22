using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.model
{
    public class Employ
    {
        public int Id{get; set;}
            public string Name { get; set; }
        public string Email{ get; set; }
        public string dept { get; set; }

        public Employ(int Id, string Name, string Email, string dept)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.dept = dept;
        }

    }




}
