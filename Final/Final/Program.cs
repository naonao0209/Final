using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Threading;


namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {

            
                WebClient client = new WebClient();
                string result = client.DownloadString("http://www.json-generator.com/api/json/get/bPCtVMPmNu?indent=0");
                Student[] test = JsonConvert.DeserializeObject<Student[]>(result);
            for (int i = 0; i < test.Length; i += 1)
            {
                test[i].Greeting();
            }
            Console.ReadLine();
            
        }
    }
}
