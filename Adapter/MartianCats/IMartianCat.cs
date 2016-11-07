namespace Adapter.MartianCats
{
    interface IMartianCat
    {
        string Breed { get; }
        void Purr();
        void Scratch();
    }
}
