using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo() 
        {
            Console.WriteLine(Name);
            Say();
        }

    }
    class Cat : Animal
    {
        private string voice;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name, string voice)
            : base(name)
        {
            this.voice = voice;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
            private string voice;
            private string name;
            public override string Name
            {
                get => name;
                set => name = value;
            }
            public Dog(string name, string voice)
                : base(name)
            {
                this.voice = voice;
            }
            public override void Say()
            {
                Console.WriteLine("Гав");
            }
        } 
    }

