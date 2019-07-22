using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasicOperations
{
    class Person
    {
        public string name;
        public string city;
        public Person(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
    }
    class Program
    {
        static void printQuery(IEnumerable<Person> query)
        {
            foreach (var per in query)
            {
                Console.WriteLine(per.name+" "+per.city);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var persons = new List<Person> { new Person("a", "Bengaluru"), new Person("b", "Delhi"), new Person("c", "chennai"), new Person("d", "Bengaluru"), new Person("d", "Lucknow") };
            var personTwo = new List<Person> { new Person("b", "Delhi"), new Person("c", "chennai") };

            //Obtaining data source
            var queryAllPersons = from per in persons
                                  select per;
            printQuery(queryAllPersons);
            var queryAllPersonsTwo = from per in persons
                                     select per;
            printQuery(queryAllPersonsTwo);

            // filtering
            var queryPerson = from per in persons
                              where per.city == "Delhi"
                              select per;
            printQuery(queryPerson);

            //Ordering
            var queryOderByCity = from per in persons
                                  orderby per.city
                                  select per;
            printQuery(queryOderByCity);

            //Grouping
            var queryGroupByCity = from per in persons
                                   group per by per.city into perGroup
                                   select perGroup;
            printQuery(queryGroupByCity);

            //Joining
            var queryJoinPersons = from per in persons
                                   join perTwo in personTwo on per.city equals perTwo.city
                                   select new { name= per.name, city= per.city};
            printQuery(queryJoinPersons);
        }

        private static void printQuery(IEnumerable<object> queryJoinPersons)
        {
            foreach (var per in queryJoinPersons)
            {
                Console.WriteLine(((Person)per).name + " " + ((Person)per).city);
            }
            Console.WriteLine();
        }

        private static void printQuery(IEnumerable<IGrouping<string, Person>> queryGroupByCity)
        {
            foreach (var per in queryGroupByCity)
            {
                Console.WriteLine(per.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
