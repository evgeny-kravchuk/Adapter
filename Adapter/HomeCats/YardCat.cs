using System;

namespace Adapter.HomeCats
{
    class YardCat : IHomeCat
    {
        public string Name { get; set; }
        public void Meow()
        {
            Console.WriteLine("Мяяяяу-мяяяу-мяяяу!");
        }
        public void Scratch()
        {
            Console.WriteLine("Я царапаюсь только для защиты");
        }
    }
}
