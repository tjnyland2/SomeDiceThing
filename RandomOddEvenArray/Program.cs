using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace IntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toby Nyland 08/10/24 - 2 Dice adding
           
            int[] dice1 = new int[500]; //Creates array (D1)
            int[] dice2 = new int[500]; //Creates array (D2)
            Random r = new Random(); //imports random
            for (int i = 0; i < 500; i = i + 1)//For loop (1000 Rolls)
            {
                //DICE 1//
                int RandNumber = r.Next(1, 7); // Generates random number (Dice)
                dice1[i] = RandNumber; //adds the values to an array
                //Console.WriteLine(dice1[i]);//Outputs the value added

                //DICE 2//
                int RandNumber2 = r.Next(1, 7); // Generates random number (Dice)
                dice2[i] = RandNumber2; //adds the values to an array
               // Console.WriteLine(dice2[i]);//Outputs the value added

                int value = dice1[i] + dice2[i]; //adds each roll up
                Console.WriteLine("["+i+"} The 2 dice added together creates the value of: " + value);

            }

            for (int count = 0; count<500; count++)
            {

            }
            Console.ReadLine();//Outputs
        }
    }
}