namespace HelloWorld
{
    public class Program
    {
        public delegate void Test(string s);
        public static void Main(string[] args)
        {
            var test = new Test(TestMethod1);
            test += new Test(TestMethod2);
            test("yes");
        }

        public static void TestMethod1 (string s)
        {
            Console.WriteLine(s + "!");
        }

        public static void TestMethod2 (string s)
        {
            Console.Write(s + "!!!");
        }
    }
}