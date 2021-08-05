using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMovable
    {
        private readonly string _firstName = "";
        private string _lastName = "";

        //public string FullName => $"Full Name: {_firstName} {_lastName}";

        private int _age;

        // this data is available whilst the firstName/lastName arent available
        //public int Age { get; set; }


        public string FirstName { get;  init; } = "";
        public string LastName { get;  init; } = "";


        public int Age 
        {
            get { return _age; }
            set { if (value < 0) 
                { 
                    throw new ArgumentException();
                } 
                _age = value; }
        }

        public Person(string firstName, string lastName, int age = 0) 
        {
            _firstName = firstName;
            _lastName = lastName;

            //FirstName = firstName;
            //LastName = lastName;
            Age = age;
        }

        public Person(string firstName)
        {
            _firstName = firstName;
        }

        // creating an empty constructor allows us to :
        // var paula = new Person() { FirstName = "paula", LastName = "Kendra", Age = 23 };
        // as you can see we're setting a new person with no arguments
        public Person()
        {
         
        }

        public virtual string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }


        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }


        public string Move(int times) 
        {
            return $"Walking along {times} times";
        }

        public string Move()
        {
            return $"Walking along";
        }


    }
}
