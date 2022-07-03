using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
  
    // Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence,
    // which is the number of times you must multiply the digits in num until you reach a single digit.

    // For example(Input --> Output):

    //Напишите функцию persistence, которая принимает положительный параметр num и возвращает его мультипликативную устойчивость,
     // это количество раз, которое вы должны умножить цифры в num, пока не получите одну цифру.

    //Например (Ввод --> Вывод):
    //
    //39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
    //999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
    //4 --> 0 (because 4 is already a one-digit number)
    

    public class Persist
    {
        public static int Persistence(long n)
        {
            int count = 0;
            long paket = 1;

            if (n / 10 == 0) return 0;

            while (true)
            {
                while (n != 0)
                {
                    paket *= n % 10;
                    n /= 10;

                }
                count++;

                if (paket / 10 == 0) return count;
                else
                {
                    n = paket;
                    paket = 1;
                }
            }
        }

        //public static int Persistence(long n)
        //{
        //    int count = 0;
        //    while (n > 9)
        //    {
        //        count++;
        //        n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
        //    }
        //    return count;
        //}
    }
}
