/* 
 we have three options for sorting 
i) using listobj.Sort()
ii) Use Icomparable
iii) use comparer

here in example I use Icomparable to the class Person
here in example I use Icomparer to the class Person2

hence if required Icomparable sort can be overload with Icomparer to sort the value as given below 


 
 */


using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
        if (this.Age > other.Age) 
                return 1;
        else if (this.Age < other.Age)
                return -1;                  // if we want to descend this sort just inverse the value to -1 to 1 and 1 to -1
        else
                return 0;
        
        }
    }

    public class Person2 : IComparer<Person>
    {
        public string Name { get; set; }    
        public int Age { get; set; }

        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
             
        }
    }
    internal class Icomparable_sample
    {
        
            public static void Main()
            {

            Person people1 = new Person { Name = "Alice", Age = 30 };
            Person people2 = new Person { Name = "Bob", Age = 35 };
            Person people3 = new Person { Name = "Charlie", Age = 25 };  
            List<Person> person=new List<Person>() { people1,people2,people3 };
           
            //this is the object for the second class comparer
            Person2 obj = new Person2();

            person.Sort();

           // person.Sort(obj);     // This will create an error if we doesnt use Icomparable ,because of un event data types in class type
                                  // person.Reverse();    // to reverse the sort in alternate way

            Console.WriteLine("this first sorting method using Icomparable and Icomparer");
            foreach (var people in person)
            {
              
                Console.WriteLine($"{people.Name}, {people.Age}");

            }

            Person2 obj2= new Person2();    // to perform the mentioned index sorting 

            person.Sort(1, 2, obj2);        // in parameter - 1 is the starting index , 2 is the no of rows to be sorted as per obj2

            Console.WriteLine(" this second sorting method use selectively index sortig ");
            foreach (var people in person)
                {
                
                    Console.WriteLine($"{people.Name}, {people.Age}");
                
                }
            Console.ReadLine();
        }
        }
    }

