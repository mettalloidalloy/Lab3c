
using System;

class MainClass {
  public static void Main (string[] args) {

        Console.WriteLine("Enter a number to check if it is prime");
        int num = Convert.ToInt32(Console.ReadLine());

        int n = num, a = 0;
        for (int i = 1; i <= n; i++) {
        if (n % i == 0) 
        {
        a++;
        }
      }
         if (a == 2) 
         {
            Console.WriteLine("{0} is a Prime Number", n);
         } else 
         {
            Console.WriteLine("Not a Prime Number");
         }
         Console.ReadLine();
      }
   }
