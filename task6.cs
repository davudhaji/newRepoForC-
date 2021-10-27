using System;

class Program
{
    static void Main() {
        
        int reqem12 = int.Parse(Console.ReadLine());
        cube(reqem12);
        
    }
    
    static void cube(int reqem){
        Console.WriteLine(reqem*reqem*reqem);
    }
  
}