using System;

class Program
{
    static void Main() {
        int reqem = int.Parse(Console.ReadLine());
        count_of_digits(reqem);
    }
    
    static void count_of_digits(int digit){
        int say=1,i=1;
        if(digit<10){
            Console.WriteLine("1");
        }else{
            while(i<digit){
                say++;
                digit = (digit - (digit%10))/10;    
            }
            Console.WriteLine(say);
        }
        
    }
}