using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {   // Returns area
        static double Areal(string radius)
        {
            float the_radius = Convert.ToSingle(radius);
            double the_area = Math.PI * the_radius * the_radius;
            return the_area;
        }
        // Returns the length of a sentence
        static int Sentence_Counter(string sentence)
        {
            string[] words = sentence.Split(' ');
            string all_words = "";
            foreach (string element in words)
            {
                all_words += element;
            }
            int all_words_length = all_words.Length;
            return all_words_length;
                
        }
        // Returns a number from 1 to 6 (It's a dice)
        static int RollDice()
        {
            Random number = new Random();
            int random_number = number.Next(1, 7);
            return random_number;
        }
        // Main method to test the methods.
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            string radius = Console.ReadLine();
            Console.WriteLine(Areal(radius));
            Console.WriteLine("Write a sentence to check the amount of characters: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(Sentence_Counter(sentence));
            int dice = RollDice();
            Console.WriteLine("The dice rolled: {0}", dice);
        }
        
        
    }
}
