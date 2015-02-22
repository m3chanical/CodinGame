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
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.
            double d = 0;
            int diffY = 0;
            int diffX = 0;
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            d = Math.Sqrt(Math.Pow(LX - TX, 2) + Math.Pow(LY - TY, 2));
            //Console.WriteLine(d);
            diffY = TY - LY;
            diffX = TX - LX; 
            //Now that I think about it this might be done with just a for loop within the game loop?
            
            if (TX > LX && TY < LY){ //Movement Southwest.
                Console.WriteLine("SW");
                TX -= 1;
                TY += 1;
                
            } else if (TX > LX && TY > LY) { //Movement Northwest
                Console.WriteLine("NW");
                TX -= 1;
                TY -= 1;
                
            } else if (TX < LX && TY > LY) { //Movement Northeast
                Console.WriteLine("NE");
                TX += 1;
                TY -= 1;
                
            } else if (TX < LX && TY < LY) { //Movement Southeast
                Console.WriteLine("SE");
                TX += 1;
                TY += 1;
                
            } else if (TX == LX && TY < LY) { //Movement South
                Console.WriteLine("S");
                TY += 1;
                
            } else if (TX == LX && TY > LY) { //Movement North
                Console.WriteLine("N");
                TY -= 1;
                
            } else if (TX > LX && TY == LY) { //Movement West
                Console.WriteLine("W");
                TX -=1;
                
            } else if (TX < LX && TY == LY) { //Movement East
                Console.WriteLine("E");
                TX += 1;
                
            }
            Console.Error.WriteLine("Difference in Y: " + diffY + "\nDifference in X: " + diffX + "\nDistance Between Thor and Light: " + d);

            //Console.WriteLine("SW"); // A single line providing the move to be made: N NE E SE S SW W or NW
        }
    }
}