using System;
using static System.Console;

namespace LoppyArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //<type>[<declares array] = new <same type> [<size>]
            string[] input = new string[10];

            string[] otherInput = { "rock", "rock", "rock" }; //another way to create an array

            int counter = 0;
            while(counter < 3)
            {
                input[counter] = ReadLine();
                Clear();
                counter++;
            }

            
            while(counter > 0)
            {
                WriteLine("Player{0} chose {1}", counter, input[counter - 1]);
                counter--;
            }
        }
    }
}
