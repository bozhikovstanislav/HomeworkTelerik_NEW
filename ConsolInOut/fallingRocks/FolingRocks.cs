using System;
using System.Collections.Generic;
using System.Threading;

class FolingRocks
{
    struct Rock
    {
        public string Simvol;
        public RockPosition Position;
        public Rock(string simvol, RockPosition position)
        {
            this.Position = position;
            this.Simvol = simvol;
        }
    }
    struct RockPosition
    {
        public int X;
        public int Y;

        public RockPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

    }
    static void Main()
    {
        /*
             Problem 12.**   Falling Rocks
             
         Implement the "Falling Rocks" game in the text console.
             
         A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
         A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
         Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is(O).
         Ensure a constant game speed by Thread.Sleep(150).
         Implement collision detection and scoring system.
         */
        Console.WriteLine("Whelcom to the Falling Rocks Game ");
        Console.WriteLine("\n");

        Console.WriteLine("***********************************************************");

        Console.WriteLine("Press key to start");
   
  
        Console.BufferHeight = Console.WindowHeight = 37;
        Console.BufferWidth = Console.WindowWidth = 60;
        Random rocktypeRandom = new Random();
        int rockTypeValue = rocktypeRandom.Next(0, 5);
     
        
        Rock rondolRock = new Rock();
        string[] rocks = new string[] { "&", "%", "+++", "!", "@", "()" };
       
        while (true)
        {
            Random randomColl = new Random(Guid.NewGuid().GetHashCode());
            int count1 = randomColl.Next(10);
            int count2 = randomColl.Next(10);
            int count3 = randomColl.Next(8);
            int count4 = randomColl.Next(7);
            int count5 = randomColl.Next(9);
            int count6 = randomColl.Next(2);

            RockPosition rondomrockPosition0 = new RockPosition(0, randomColl.Next(0, 50));
            RockPosition rondomrockPosition1 = new RockPosition(0, randomColl.Next(0, 50));
            RockPosition rondomrockPosition2 = new RockPosition(0, randomColl.Next(0, 50));
            RockPosition rondomrockPosition3 = new RockPosition(0, randomColl.Next(0, 50));
            RockPosition rondomrockPosition4 = new RockPosition(0, randomColl.Next(0, 50));
            RockPosition rondomrockPosition5 = new RockPosition(0, randomColl.Next(0, 50));
                   //rondomrockPosition0 = new RockPosition();
                   // rondomrockPosition1 = new RockPosition(0, randomColl.Next(0, 50));
                   // rondomrockPosition2 = new RockPosition(0, randomColl.Next(0, 50));
                   //  rondomrockPosition3 = new RockPosition(0, randomColl.Next(0, 50));
                   // rondomrockPosition4 = new RockPosition(0, randomColl.Next(0, 50));
                   // rondomrockPosition5 = new RockPosition(0, randomColl.Next(0, 50));
          
                do
                {
                   
                    Rock[] myRocks = new Rock[]
                {
                    new Rock(rocks[0],rondomrockPosition0),
                    new Rock(rocks[1],rondomrockPosition1),
                    new Rock(rocks[2],rondomrockPosition2),
                    new Rock(rocks[3],rondomrockPosition3),
                    new Rock(rocks[4],rondomrockPosition4),
                    new Rock(rocks[5],rondomrockPosition5),
                };



                        Console.Clear();

                        myRocks[0].Position.X = count1;
                        myRocks[1].Position.X = count2;
                        myRocks[2].Position.X = count3;
                        myRocks[3].Position.X = count4;
                        myRocks[4].Position.X = count5;
                        myRocks[5].Position.X = count6;
                        Console.SetCursorPosition(myRocks[0].Position.Y, myRocks[0].Position.X);
                        Console.Write(myRocks[0].Simvol);
                        Console.SetCursorPosition(myRocks[1].Position.Y, myRocks[1].Position.X);
                        Console.Write(myRocks[1].Simvol);
                        Console.SetCursorPosition(myRocks[2].Position.Y, myRocks[2].Position.X);
                        Console.Write(myRocks[2].Simvol);
                        Console.SetCursorPosition(myRocks[3].Position.Y, myRocks[3].Position.X);
                        Console.Write(myRocks[3].Simvol);
                        Console.SetCursorPosition(myRocks[4].Position.Y, myRocks[4].Position.X);
                        Console.Write(myRocks[4].Simvol);
                        Console.SetCursorPosition(myRocks[5].Position.Y, myRocks[5].Position.X);
                        Console.Write(myRocks[5].Simvol);
                       //Changing the coordinat X
                        count1++;
                        if (count1 == 30)
                        {
                            count1 = rocktypeRandom.Next(0,9);
                        }
                        count2++;
                        if (count2 == 30)
                        {
                            count2 = rocktypeRandom.Next(0, 9);
                        }
                        count3++;
                        if(count3==30)
                        {
                            count3 = rocktypeRandom.Next(0, 6);
                        }
                        count4++;
                        if (count4 == 30)
                        {
                            count4 = rocktypeRandom.Next(0, 8);
                        }
                        count5++;
                        if (count5 == 30)
                        {
                            count5 = rocktypeRandom.Next(0, 11);
                        }
                        count6++;
                        if (count6 == 30)
                        {
                            count6 = rocktypeRandom.Next(0, 15);
                        }
                      
                    Thread.Sleep(50);
                } while (count1 != 30 && count2!=30);


            
           

            

        }



        




    }

}
    

