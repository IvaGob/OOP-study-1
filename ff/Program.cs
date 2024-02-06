namespace ff
{
    //Продукт
    abstract class Product
    {
        private string name;
        public Product(string name)
        {
            this.name = name;
        }
        public abstract void Action();
    }

    //Деталь
    class Detail : Product
    {
        private string name;
        public Detail(string name) : base(name)
        {
            this.name = name;
        }
        public override void Action()
        {
            Console.WriteLine($"Маленька деталь під назвою: {name}");
        }
    }

    //Механізм
    class Gear : Product
    {
        public string name;
        public Gear(string name) : base(name)
        {
            this.name = name;
        }
        public override void Action()
        {
            Console.WriteLine($"Механізм під назвою: {name}");
        }
    }

    //Вузол
    class Assembly : Product
    {
        private string name;
        public Assembly(string name) : base(name)
        {
            this.name = name;
        }
        public override void Action()
        {
            Console.WriteLine($"Великий вузол під назвою: {name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Product product;
            Console.WriteLine("Введіть назву деталі:");
            product = new Detail(Console.ReadLine());
            product.Action();
            Console.WriteLine("Введіть назву механізму:");
            product = new Gear(Console.ReadLine());
            product.Action();
            Console.WriteLine("Введіть назву вузла:");
            product = new Assembly(Console.ReadLine());
            product.Action();
        }
    }
}
