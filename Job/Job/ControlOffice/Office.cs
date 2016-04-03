using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Persons;

namespace Job.ControlOffice
{
    public delegate void SayHello(Person person, int hour);
    public delegate void SayGoodbuy(Person person);
    public class Office
    {
        public event SayHello Came;
        public event SayGoodbuy Left;
        private List<Person> office = new List<Person>();
        public void PersonCame(Person person)
        {
            if (FireIncommingEvent(person))
            {
                Came += person.SayHello;
                Left += person.SayGoodbuy;
                office.Add(person);
            }
        }
        public void PersonLeft(Person person)
        {
            if (office.IndexOf(person) != -1)
            {
                Came -= person.SayHello;
                Left -= person.SayGoodbuy;
                FireLeavingEvent(person);
            }
            else
            {
                Console.WriteLine("Сотрудник {0} не приходил(a) в офис.", person.NamePerson());
            }
        }
        protected bool FireIncommingEvent(Person person)
        {
            var e = Came;
            if (e != null)
            {
                if (office.IndexOf(person) == -1)
                {
                    Console.WriteLine("В офис пришел(а) {0}.", person.NamePerson());
                    int hour = System.DateTime.Now.Hour;
                    Came(person, hour);
                }
                else
                {
                    Console.WriteLine("Cотрудник {0} уже находится в офисе!", person.NamePerson());
                    return false;
                }
            }
            else
                Console.WriteLine("В офис пришел(а) {0},это первый сотрудник,который пришел в офис.", person.NamePerson());
            return true;
        }
        protected void FireLeavingEvent(Person person)
        {
            var e = Left;
            if (e != null)
            {
                Console.WriteLine("Из офиса ушел(a) {0}.", person.NamePerson());
                e(person);
                office.Remove(person);
            }
            else
            {
                Console.WriteLine("Из офила ушел(а) {0},офис пуст.", person.NamePerson());
                office.Remove(person);
            }
        }
        public void PrintfCame()
        {
            if (office.Count != 0)
            {
                foreach (Person person in office)
                {
                    Console.WriteLine(person.NamePerson());
                }
            }
            else
                Console.WriteLine("В офисе не осталось сотрудников!");
        }
    }
}
