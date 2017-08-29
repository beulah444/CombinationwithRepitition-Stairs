using System;
class Program
{
    static void Main()
    {
        string strUserDecision = string.Empty;
        do
        {
            Console.WriteLine("enter the number of steps:");
            bool isNum = int.TryParse(Console.ReadLine(), out int n);
            double N = (double)n;
            // with 2 ways to claim the steps
            //either with 1 or 2
            double items = 2;
            if (isNum)
            {
            double permutationswithrepetition = Math.Pow(items,n);
           int combination = (factorial(n + items - 1)) / ((factorial(n) * factorial(items - 1)));
           Console.WriteLine("permutations(distinct ways with repetition)  of reaching " + n + " is : "
                       + (permutationswithrepetition));
                Console.WriteLine("Combination of reaching " + n + " is : "
                        + (combination));
            }
            else { Console.WriteLine("Invalid Number"); }
            do
            {
                Console.WriteLine("Do you want to add new number? YES or NO");
                strUserDecision = Console.ReadLine().ToUpper();
            } while (strUserDecision != "YES" && strUserDecision != "NO");
        } while (strUserDecision == "YES");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
    static int factorial(double num)
    {
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}