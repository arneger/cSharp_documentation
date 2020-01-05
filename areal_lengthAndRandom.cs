class Program
    {   
        static void Main(string[] args)
        {   //Solves the area 
            Console.WriteLine("Radius: ");
            float radius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Arealet er: " + Math.PI*radius*radius);

            //Counts the amount of characters in a sentence
            Console.Write("Sentence: ");
            string setning = Console.ReadLine();
            string[] words = setning.Split(' ');
            string alleord = "";
            foreach (string element in words)
            {
                alleord += element;
            }
            int bokstaver = alleord.Length;
            Console.Write("Guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (bokstaver == guess)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //Takes a random number between 1-99 and multiplies it with a given input number
            Random tall = new Random();
            int randomTall = tall.Next(1, 99);
            Console.Write("Skriv et tall: ");
            int mittTall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*{1} = {2}", randomTall, mittTall, randomTall * mittTall);
        }
        
    }