using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final
{
    public class Student : Person, IUpdatable
    {
        public Dictionary<string, bool> Skillset { get; set; }
        public string Program { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Update_Date { get; set; }

        public override void Greeting()
        {
            Console.WriteLine("************************************");
            base.Greeting();
            StringBuilder sb = new StringBuilder();
            sb.Append($"I have started {Program} at {Start_Date} in ITD Canada\n");
            sb.Append($"I am able to develop code in the following programming languages\n");
            Console.WriteLine(sb.ToString());

            foreach (KeyValuePair<string, bool> skill in Skillset)//check if true or false
            {
                if (skill.Value)
                {
                    Console.WriteLine($"{skill.Key} ");
                }
                else
                {
                }
            }




        }




    }
}

