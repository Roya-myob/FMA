using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void  Main()
        {
            var num =-234;
            var sum = SumOfDigitsRecursive(num);
            Console.WriteLine(sum);
        }
          public static  int SumOfDigitsRecursive(int num)
          {
              num = Math.Abs(num);
              
              if (num < 10)
              {
                  return num;
              }
              else
              {
                  return num % 10 +  SumOfDigitsRecursive(num/10);
              }
          }
    }
}