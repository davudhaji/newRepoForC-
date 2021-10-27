using System;
using System.Text.RegularExpressions;

class Program
{
    static int CountSpaces(string value)
    {
    int Count=0;
    string pattern =  @"\ ";  
    Regex rg = new Regex(pattern); 
    MatchCollection match = rg.Matches(value);  
    for (int count = 1; count < match.Count; count++){ 
        Count+=count;
    }
    
	Regex.Replace(value, @"\  ", " ");
    
    return Count;
        
    }

    static void Main()
    {
	string value = "salam  necesen  dddbb  dsadas  dsada";
	Console.WriteLine(CountSpaces(value));
	value = "dsadsa  dsadsa  dsa dsadas";
	Console.WriteLine(CountSpaces(value));
    }
}