using System;

namespace Adapter.HomeCats
{
    class PedigreedCat : IHomeCat
    {
        public string Name { get; set; }
        public void Meow()
        {
            Console.WriteLine("Мур-мяу-мур");
        }
        public void Scratch()
        {
            Console.WriteLine("Я не царапаюсь, я хороший");
        }
    }
}
