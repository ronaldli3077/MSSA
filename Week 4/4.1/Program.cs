namespace Mod4GenericsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * List
             * Q
             * Stack
             * Dictionary
             * SortedDictionary
             * 
             * 
             */

            Stack<int> intstack= new Stack<int>();
            
            Queue<string> customerQ = new Queue<string>();
            customerQ.Enqueue("alex");

            Dictionary<string,string> Recipes = new Dictionary<string,string>();
            Recipes.Add("Clear Soup", "1.Boil broth..");
            Recipes.Add("FRied Chicken", "1. Clean chciken..");

            foreach(var key in Recipes.Keys)
            {
                Console.WriteLine(key + "-" + Recipes[key]);
            }
            Recipes.Remove("Clear Soup");


            Dictionary<string,Person>phoneBook= new Dictionary<string,Person>();
            if (phoneBook.ContainsKey("Deepali"))
            {
                Console.WriteLine("Person exists");
            }
            else
            {
                phoneBook.Add("Deepali", new Person() { FirstName = "Deepali", LastName = "K", HomePhone = 433434 });

            }


            
        }
    }
}
