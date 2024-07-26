using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiApp
{
    public class Program
    {
        public static void MaxBmi(Person[] persons)
        {
            double maxBmi = 0;
            Person maxBmiPerson = null;
            foreach (Person person in persons)
            {
                double compareBmi = person.CalculateBmi();
                if (maxBmi < compareBmi)
                {
                    maxBmi = compareBmi;
                    maxBmiPerson = person;
                }
            }
            Console.WriteLine("The Max BMI is {0}", maxBmi);
            Console.WriteLine(maxBmiPerson.PrintDetails());
        }
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Pratik", 22, 6, 75);
            Person person2 = new Person(2, "Ravi", 24, 5.4, 90);
            Person person3 = new Person(3, "Suraj", 24);

            Person[] persons = { person1, person2, person3 };

            MaxBmi(persons);

            Console.WriteLine(person1.CalculateBmiCriteria());
            Console.WriteLine(person2.CalculateBmiCriteria());
            Console.WriteLine(person3.CalculateBmiCriteria());
        }
    }
}
