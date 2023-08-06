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

    public interface IPerson
    // インターフェースは暗黙の了解的にIを入れる
    {
        public void SayHi();
    }
    public interface ICreature
    {
        public string Voice();
    }

    public class Anonatsu : IPerson, ICreature
    // 抽象クラスと違って二つ以上継承できる
    {
        public void SayHi()
        {
            Console.WriteLine("I'm anonatsu");
        }

        public void Voice()
        {
            
        }
    }
}