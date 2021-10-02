using System.Security.Cryptography;

namespace Excercise2
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public abstract void Show();

        public abstract void SetMe(string name, double weight);
    }
}