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
        protected string Name;
        // private string Name;　とすると継承さきでは使えない
    }

    public class Anonatsu:Person
    {
        public string Hobby = "Programming";

        public void SelfIntroduction()
        {
            Name = "あの夏";
            Console.WriteLine(Name + "です。趣味は" + Hobby + "です。");
        }
    }

    public class Dummy
    {
        public void SelfIntroduction()
        {
            var person = new Person();
            // person.Name = "test";
            // ↑ 継承していないので使えない
        }
    }
}