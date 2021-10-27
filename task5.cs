using System;

class Program
{
    static void Main() {
        int  n, i;       
        int[] a = new int[50];     
        Console.WriteLine("Reqemi Daxil Et: ");    
        n= int.Parse(Console.ReadLine());     
        for(i=0; n>0; i++)      
        {      
         a[i]=n%2;      
         n= n/2;    
        }      
        Console.Write("Binary: ");      
        for(i=i-1 ;i>=0 ;i--)      
        {      
         Console.Write(a[i]);      
        }                 
      }  
}
