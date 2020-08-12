using System.Threading.Tasks;
using BlzTest.Data.Models;

namespace BlzTest.Service
{
    public class LakeService
    {
        public async Task<Lake[]> GetLakesAsync()
        {
            var data = new Data.LakeData();
            return await Task.FromResult(data.LoadLakeData().ToArray());
        }

        
    }
}
