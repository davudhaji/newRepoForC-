using System;

class Program
{
    static void Main(string[] args)
    {
        int reqem = int.Parse(Console.ReadLine());
        star(reqem);
    }
    static void star(int reqem){
        int i, j;
        int MAX;
        if (reqem%2==0){
            MAX = reqem/2;    
        }else{
            MAX = reqem/2+1;
        }
        
        
        for (i = 1; i <= MAX; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (i = MAX; i >= 1; i--)
        {
            for (j = 1; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}