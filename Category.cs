using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    abstract class Category
    {
        public int cid;
        public string cname;
        public Category() { }
        //public int Cid { get => cid; set => cid = value; }
        //public string Cname { get => cname; set => cname = value; }

        public Category(int id, string name)
        {
            this.cid = id;
            this.cname = name;
        }


    }
   
}
