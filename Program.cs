namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var anonatsu = new Anonatsu();
            anonatsu.hobby = "sleep";
            anonatsu.Name = "anonatsu";

            Console.WriteLine(anonatsu.Name);

            anonatsu.sayHi();
        }
    }

    public class Person
    {
        public string Name;
        public void sayHi()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Anonatsu:Person
    {
        public string hobby;
    }
}