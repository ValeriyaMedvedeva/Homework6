using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.ControlOffice;
using Job.Persons;

namespace Job.StartJob
{
    public class Scheduler
    {
        private Office office1 = new Office();
        public void Start()
        {
            Person[] persons =
			{
				new Person("Валерия"),
				new Person("Евгений"),
				new Person("Мария"),
				new Person("Елизавета"),
				new Person("Алексей")
			};
            SchedulerAction(persons[0], true, office1);
            SchedulerAction(persons[2], true, office1);
            SchedulerAction(persons[3], true, office1);
            SchedulerAction(persons[2], false, office1);
            SchedulerAction(persons[4], true, office1);
            SchedulerAction(persons[0], false, office1);
            SchedulerAction(persons[3], false, office1);
            SchedulerAction(persons[4], false, office1);
            SchedulerAction(persons[0], true, office1);
            SchedulerAction(persons[1], false, office1);
            SchedulerAction(persons[0], true, office1);
            Console.WriteLine("Оставшиеся в офисе сотрудники:");
            office1.PrintfCame();
        }
        protected void SchedulerAction(Person person, bool Action, Office office1)
        {
            if (Action)
                office1.PersonCame(person);
            else
                office1.PersonLeft(person);
            Console.WriteLine();
        }
    }
}
