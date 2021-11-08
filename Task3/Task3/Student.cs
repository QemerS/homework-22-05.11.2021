using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Student
    {
        private static int instanceCount
        {
            get
            {
                return instanceCount;
            }
            set
            {
                value = 0;
            }
        }
        public Student()
        {
            instanceCount++;
        }
        public static void ShowInstanceCount()
        {
            Console.WriteLine("Say: " + instanceCount);
        }
    }
}
