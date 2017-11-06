using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ownerName, city, street, petName;
            int color, akcNum, year, month, day, n = 2;
            Owner[] owner = new Owner[n];
            Pet[] pet = new Pet[n];
            Fish[] fish = new Fish[n];
            Dog[] dog = new Dog[n];
            Date[] date = new Date[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter owner's name: ");
                ownerName = Console.ReadLine();
                Console.Write("Enter city: ");
                city = Console.ReadLine();
                Console.Write("Enter street: ");
                street = Console.ReadLine();
                owner[i] = new Owner(ownerName, city, street);

                Console.Write("Enter year: ");
                year = int.Parse(Console.ReadLine());
                Console.Write("Enter month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Enter day: ");
                day = int.Parse(Console.ReadLine());

                Console.Write("Enter pet's name: ");
                petName = Console.ReadLine();
                pet[i] = new Pet(petName);
                
                owner[i].SetPet(pet[i]);
                pet[i].SetOwner(owner[i]);

                if (String.Compare(petName, "fish", true) == 0)
                {
                    Console.Write("Enter color: ");
                    color = int.Parse(Console.ReadLine());
                    fish[i] = new Fish(petName, color);
                    
                    date[i] = new Date(year, month, day);

                    owner[i].DisplayStat();
                    fish[i].DisplayStat();
                    date[i].DisplayStat();
                }
                else if (String.Compare(petName, "dog", true) == 0)
                {
                    Console.Write("Enter akcNum: ");
                    akcNum = int.Parse(Console.ReadLine());
                    dog[i] = new Dog(petName, akcNum);
                    dog[i].SetShots(year, month, day);

                    owner[i].DisplayStat();
                    dog[i].DisplayStat();
                }
                else
                    i--;
            }

            Console.ReadKey();
        }
    }
}