using Adapter.HomeCats;
using Adapter.WildCats;

namespace Adapter
{
    class CatsAdapter : IHomeCat
    {
        private IWildCat _wildCat;

        public CatsAdapter(IWildCat wildCat)
        {
            _wildCat = wildCat;
        }
        public string Name
        {
            get
            {
                return _wildCat.Breed;
            }
            set { }
        }
        public void Meow()
        {
            _wildCat.Growl();
        }
        public void Scratch()
        {
            _wildCat.Scratch();
        }
    }
}
