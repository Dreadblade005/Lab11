using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    public class person
    {
        Dictionary<string, int> people = new Dictionary<string, int>();
        int number;
        string name;

        public person(int phone, string person)
        {
            people.Add(person, phone);
        }
        public person(string person, int phone)
        {
            people.Add(person, phone);
        }

        public void Deletenumber(string name)
        {
            if(people.ContainsKey(name))
            {
                people.Remove(name);
            }

        }
        string Findperson()
        {
           string name;
            Console.WriteLine("Enter the person's name: ");
            name = Console.ReadLine();
            if (people.ContainsKey(name))
            {
                int value = people[name];

                return "this " + name + " has the phone number: " + value;
            }
            else
            {
                return "this person does not exist";
            }
        }

    }
}
