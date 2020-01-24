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
        private int theAge;
        private int theTime;
        public City_System(string a, string t)
        {
            theAge = Convert.ToInt32(a);
            theTime = Convert.ToInt32(t);
        }
        private int Age_Value()
        {
            int age = theAge;
            if (age >= 25 && age < 30)
                return 1;
            else if (age < 25)
                return 2;
            else if (age >= 30)
                return 3;
            else
                return 0;
        }
        private int Citizen_Time()
        {
            int time = theTime;
            if (time >= 5 && theTime < 10)
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
            int valueAge = Age_Value();
            int valueTime = Citizen_Time();
            if (valueAge == 1 && valueTime == 1)
                Console.WriteLine("You can sit in the council.\nWhen you've lived here " + (9 - theTime) + " more years and lived " + (30 - theAge) + " more years to run for Mayor");
            else if (valueAge == 2 && valueTime == 2)
                Console.WriteLine("You're not qualified. You need to live here " + (5 - theTime) + " more years and live " + (25 - theAge) + " more years to become a part of the council");
            else if (valueAge == 3 && valueTime == 3)
                Console.WriteLine("You can run for Mayor and sit on the council");
            else if (valueAge == 1 && valueTime == 2)
                Console.WriteLine("You're not qualified. You need to live here " + (5 - theTime) + " more years to become a part of the council");
            else if (valueAge == 1 && valueTime == 3)
                Console.WriteLine("You can join the council.\nWait " + (30 - theAge) + " more years to run for Mayor");
            else if (valueAge == 2 && valueTime == 1)
                Console.WriteLine("You're not qualified. Wait " + (25 - theAge) + " to become a part of the council");
            else if (valueAge == 2 && valueTime == 3)
                Console.WriteLine("You're not qualified. Wait " + (25 - theAge) + " more years to become a part of the council or run for Mayor");
            else if (valueAge == 3 && valueTime == 1)
                Console.WriteLine("You can join the council. Apply in " + (9 - theTime) + " more years to run for Mayor");
            else if (valueAge == 3 && valueTime == 2)
                Console.WriteLine("You're not qualified. Wait " + (5 - theTime) + " more years to become a part of the council");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your age: ");
            string age = Console.ReadLine();
            Console.Write("Your time as a citizen: ");
            string citizenTime = Console.ReadLine();
            City_System person = new City_System(age, citizenTime);
            person.Aprrove_System();
        }
    }
}
