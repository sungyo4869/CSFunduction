namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var anonatsu = new Anonatsu();
            anonatsu.SelfIntroduction();

        }

    }

    public class Person
    {
        public string Name;

        public void SelfIntroduction()
        {
            Console.WriteLine("I'm a Person.");
        }
    }

    public class Anonatsu:Person
    {
        public void SelfIntroduction()
        {
            base.SelfIntroduction();
            // 継承元のSelfIntroductionが呼ばれる
            
            Name = "anonatsu";
            Console.WriteLine("I'm " + Name + ".");
        }
    }
}