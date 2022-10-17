using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Васька","Мяу");
           cat.ShowInfo();
            Dog dog = new Dog("Филька","Гав");
           dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
