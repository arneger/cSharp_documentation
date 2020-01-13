using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /*Program that determnines if you've lived long enough in a city
and that you're old enough to be a part of the city council or run for mayor.
You need to be atleast 30 years old and lived in the city atleast 9 years
to become Mayor. To become a part of the City Council you'll need to be
atleast 25 years old and lived in the city for atleast 5 years.
*/
    class City_System
    {
        public int the_age;
        public int the_time;
        public City_System(string a, string t)
        {
            the_age = Convert.ToInt32(a);
            the_time = Convert.ToInt32(t);
        }
        public int Age_Value()
        {
            int age = the_age;
            if (age >= 25 && age < 30)
                return 1;
            else if (age < 25)
                return 2;
            else if (age >= 30)
                return 3;
            else
                return 0;
        }
        public int Citizen_Time()
        {
            int time = the_time;
            if (time >= 5 && the_time < 10)
                return 1;
            else if (time < 5)
                return 2;
            else if (time >= 9)
                return 3;
            else
                return 0;
        }
        public void Aprrove_System()
        {
            int value_age = Age_Value();
            int value_time = Citizen_Time();
            if (value_age == 1 && value_time == 1)
                Console.WriteLine("You can sit in the council.\nWhen you've lived here " + (9 - the_time) + " more years and lived " + (30 - the_age) + " more years to run for Mayor");
            else if (value_age == 2 && value_time == 2)
                Console.WriteLine("You're not qualified. You need to live here " + (5 - the_time) + " more years and live " + (25 - the_age) + " more years to become a part of the council");
            else if (value_age == 3 && value_time == 3)
                Console.WriteLine("You can run for Mayor and sit on the council");
            else if (value_age == 1 && value_time == 2)
                Console.WriteLine("You're not qualified. You need to live here " + (5 - the_time) + " more years to become a part of the council");
            else if (value_age == 1 && value_time == 3)
                Console.WriteLine("You can join the council.\nWait " + (30 - the_age) + " more years to run for Mayor");
            else if (value_age == 2 && value_time == 1)
                Console.WriteLine("You're not qualified. Wait " + (25 - the_age) + " to become a part of the council");
            else if (value_age == 2 && value_time == 3)
                Console.WriteLine("You're not qualified. Wait " + (25 - the_age) + " more years to become a part of the council or run for Mayor");
            else if (value_age == 3 && value_time == 1)
                Console.WriteLine("You can join the council. Apply in " + (9 - the_time) + " more years to run for Mayor");
            else if (value_age == 3 && value_time == 2)
                Console.WriteLine("You're not qualified. Wait " + (5 - the_time) + " more years to become a part of the council");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your age: ");
            string age = Console.ReadLine();
            Console.Write("Your time as a citizen: ");
            string citizen_time = Console.ReadLine();
            City_System person = new City_System(age, citizen_time);
            person.Aprrove_System();
        }
    }
}

