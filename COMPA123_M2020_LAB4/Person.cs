using System;
using System.Collections.Generic;
using System.Text;

namespace COMPA123_M2020_LAB4
{
    class Person
    { 
           public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void SaysHello()
            {
                Console.WriteLine($"{Name} says Hello");

            }


        }
    }


