using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlzTest.Data
{
    public class HubbardCountyService
    {
        private static readonly string[] FishData = new[]
        {
            "Sunfish", "LargeMouth", "SmallMouth", "Northern", "Walleye", "Perch", "Musky", "Bullhead", "BlueGill", "Crappie"
        };

        private static readonly string[] LakeData = new[]
        {
            "Pickerel:1,2,3,4,5,6", "Blue:1,4,5,6", "Bottle:1,9,10", "Spider:2,3,4", "Bad Axe:4,5,6,7", "Mantrap:4,5,6,7", "Big Sand:3,5", "Ida:1,6", "Little Sand:3,4,5,10", "Potato:4,7"
        };

        public Task<HubbardCounty[]> GetLakesAsync()
        {
            var rng = new Random();
            var rngIndex = rng.Next(1,10);

            return Task.FromResult(Enumerable.Range(0, 9).Select(index => new HubbardCounty
            {
                LakeName  = LakeData[ index  ],
                FishList = GetLakeFishList( index).ToString()
            }).ToArray());
        }

        private string GetLakeFishList(int lakeIndex){

            var fishList = new StringBuilder();

            var lakeDataRaw = LakeData[lakeIndex];
            
            var lakeDataTokens = lakeDataRaw.Split(':');
            
            var fishArr =  lakeDataTokens[1];
            
            var fishIndexTokens = fishArr.Split(',');

            foreach(string index in fishIndexTokens){
                int idx = int.Parse(index);
                fishList.Append($"{FishData[ idx  -1 ].ToString()}");
            }
            return fishList.ToString();
        }
    }
}
