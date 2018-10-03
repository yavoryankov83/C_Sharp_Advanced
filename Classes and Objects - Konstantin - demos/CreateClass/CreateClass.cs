using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Dog
    {
        public int age { get; set; }
        public string colour { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void PrintColor()
        {
            Console.WriteLine(colour);
        }
    }

    class CreateClass
    {
        static void Main(string[] args)
        {
            Dog pesho = new Dog();
            pesho.age = 18;
            pesho.colour = "white";
            pesho.PrintColor();
            
        }
    }
}
