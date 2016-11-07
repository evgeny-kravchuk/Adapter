using Adapter.HomeCats;
using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            IHomeCat Masha = new PedigreedCat();
            Masha.Name = "Маша";
            CatPrinter.PrintCatInfo(Masha);

            IHomeCat Marko = new YardCat();
            Marko.Name = "Марко";
            CatPrinter.PrintCatInfo(Marko);

            Console.ReadLine();
        }
    }
}
