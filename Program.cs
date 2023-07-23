namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Person = new Person("A", 5);
        }
    }
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}