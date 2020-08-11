using System.Threading.Tasks;
using BlzTest.Data.Models;

namespace BlzTest.Service
{
    public class LakeService
    {
        public async Task<LakeIndexLine[]> GetLakesAsync()
        {
            var data = new Data.Loader();
            return await Task.FromResult(data.LoadLakeData().ToArray());
        }

        
    }
}
