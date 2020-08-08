using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlzTest.Data;

namespace BlzTest.Service
{
    public class HubbardCountyService
    {
        public Task<HubbardCounty[]> GetLakesAsync()
        {
            var rng = new Random();
            var rngIndex = rng.Next(1,10);

            return Task.FromResult(Enumerable.Range(0, 9).Select(index => new HubbardCounty
            {
                LakeName  =  FishData.LakeData[ index  ],
                FishList = FishData.GetLakeFishList( index).ToString()
            }).ToArray());
        }

        
    }
}
