using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable();
            a.Add(111, "fhsfkjshfkjs");
            a.Add(222, "hskjhsjhf");
            a.Add(333, "fjhfjdash");
            string b = (string)a["111"];
            Console.WriteLine(b);
           
            
            
            
            foreach (int k in a.Keys)

            {
                Console.WriteLine(k);
                

                
            }
            foreach (string v in a.Values)
            {
               Console.WriteLine(v);
                
            }
            Console.ReadKey();
            
        }
        
    }
}
