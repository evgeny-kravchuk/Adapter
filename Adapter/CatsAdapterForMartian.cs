using Adapter.HomeCats;
using Adapter.MartianCats;

namespace Adapter
{
    class CatsAdapterForMartian : IHomeCat
    {
        private IMartianCat _martianCat;

        public CatsAdapterForMartian(IMartianCat martianCat)
        {
            _martianCat = martianCat;
        }
        public string Name
        {
            get
            {
                return _martianCat.Breed;
            }
            set { }
        }
        public void Meow()
        {
            _martianCat.Purr();
        }
        public void Scratch()
        {
            _martianCat.Scratch();
        }
    }
}
