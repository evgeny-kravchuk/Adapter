using System;

namespace Adapter.WildCats
{
    class Tiger : IWildCat
    {
        public string Breed
        {
            get
            {
                return "Тигр обыкновенный";
            }
        }
        public void Growl()
        {
            Console.WriteLine("Гррр");
        }
        public void Scratch()
        {
            Console.WriteLine("Я убиваю царапаньем");
        }
    }
}
