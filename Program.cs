namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Creature dog = new Dog();
            Creature cat = new Cat();

            dog.Voice();
            cat.Voice();
        }
    }

    public class Creature
    {
        public virtual void Voice () // virtual修飾詞があると継承先で上書きできる
        {
        }
    }

    public class Dog : Creature
    {
        public override void Voice ()
        {
            Console.WriteLine ("わんわん");
        }
    }

    public class Cat : Creature
    {
        public override void Voice ()
        {
            Console.WriteLine ("ニャー");
        }
    }
}