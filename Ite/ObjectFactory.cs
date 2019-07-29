using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Ite
{
    
    class ObjectFactory
    {
        private static readonly string ObName = ConfigurationManager.AppSettings["Object"];
        public static Person OFat()
        {
            switch (ObName)
            {
                case "Teacher":
                    return new Teacher(18, "张老师","北市场");
                case "Student":
                    return new Student(18, "邓缙柯");
                default:
                    return null;
            }

        }
    }
}
