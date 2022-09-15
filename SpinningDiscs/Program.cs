using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            // TODO: Call each CD and DVD method to verify that they work as expected.

            List<string> kidsBop2Songs = new List<string> {"Firework", "Bye Bye Bye"};

            CD kidsBop = new CD(kidsBop2Songs, "Kids Bop 2", "CD");

            kidsBop.PrintInfo();
            kidsBop.WriteDisc();
            kidsBop.ReadDisc();
            kidsBop.StoreInfo();
            kidsBop.PrintTrackNames();



            string synopsis1 = "The Avengers fight Thanos and bring everyone back.";

            DVD AvengersEndGame = new DVD(synopsis1, "Avengers EndGame", "DVD");

            AvengersEndGame.PrintInfo();
            AvengersEndGame.WriteDisc();
            AvengersEndGame.ReadDisc();
            AvengersEndGame.StoreInfo();

        }
    }
}
