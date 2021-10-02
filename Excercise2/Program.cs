namespace Excercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.SetMe("tiger", 100);
            tiger.Show();
            Lion lion = new Lion();
            lion.SetMe("lion", 200);
            lion.Show();
        }
    }
}