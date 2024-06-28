using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO
             Person person = new Person("John", 30);
             person.Greet();
        }
    }

     public class Person
 {
     private string _name;
     private int _age;

     public Person()
     {
         
     }
     public Person(string name, int age)
     {
         Name = name;
         Age = age;
     }

     public string Name { get; set; }
     public int Age { get; set; }
    
     public void Greet()
     {
         Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
     }
    
 }
}
