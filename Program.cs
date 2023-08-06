namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 二通り書き方がある
            var list1 = new List<string>();

            list1.Add("a");
            list1.Add("b");
            list1.Add("c");

            var list2 = new List<string>
            {
                "a", "b", "c"
            };

            var array = new string[3] {"a", "b", "c"};

            Console.WriteLine(list1[0]);
        }
    }
}