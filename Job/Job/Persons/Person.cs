using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Persons
{
    public class Person
    {
        protected string namePerson;
        public string NamePerson()
        {
            return namePerson;
        }
        public Person(string name)
        {
            this.namePerson = name;
        }
        public void SayHello(Person person, int hour)
        {
            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Доброе утро,{0}! Сказал(a) {1}.", person.namePerson, namePerson);
            }
            else
                if (hour >= 12 && hour <= 17)
                {
                    Console.WriteLine("Добрый день,{0}! Сказал(a) {1}.", person.namePerson, namePerson);
                }
                else
                {
                    Console.WriteLine("Добрый вечер,{0}! Сказал(a) {1}.", person.namePerson, namePerson);
                }
        }
        public void SayGoodbuy(Person person)
        {
            Console.WriteLine("До свидания,{0}! Сказал(a) {1}.", person.namePerson, namePerson);
        }
    }
}
