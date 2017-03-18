using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person(string Name, string Lastname, int Age)
        {
            this.Age = Age;
            this.Name = Name;
            this.Lastname = Lastname;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", Name, Lastname, Age);
        }

    }
}
