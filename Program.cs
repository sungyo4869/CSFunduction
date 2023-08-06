namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var anonatsu = new Anonatsu();
            anonatsu.SayHi();
        }
    }

    public sealed class Person
    {
        public string Name;
    }

    // public class Anonatsu : Person
    // {
        
    // }
    // sealedがついてるから継承できない
}