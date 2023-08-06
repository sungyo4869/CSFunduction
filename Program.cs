namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var anonatsu = new Anonatsu("anonatsu");

            anonatsu.SayHi();

            // var person = new Person();
            // ↑ は出来ない (抽象クラスだから)
        }
    }

    public abstract class Person
    {
        protected string _name;

        public Person(string name)
        {
            _name = name;
        }

        public abstract void SayHi();
        // メソッド名と戻り値だけ書く
    }

    public class Anonatsu : Person
    {
        public Anonatsu(string name) : base(name)
        {
        }

        public override void SayHi()
        {
            Console.WriteLine("I'm " + _name);
        }
    }
}