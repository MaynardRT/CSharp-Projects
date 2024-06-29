using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintStudents()
        {
          Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

        // Add three student objects to the dictionary
        studentDictionary["John"] = new Student { Id = 1, Name = "John", Grade = 85 };
        studentDictionary["Alice"] = new Student { Id = 2, Name = "Alice", Grade = 90 };
        studentDictionary["Bob"] = new Student { Id = 3, Name = "Bob", Grade = 78 };

        // Iterate through the dictionary and print student details
        foreach (var kvp in studentDictionary)
        {
            Console.WriteLine($"Name: {kvp.Value.Name}, Id: {kvp.Value.Id}, Grade: {kvp.Value.Grade}");
        }
        }
    }
    
    public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
}
 
}
