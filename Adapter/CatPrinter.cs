using Adapter.HomeCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CatPrinter
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Кошачье досье:");
            Console.WriteLine(string.Format("Имя кота: {0}", cat.Name));
            Console.Write("Вид мяуканья: ");
            cat.Meow();
            Console.Write("Вид царапанья: ");
            cat.Scratch();
            Console.WriteLine();
        }
    }
}
