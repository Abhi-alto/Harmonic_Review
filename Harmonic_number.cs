using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic
{
    internal class Harmonic_number
    {
        public int number;                      //class variable
        public Harmonic_number(int number)              //parameterized constructor
        {
            this.number = number;                   //initializing the value
        }
        public double getHarmonic()                 //function to get harmonic value for a number
        {
            double sum_harmonic = 0.0;                  //for the sum of harmonic value after each iteration
            for(int i = 1; i <= this.number; i++)       //for each value till the number enteerd
            {
                if(i< number)
                Console.Write("1/"+i+"+");
                else
                    Console.WriteLine("1/"+i);
                sum_harmonic = sum_harmonic + (1.0 / i);                
            }
            Console.WriteLine("Harmonic value =" + sum_harmonic);
            return sum_harmonic;
        }
    }
}
