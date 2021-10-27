using System;

class Program
{
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        sum(n);
        
    }
    static void sum(int reqem){
        int cem=0;
        string b="2";
        for(int i=0;i<reqem;i++){
            b="2";
            
            for(int j=0;j<i;j++){
                Console.Write("2");
                b+="2";
            
            }
            cem+=int.Parse(b);
            Console.Write("2");
            if(i<reqem-1){
                Console.Write("+");
            }
        }
        Console.Write("="+cem);
    }
}