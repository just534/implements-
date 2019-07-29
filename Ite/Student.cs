using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ite
{
    public class Student : Person
    {
        public Student()
        {

        }
        public Student(int age,string name)
        {
            base.Age = age;
            base.Name = name;
        }
        public override void Say()
        {
            Console.WriteLine($"你好，这是学生{Name}的Say覆写方法");
        }
        public override void Walk()
        {
            base.Walk();
            Console.WriteLine($"你好，这是学生{Name}的Walk virtual 的覆写方法");
        }
    }

}
