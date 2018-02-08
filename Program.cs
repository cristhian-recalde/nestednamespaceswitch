using System;

namespace NestedNamespaceSwitch
{
    using Inner.MyNamespace;
    
    internal class Program
    {
        public static void Main(string[] args)
        {  
            Console.WriteLine("Hello World");
            MyClassSwitch c = new MyClassSwitch();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("getNum {0}:{1}", i, c.getNumber(i));    
            }
            
        }
    }
   
}