using System;

internal class WibBot
{
    private static void Main()
    {
        Console.Write("Enter how many win number you need: ");
        int winNumber = int.Parse(Console.ReadLine());
        Random rand = new Random();
        for (int i = 1; i <= winNumber; i++)
        {
            int random = rand.Next(80) + 1;
            Console.WriteLine("Wuner Numbers are : {0}", random);


        }
    }
}
        
        
        
    