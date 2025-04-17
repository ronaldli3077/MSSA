namespace Mod5Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee mycoffee = new Coffee(1, "Arabica");
          
            Console.ReadKey();



            //for class4 
            string name;
            name = "ronald00";
            Console.WriteLine($"True of Flase if contains digit: {name.ContainsNumbner}");


            int i = 30;
            int j = 90;
            i.CheckValue(j); //i = 30, j = 90，调用 i.CheckValue(j)，相当于 30 > 90。
        }
    }
}
