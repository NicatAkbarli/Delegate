using NewTask.Generic;
using NewTask.model;

namespace NEWTASK
{
    internal class Program
    {
        //Task 1

        // static void Main()
        // {
        //     var storage = new StorageManager<Product>();

        //     storage.AddItem(new Product { Name = "Telefon" });
        //     storage.AddItem(new Product { Name = "Noutbuk" });

        //     storage.GetAll();

        //     var found = storage.FindByIndex(1);
        //     Console.WriteLine("Tapılan: " + found);
        // }


        //Task 2
        //  static void Main()
        // {
        //     var intCalc = new Calculator<int>();
        //     Console.WriteLine("Int toplama: " + intCalc.Add(5, 7));
        //     Console.WriteLine("Int hasil: " + intCalc.Multiply(3, 4));

        //     var doubleCalc = new Calculator<double>();
        //     Console.WriteLine("Double toplama: " + doubleCalc.Add(2.5, 3.7));
        //     Console.WriteLine("Double hasil: " + doubleCalc.Multiply(1.2, 2.5));

        //     var floatCalc = new Calculator<float>();
        //     Console.WriteLine("Float toplama: " + floatCalc.Add(1.5f, 2.5f));
        //     Console.WriteLine("Float hasil: " + floatCalc.Multiply(2.2f, 3.3f));
        // }


        //Task3
        //  static void Main()
        // {
        //     var intComparer = new DataComparer<int>();
        //     Console.WriteLine("Max (int): " + intComparer.FindMax(10, 25));
        //     Console.WriteLine("Min (int): " + intComparer.FindMin(10, 25));

        //     var doubleComparer = new DataComparer<double>();
        //     Console.WriteLine("Max (double): " + doubleComparer.FindMax(3.14, 2.72));
        //     Console.WriteLine("Min (double): " + doubleComparer.FindMin(3.14, 2.72));

        //     var stringComparer = new DataComparer<string>();
        //     Console.WriteLine("Max (string): " + stringComparer.FindMax("Apple", "Banana"));
        //     Console.WriteLine("Min (string): " + stringComparer.FindMin("Apple", "Banana"));
        // }

        //Task 4
        //  static void Main()
        // {
        //     var stringPrinter = new GenericPrinter<string>();
        //     stringPrinter.PrintItem("Salam, Baba!");
        //     stringPrinter.PrintList(new List<string> { "A", "B", "C" });

        //     var intPrinter = new GenericPrinter<int>();
        //     intPrinter.PrintItem(42);
        //     intPrinter.PrintList(new List<int> { 10, 20, 30 });

        //     var personPrinter = new GenericPrinter<Person>();
        //     var people = new List<Person>
        //     {
        //         new Person { Name = "Nicat", Age = 22 },
        //         new Person { Name = "Baba", Age = 25 }
        //     };
        //     personPrinter.PrintList(people);
        // }



        //Task 5
        //  static void Main()
        // {
        //     var repo = new Repository<Product>();

        //     // Əlavə edirik
        //     repo.Add(new Product { Name = "Telefon" });
        //     repo.Add(new Product { Name = "Noutbuk" });
        //     repo.Add(new Product { Name = "Planşet" });

        //     Console.WriteLine("Bütün elementlər:");
        //     repo.GetAll();

        //     Console.WriteLine("\nElement sayı: " + repo.Count());

        //     // İndeksə görə silirik
        //     repo.RemoveAt(1);

        //     Console.WriteLine("\nSilindikdən sonra elementlər:");
        //     repo.GetAll();
        //     Console.WriteLine("Element sayı: " + repo.Count());
        // }

    }
}
