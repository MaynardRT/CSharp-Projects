using System;
 
namespace Coding.Exercise
{
    public class MyClass
    {
        public string ReadOnlyProperty { get; }
 
        public MyClass(string value)
        {
            ReadOnlyProperty = value;
        }
    }
 
    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            MyClass myClass = new MyClass("Read-Only Property Value");
            Console.WriteLine(myClass.ReadOnlyProperty);
        }
    }
}