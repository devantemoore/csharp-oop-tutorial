using System;

namespace csharp_oop_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Animal{
        public string Name {get; set;} // public properties & methods can be declared inside and out the class
        public string Sound {get; set;}
        private int Age {get; set;} // private properties & methods can only be declared INSIDE the class

        public void SetAge(int age){
            this.Age = age;
        }
    }
}
