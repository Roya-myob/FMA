using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void  Main()
        {
            var num =-234;
             //var remainder = num % 10;
            //var quotient = num / 10;
            //var sum= 0;
            var sum = SumOfDigitsRecursive(num);
            Console.WriteLine(sum);
            
           /* while ( num != 0 )
            {
                sum += num % 10;
                num = num / 10;
            }*/
            //return sum;
        }
          public static  int SumOfDigitsRecursive(int num)
          {
              num = Math.Abs(num);
              
              if (Math.Abs(num) < 10)
              {
                  return Math.Abs(num);
              }
              else
              {
                  //sum += num % 10;
                  //sum = sum + (num % 10); //sum = 0 +  3   
                  return (Math.Abs(num) % 10) +  SumOfDigitsRecursive(Math.Abs(num)/10);
              }
          }
        
    }
}