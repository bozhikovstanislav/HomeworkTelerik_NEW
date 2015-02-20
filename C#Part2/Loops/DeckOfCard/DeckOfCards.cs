using System;
using System.Text;
class DeckOfCards
{
    static void Main()
    {
        /*Problem 4.       Print a Deck of 52 Cards
         Write a program that generates and prints all possible cards from a standard deck of 52 cards
         (without the jokers). The cards should be printed using the classical notation 
         (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        The card faces should start from 2 to A.
        Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
         Use 2 nested for-loops and a switch-case statement.
         
         */
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Welcom to the program that prints the faces of a Deck of Cards");
        Console.Write("\n");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        string heart = "\u2665";
        string spade = "\u2660";
        string clubs = "\u2663";
        string diamond = "\u2666";
        string Ace = "A";
        string Jack = "J";
        string Queen = "Q";
        string King = "K";
        //Puting the string into Array
        //string[] labelCard=new string[]
        //{
        //    heart,
        //    spade,
        //    clubs,
        //    diamond,
        //    Ace,
        //    Jack,
        //    Queen,
        //    King
        //};

        for (int k = 2; k <= 14; k++)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            if (k == 11)
                            {
                                Console.Write("{0} of {1},", Jack, heart);
                            }
                            else if (k == 12)
                            {
                                Console.Write("{0} of {1},", Queen, heart);
                            }
                            else if (k == 13)
                            {
                                Console.Write("{0} of {1},", King, heart);
                            }
                            else if (k == 14)
                            {
                                Console.Write("{0} of {1},", Ace, heart);
                            }
                            else
                            {
                                Console.Write("{0} of {1},", k, heart);
                            }

                            // Console.Write("\n");
                            break;
                        }
                    case 1:
                        {
                            if (k == 11)
                            {
                                Console.Write("{0} of {1},", Jack, spade);
                            }
                            else if (k == 12)
                            {
                                Console.Write("{0} of {1},", Queen, spade);
                            }
                            else if (k == 13)
                            {
                                Console.Write("{0} of {1},", King, spade);
                            }
                            else if (k == 14)
                            {
                                Console.Write("{0} of {1},", Ace, spade);
                            }
                            else
                            {
                                Console.Write("{0} of {1},", k, spade);
                            }

                            //Console.Write("\n");
                            break;
                        }
                    case 2:
                        {

                            if (k == 11)
                            {
                                Console.Write("{0} of {1},", Jack, clubs);
                            }
                            else if (k == 12)
                            {
                                Console.Write("{0} of {1},", Queen, clubs);
                            }
                            else if (k == 13)
                            {
                                Console.Write("{0} of {1},", King, clubs);
                            }
                            else if (k == 14)
                            {
                                Console.Write("{0} of {1},", Ace, clubs);
                            }
                            else
                            {
                                Console.Write("{0} of {1},", k, clubs);
                            }

                            //Console.Write("\n");
                            break;
                        }
                    case 3:
                        {
                            if (k == 11)
                            {
                                Console.Write("{0} of {1},", Jack, diamond);
                            }
                            else if (k == 12)
                            {
                                Console.Write("{0} of {1},", Queen, diamond);
                            }
                            else if (k == 13)
                            {
                                Console.Write("{0} of {1},", King, diamond);
                            }
                            else if (k == 14)
                            {
                                Console.Write("{0} of {1},", Ace, diamond);
                            }
                            else
                            {
                                Console.Write("{0} of {1},", k, diamond);
                            }

                            Console.Write("\n");
                            break;
                        }



                    default:
                        break;
                }
                //
            }
        }



        //Console.WriteLine(heart);


    }
}

