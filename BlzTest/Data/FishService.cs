using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BlzTest.Data.Models;
using BlzTest.Data.ViewModels;

namespace BlzTest.Service
{
    public class FishService
    {
        public async Task<FishDto[]> GetFishForLakeAsync(int LakeId)
        {
            var data = new Data.Controllers.FishData();
            
            var fishes = (from x in data.GetLakeFishList(LakeId) select x).ToArray();

            return await Task.FromResult( fishes );
        }

        
    }
}
