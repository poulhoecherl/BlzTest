using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlzTest.Data
{
    public class HubbardCountyService
    {
        private static readonly string[] FishList = new[]
        {
            "Sunfish", "LargeMouth", "SmallMouth", "Northern", "Walleye", "Perch", "Musky", "Bullhead", "BlueGill", "Crappie"
        };

        private static readonly string[] LakeList = new[]
        {
            "Pickerel", "Blue", "Bottle", "Spider", "Bad Axe", "Mantrap", "Big Sand", "Ida", "Little Sand", "Potato"
        };

        public Task<HubbardCounty[]> GetLakesAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new HubbardCounty
            {
                LakeName  = LakeList[ rng.Next(1,10) ],
                FishList = FishList[ rng.Next(1,10) ]
            }).ToArray());
        }
    }
}
