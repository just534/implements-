using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ite
{
    public abstract class Person
    {
        public int Age { get; set; }
        public String Name { get; set; }

        public abstract void Say();
    
        public virtual void Walk()
        {
            Console.WriteLine("I'm Walkng");
        }
    }
}
