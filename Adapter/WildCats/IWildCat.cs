namespace Adapter.MartianCats
{
    interface IWildCat
    {
        string Breed { get; }
        void Growl();
        void Scratch();
    }
}
