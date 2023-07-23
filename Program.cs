namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Voice = new Voice();
            Voice.WakeUp();
            Voice.WakeUp("hina");
        }
    }
    public class Voice
    {
        public void WakeUp()
        {
            Console.WriteLine("起きなさい！");
        }

        public void WakeUp(string name)
        {
            Console.WriteLine(name + "起きなさい！");
        }
    }
}