using System.Reflection;

namespace Collections
{
    internal class Program
    {
        static void Main()
        {
            OtusDictionary dict = new();
            
            dict.Add(1,"Сережа");
            dict.Add(1, "Саша");
            dict.Add(-1, "Ваня");
            dict.Add(33, "Василий");
            //dict.Add(3, null);

            dict.Add(6, "Сбрил брови сыну");
            dict.Add(11, "Зачем");
            dict.Add(16, "Не объяснив причину");
            

            Console.WriteLine(dict.Get(1));
            Console.WriteLine(dict.Get(6));
            Console.WriteLine(dict.Get(11));
            Console.WriteLine(dict.Get(16));

            Console.WriteLine($"Несуществующий элемент: {dict.Get(21)}");
            Console.ReadKey();

        }
    }
}
