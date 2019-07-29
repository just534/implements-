using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ite
{
    class Program
    {
        static void Main(string[] args)
        {
            ITeacher itech = (Teacher)ObjectFactory.OFat();
            Person person1= (Teacher)ObjectFactory.OFat();
            itech.Teach();
            Console.WriteLine(itech.WriteSomething());
            Console.WriteLine("-------------------------------------------------------------------------");
            person1.Say();
            person1.Walk();
            Console.ReadLine();
        }
    }
}
