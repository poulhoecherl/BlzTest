using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BlzTest.Data.Models;
using BlzTest.Data.ViewModels;

namespace BlzTest.Service
{
    public class LakeService
    {
        public async Task<List<LakeDto>> GetLakesAsync()
        {
            List<LakeDto> reval = new List<LakeDto>();

            var data = new Data.Controllers.LakeData();
            var fishData = new Data.Controllers.FishData();

            var lakes = (from x in data.LakeList select x).ToArray();

            foreach(var lake in lakes)
            {
                var newLake = new LakeDto() { Id = lake.Id, County = lake.County, DnrNumber = lake.DnrNumber, EcoRegion = lake.EcoRegion, IsSentinel = lake.IsSentinel, LakeName = lake.LakeName, Tier = lake.Tier };
                var fishes = (from x in fishData.GetLakeFishList(lake.Id) select x).ToList();
                newLake.FishList = fishes;
                reval.Add(newLake);
            }
            return await Task.FromResult(reval);
        }

        
    }
}
