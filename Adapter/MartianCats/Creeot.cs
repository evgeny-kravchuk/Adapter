using System;

namespace Adapter.MartianCats
{
    class Creeot : IMartianCat
    {
        public string Breed
        {
            get
            {
                return "Криот марсианский";
            }
        }
        public void Purr()
        {
            Console.WriteLine("Корли-корли");
        }
        public void Scratch()
        {
            Console.WriteLine("У меня нет когтей, я не царапаюсь");
        }
    }
}
