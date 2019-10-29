using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            string answer;
            int A =0, B=100; 
            int count =1;
            while(B > A + 1 )
            {
                int c = (A + B) / 2;
                Console.Write("Q{0} : Is your number less than or equal to {1}?", count, c);
                 answer = Console.ReadLine();
                if (answer == "Y")
                    B = c;
                if (answer == "N")
                    A = c +1;
                count++;
            }
            Console.Write("Is your number{0}?", A);
                 answer = Console.ReadLine();
            if(answer =="Y")
                Console.WriteLine("Your number is {0}",A);
            if(answer =="N")
                Console.WriteLine("Your number is {0}",B);

        }
    }
}
