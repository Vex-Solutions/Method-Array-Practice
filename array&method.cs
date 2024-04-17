using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace learning_1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Introduction();
            ArrayHandler();
            Question();
            Console.WriteLine("what is that squared?\n Well happy u asked its");   
            Console.ReadKey();
        }

        static void ArrayHandler()
        {
            string[] zuonlopj = new string[4];
            Console.WriteLine("what are your users");
            zuonlopj[0] = Console.ReadLine();
            zuonlopj[1] = Console.ReadLine();
            zuonlopj[2] = Console.ReadLine();
            zuonlopj[3] = Console.ReadLine();
            Console.WriteLine("---------------------");
            Array.Sort(zuonlopj);
            for (int i = 0; i < zuonlopj.Length; i++)
            {
                Console.WriteLine(zuonlopj[i]);

            }
        }
        static void Introduction()
        {
            Console.WriteLine("Welcome , Main method is only written by other methods");
            Console.WriteLine("| Envy | C# Practice, Methods & Array");
        }
       public static void Question()
        {
            string divider = ("----------------------");
            Console.WriteLine("wow how many names did u write?");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 4)
            {
                Console.WriteLine("Yes you did write 4 zuonlopj");
            }
            else
            {
                Console.WriteLine("nooo you wrote 4 silly");
            }

            int responsenNumber = response;
           Console.WriteLine(divider);
            Console.WriteLine("would u like to square?|    yes|no");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine(responsenNumber * response);
            }
            else if (answer == "no") 
            {
                Console.WriteLine("wellsd thats mean ):");
            }
            else
            {
         
            Console.WriteLine("answer failure");
                Console.WriteLine("please wait");
                Thread.Sleep(1000);
                Console.Clear();
                Question();
                
            }
        }

        public static void Qeastion2()
        {

        }
    }
}
