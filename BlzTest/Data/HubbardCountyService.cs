using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlzTest.Data;
using BlzTest.Data.Models;

namespace BlzTest.Service
{
    public class HubbardCountyService
    {
        public Task<LakeIndexLine[]> GetLakesAsync()
        {
            var rng = new Random();
            var rngIndex = rng.Next(1,10);

            return Task.FromResult(Enumerable.Range(0, 9).Select(index => new LakeIndexLine
            {
                LakeName  =  FishData.LakeData[ index  ],
                //FishList = FishData.GetLakeFishList( index).ToString()
                FishList = FishData.GetLakeFishList(index).ToString()
            }).ToArray());
        }

        
    }
}
