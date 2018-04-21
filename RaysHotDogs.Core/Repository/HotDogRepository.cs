using RaysHotDogs.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
           new HotDogGroup()
           {
               HotDogGroupId = 1, Title = "Meat lovers", ImagePath = "", HotDogs = new List<HotDog>()
               {
                   new HotDog()
                   {
                       HotDogId = 1,
                       Name = "Regular Hot Dog",
                       ShortDescription = "Him from pile dote pride of ever hellas made thy favour and caught before drop hill steel of longdeserted nine",
                       ImagePath ="hotdog1",
                       Available = true,
                       PrepTime = 10,
                       Ingredients = new List<string>(){ "Regular bun", "Sausage", "Ketchup"},
                       Price = 8,
                       IsFavorite = true
                   },
                   new HotDog()
                   {
                       HotDogId = 2,
                       Name = "Regular Hot Dog 2",
                       ShortDescription = "Him from pile dote pride of ever hellas made thy favour and caught before drop hill steel of longdeserted nine",
                       ImagePath ="hotdog1",
                       Available = true,
                       PrepTime = 10,
                       Ingredients = new List<string>(){ "Regular bun", "Sausage", "Ketchup"},
                       Price = 8,
                       IsFavorite = false
                   },
                   new HotDog()
                   {
                       HotDogId = 3,
                       Name = "Regular Hot Dog 3",
                       ShortDescription = "Him from pile dote pride of ever hellas made thy favour and caught before drop hill steel of longdeserted nine",
                       ImagePath ="hotdog1",
                       Available = true,
                       PrepTime = 10,
                       Ingredients = new List<string>(){ "Regular bun", "Sausage", "Ketchup"},
                       Price = 8,
                       IsFavorite = false
                   }

               }
           },
           new HotDogGroup()
           {
               HotDogGroupId = 1, Title = "Veggie lover", ImagePath = "", HotDogs = new List<HotDog>()
               {
                   new HotDog()
                   {
                       HotDogId = 4,
                       Name = "Regular Veggie Hot Dog",
                       ShortDescription = "Him from pile dote pride of ever hellas made thy favour and caught before drop hill steel of longdeserted nine",
                       ImagePath ="hotdog1",
                       Available = true,
                       PrepTime = 10,
                       Ingredients = new List<string>(){ "Regular bun", "Sausage", "Ketchup"},
                       Price = 8,
                       IsFavorite = true
                   },
                   new HotDog()
                   {
                       HotDogId = 5,
                       Name = "Regular Veggie Hot Dog 2",
                       ShortDescription = "Him from pile dote pride of ever hellas made thy favour and caught before drop hill steel of longdeserted nine",
                       ImagePath ="hotdog1",
                       Available = true,
                       PrepTime = 10,
                       Ingredients = new List<string>(){ "Regular bun", "Sausage", "Ketchup"},
                       Price = 8,
                       IsFavorite = false
                   },
                   new HotDog()
                   {
                       HotDogId = 6,
                       Name = "Regular Veggie Hot Dog 3",
                       ShortDescription = "Him from pile dote pride of ever hellas made thy favour and caught before drop hill steel of longdeserted nine",
                       ImagePath ="hotdog1",
                       Available = true,
                       PrepTime = 10,
                       Ingredients = new List<string>(){ "Regular bun", "Sausage", "Ketchup"},
                       Price = 8,
                       IsFavorite = false
                   }
               }
           }
        };

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                select hotDog;

            return hotDogs.ToList<HotDog>();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == hotDogId
                select hotDog;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            var group = hotDogGroups.Where(x => x.HotDogGroupId == hotDogGroupId).FirstOrDefault();

            return group.HotDogs ?? null;
        }

        public List<HotDog> GetFavoriteHodDogs()
        {
            IEnumerable<HotDog> hotDogs = 
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.IsFavorite
                select hotDog;

            return hotDogs.ToList<HotDog>(); 
        }
    }
}