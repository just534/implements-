using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
namespace Ite
{
   public class Refle
    {
        private static readonly string ObName = ConfigurationManager.AppSettings["Object"];

        public static void test()
        {

            Assembly assembly1 = Assembly.Load("Ite");
            Type[] type = assembly1.GetTypes();
            //foreach (var item in type)
            //{
            //    Console.WriteLine(item.Name+"\t\t"+item);
            //}
            //Console.ReadLine();
            Type TeachType = assembly1.GetType(ObName);
            object obj = Activator.CreateInstance(TeachType, new object[] { 18, "邓缙柯","朗诗"});
            ITeacher tea = (Teacher)obj;
            tea.Teach();
            Console.WriteLine(tea.WriteSomething());
            Console.ReadLine();
        }

    }
}
