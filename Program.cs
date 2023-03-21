using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[10];

            Random random = new Random();

            bool isOpen = true;
            int sortingNumbers = 0;
            int lengthNumber = 1;
            int minNumber = 0;
            int maxNumber = 20;

            for ( int i = 0; i < arrayNumbers.Length; i++ )
            {
                arrayNumbers[i] = random.Next(minNumber,maxNumber + 1);
                Console.Write(arrayNumbers[i] + " ");
            }

            Console.WriteLine();

            while ( isOpen )
            {
                for ( int i = 0; i < arrayNumbers.Length - lengthNumber; i++ )
                {
                   
                    if (arrayNumbers[i] > arrayNumbers[i + lengthNumber] )
                    {
                        int tempNumber = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[i + lengthNumber];
                        arrayNumbers[i + lengthNumber] = tempNumber;
                        sortingNumbers++;
                    }
                }

                if ( sortingNumbers == 0 )
                {
                    isOpen= false;
                }

                sortingNumbers = 0;
            }

            foreach (int number in arrayNumbers )
            {
                Console.Write(number + " ");
            }
   
        }
    }
}
