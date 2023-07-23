namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new Test();
            test1.a = 3;
            Console.WriteLine(test1.a); //　>> 3
            Console.WriteLine(Test.b);  //  >> 6  Testクラスの中のbという指定方法

            var test2 = new Test();
            Console.WriteLine(test2.a); //  >> 5
        }
    }

    public class Test
    {
        public int a = 5;
        public static int b = 6;


    }
}