﻿using System;

public class CoinTossing
{
    public static void Main(string[] args)
    {

        
        CoinTossing TossCoin = new CoinTossing();

        TossCoin.CoinTossCalculate();

    } 
    int result;
    Random randomNumbers; 
    const int NUMBER_OF_SIDES = 2; 
    string[] coinfaces = { "Heads", "Tails" };


    public void CoinTossCalculate()
    {
        int coinHead = 0;
        int coinTails = 0;
        randomNumbers = new Random(); 

        
        Console.Write("Toss coin? (1 = yes, 2 = no): ");
        result = Convert.ToInt32(Console.ReadLine());

        
        while (result == 1) 
        {
            int second = randomNumbers.Next(NUMBER_OF_SIDES);
            if (second == 1)
            {
                Console.WriteLine("HEADS it is!\n");
                coinHead += 1;
                Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                Console.WriteLine("Tails\ttotal count: {0}", coinTails);
            }
            else
            {
                Console.WriteLine("TAILS it is!\n");
                coinTails += 1;
                Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                Console.WriteLine("Tails\ttotal count: {0}", coinTails);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Toss coin? (1 = yess, 2 = no): ");
            result = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.WriteLine("Game Over!");

    } 


}