namespace HelloWorld
{
    public class Program
    {
        public delegate void Test(string s);
        public static void Main(string[] args)
        {
            var test1 = (string s) => Console.WriteLine(s + "!");
            var test2 = () => Console.WriteLine("yaho");
            var test3 = () => 1;   // {return 1;} ともかける

            test1("yes");
            test2();
            Console.WriteLine(test3());
        }
    }
}