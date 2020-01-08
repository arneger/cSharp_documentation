using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{   /*Program that determnines if you've lived long enough in a city
and that you're old enough to be a part of the city council or run for mayor.
You need to be atleast 30 years old and lived in the city atleast 9 years
to become Mayor. To become a part of the City Council you'll need to be
atleast 25 years old and lived in the city for atleast 5 years.
*/
    class Program
    {
        static int Age_Value(string age)
        {
            int the_age = Convert.ToInt32(age);
            if (the_age >= 25 && the_age < 30)
                return 1;
            else if (the_age < 25)
                return 2;
            else if (the_age >= 30)
                return 3;
            else
                return 0;
        }   

        static int Citizen_Time(string time)
        {
            int the_time = Convert.ToInt32(time);
            if (the_time >= 5 && the_time < 10)
                return 1;
            else if (the_time < 5)
                return 2;
            else if (the_time >= 9)
                return 3;
            else
                return 0;
        }

        static void Aprrove_System(string age, string time, int the_age, int the_time)
        {
            int users_time = Convert.ToInt32(time);
            int users_age = Convert.ToInt32(age);
            if (the_age == 1 && the_time == 1)
                Console.WriteLine("You can sit in the council.\nWhen you've lived here " + (9 - users_time) + " more years and lived " + (30 - users_age) + " more years to run for Mayor");
            else if (the_age == 2 && the_time == 2)
                Console.WriteLine("You're not qualified. You need to live here " + (5 - users_time) + " more years and live " + (25 - users_age) + " more years to become a part of the council");
            else if (the_age == 3 && the_time == 3)
                Console.WriteLine("You can run for Mayor and sit on the council");
            else if (the_age == 1 && the_time == 2)
                Console.WriteLine("You're not qualified. You need to live here " + (5 - users_time) + " more years to become a part of the council");
            else if (the_age == 1 && the_time == 3)
                Console.WriteLine("You can join the council.\nWait " + (30 - users_age) + " more years to run for Mayor");
            else if (the_age == 2 && the_time == 1)
                Console.WriteLine("You're not qualified. Wait " + (25 - users_age) + " to become a part of the council");
            else if (the_age == 2 && the_time == 3)
                Console.WriteLine("You're not qualified. Wait " + (25 - users_age) + " more years to become a part of the council or run for Mayor");
            else if (the_age == 3 && the_time == 1)
                Console.WriteLine("You can join the council. Apply in " + (9 - users_time) + " more years to run for Mayor");
            else if (the_age == 3 && the_time == 2)
                Console.WriteLine("You're not qualified. Wait " + (5 - users_time) + " more years to become a part of the council");
        }

        static void Main(string[] args)
        {
            Console.Write("Your age: ");
            string age = Console.ReadLine();
            Console.Write("The time you've been a citizen: ");
            string time = Console.ReadLine();
            int age_number = Age_Value(age);
            int time_number = Citizen_Time(time);
            Aprrove_System(age, time, age_number, time_number);

        }
    }
}
