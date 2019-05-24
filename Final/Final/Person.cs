using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public abstract class Person
    {
       public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public virtual void Greeting() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hello I am {Name} {Last_Name}\n");
            sb.Append($"My Email is {Email}\n");
            Console.WriteLine(sb.ToString());
        }
    }
}
