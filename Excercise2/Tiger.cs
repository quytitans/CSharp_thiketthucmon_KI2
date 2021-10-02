using System;

namespace Excercise2
{
    public class Tiger : Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        
        
        
        public override void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Weight {Weight}");
        }

        public override void SetMe(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}