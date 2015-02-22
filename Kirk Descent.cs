using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static int HighestMountain(int[] MountainHeight) {
        int M = MountainHeight[0]; //Set this to the 0 position 
        for(int i = 1; i < MountainHeight.Length; i++){
            if (MountainHeight[i] > M){
                M = MountainHeight[i];
                Console.Error.WriteLine("Current Value of M at i(" + i +"): " + M + "\n");
            }
        }
        Console.Error.WriteLine("IndexOf() Output: " + Array.IndexOf(MountainHeight, M) +"\n");
        return Array.IndexOf(MountainHeight, M);
    }
    
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int SX = int.Parse(inputs[0]);
            int SY = int.Parse(inputs[1]);
            int[] MH = new int[8];
            for (int i = 0; i < 8; i++)
            {
                MH[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if(SX == HighestMountain(MH)){
                Console.WriteLine("FIRE");
            } else {
                Console.WriteLine("HOLD");
            }
            
                
        }
    }
    
}