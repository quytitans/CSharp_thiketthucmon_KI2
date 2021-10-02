using System;

namespace Excercise2
{
    public class Lion : Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        
        public override void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Weight {Weight}");
        }

        public override void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}