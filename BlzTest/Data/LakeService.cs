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
            
            var lakes = (from x in data.LakeList select x).ToArray();

            foreach(var lake in lakes)
            {

            }
            return await Task.FromResult(reval);
        }

        
    }
}
