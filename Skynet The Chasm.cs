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
        int R = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int G = int.Parse(Console.ReadLine()); // the length of the gap.
        int L = int.Parse(Console.ReadLine()); // the length of the landing platform.
        int positionLandingStart = R + G;
        int roadLeft = R;
        
        // game loop
        while (true)
        {
            int S = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int X = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
            int maxSpeed = G + 1;
            roadLeft = R - X;
            
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            //Determine speed needed to clear gap. No more, no less. 
            //That way the platform length should be negligible. 
            
            //Things needed:    speed = length_of_gap + 1; if canClearGap, JUMP... 
            //                  if 
            //                  if position is after gap (length of road + length of gap),
            //                  slow slow slow slow
            Console.Error.WriteLine("Value of R (length of road before gap): " + R);
            Console.Error.WriteLine("Value of X (Bike's current position): " + X);
            Console.Error.WriteLine("Value of G (length of gap): " + G);
            Console.Error.WriteLine("Value of maxSpeed: " + maxSpeed);
            Console.Error.WriteLine("Value of positionLandingStart: " + positionLandingStart);
            Console.Error.WriteLine("Value of roadLeft: " + roadLeft);            
            if (roadLeft == 1 || roadLeft == 0){
                Console.WriteLine("JUMP");
            } else if (X >= positionLandingStart - 1 || S > maxSpeed){
                Console.WriteLine("SLOW");
            } else if (S < maxSpeed) {
                Console.WriteLine("SPEED"); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
            } else {
                Console.WriteLine("WAIT");
            }
        }
    }
}