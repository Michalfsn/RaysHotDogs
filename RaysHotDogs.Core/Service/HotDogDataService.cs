using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaysHotDogs.Core.Service
{
    public class HotDogDataService
    {
        private static HotDogRepository _hotDogRepository = new HotDogRepository();

        public List<HotDog> GetAllHotDogs()
        {
            return _hotDogRepository.GetAllHotDogs();
        }

        public List<HotDogGroup> GetHotDogGroups()
        {
            return _hotDogRepository.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            return _hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            return _hotDogRepository.GetFavoriteHodDogs();
        }

        public HotDog GetHodDogById(int hotDogId)
        {
            return _hotDogRepository.GetHotDogById(hotDogId);
        }


    }
}
