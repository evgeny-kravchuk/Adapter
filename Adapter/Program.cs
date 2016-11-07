using Adapter.HomeCats;
using Adapter.MartianCats;
using Adapter.WildCats;
using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            IHomeCat masha = new PedigreedCat();
            masha.Name = "Маша";
            CatPrinter.PrintCatInfo(masha);

            IHomeCat marko = new YardCat();
            marko.Name = "Марко";
            CatPrinter.PrintCatInfo(marko);

            IWildCat tiger = new Tiger();
            CatsAdapterForWild wildAdapter = new CatsAdapterForWild(tiger);
            CatPrinter.PrintCatInfo(wildAdapter);

            IMartianCat creeot = new Creeot();
            CatsAdapterForMartian martianAdapter = new CatsAdapterForMartian(creeot);
            CatPrinter.PrintCatInfo(martianAdapter);

            Console.ReadLine();
        }
    }
}
