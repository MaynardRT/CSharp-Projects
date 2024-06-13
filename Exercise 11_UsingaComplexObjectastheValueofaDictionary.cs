
using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintDictionaryValues()
        {
            // TODO
            Dictionary<int, int> My_dict1 =  
                       new Dictionary<int, int>();
                       My_dict1.Add(1, 1);
                       My_dict1.Add(2, 2);
                       My_dict1.Add(3, 3);       
            foreach(KeyValuePair<int, int> element in My_dict1)
            {
              Console.Write("{0} ",
                        element.Key, element.Value);
            }
        }
    }
}