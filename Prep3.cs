#nullable disable

using System;

namespace Csharp220
{
public class Prep3
{
    public static void Run()
    {
        
        
    Random randomGenerator = new Random();
        
        int hiddenNumber = randomGenerator.Next(1, 101);
        int guess = -1;
       
    while (guess != hiddenNumber)
        {
            Console.Write("What is your guess? ");
            
                guess = int.Parse(Console.ReadLine());
            if (hiddenNumber > guess)
            
            {
                Console.WriteLine("Higher");
            }
            else if (hiddenNumber < guess)
            
            {
                Console.WriteLine("Lower");
            }
                else
            
            {
                Console.WriteLine("You guessed it!");
            }
        }                    
    }
}
}