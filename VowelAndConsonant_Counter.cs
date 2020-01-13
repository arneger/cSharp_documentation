using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Class that includes methods to count vowels and consonants in a string
    class String_Manipulator
    {
        private string setning;
        public String_Manipulator(string s)
        {
            setning = s;
        }
        //Counts vowels in a string
        public int Vowels_Amount()
        {
            string vowels = "aeioy";
            int amount = 0;
            foreach (char element in setning.ToLower())
            {
                if (vowels.Contains(element))
                    amount += 1;
            }
            return amount;
        }
        //Counts consonants in a string
        public int Consonant_Amount()
        {
            string vowels = "aeio y";
            int amount = 0;
            foreach (char element in setning.ToLower())
            {
                if (!vowels.Contains(element))
                    amount += 1;
            }
            return amount;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Type c for Consonants or Type v for for Vowels");
            string decide = Console.ReadLine();
            String_Manipulator x = new String_Manipulator(sentence);
            if (decide.ToLower() == "v")
                Console.WriteLine("Vowels: {0}",x.Vowels_Amount());
            else if (decide.ToLower()=="c")
                Console.WriteLine("Consonants: {0}",x.Consonant_Amount());
            
        }
    }
}
