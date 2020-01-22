using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.model
{
    public class Employr:Interface
    {
       private  List<Employ> emp;
        public Employr()
        {
            emp = new List<Employ>() { new Employ ( 1, "dsfk","dsfgdsg@gmail.com","csf"),
            new Employ ( 2, "dsfk","dsfgdsg@gmail.com","csa"),
            new Employ ( 3, "dsfk","dsfgdsg@gmail.com","csd")};
        }
        public Employ GetEmploy(int id)
        {
            Employ e = emp.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

            return e;

        }
        public List<Employ> DisplayDetails()
        {
            return emp;
        }
    }
}
