using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ite
{
   public class Teacher:Person,ITeacher
    {
        public Teacher()
        {

        }
        public string SchoolAddress { get; set; }
        public Teacher(int age,string name,string address)
        {
            base.Age = age;
            base.Name = name;
            this.SchoolAddress = address;
        }

        public override void Say()
        {
            Console.WriteLine($"你好，这是老师{Name}的Say覆写方法");
        }
        public override void Walk()
        {
            base.Walk();
            Console.WriteLine($"你好，这是老师{Name}的Walk virtual 的覆写方法");
        }

        public void Teach()
        {
            Console.WriteLine($"你好，我是老师{Name}正在执行接口方法Teach");
        }

        public string WriteSomething()
        {
            return $"你好，我是老师{Name}正在执行接口方法WriteSomething";
        }
    }
}
