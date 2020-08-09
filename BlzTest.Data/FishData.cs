using System;
using System.Text;

namespace BlzTest.Data
{
    public class FishData
    {
        //https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=29025000
        public static readonly string[] FishList = new[]
        {
            "Sunfish", "LargeMouth", "SmallMouth", "Northern", "Walleye", "Perch", "Musky", "Bullhead", "BlueGill", "Crappie"
        };

        public static readonly string[] LakeData = new[]
        {
            "Pickerel:1,2,3,4,5,6", "Blue:1,4,5,6", "Bottle:1,9,10", "Spider:2,3,4", "Bad Axe:4,5,6,7", "Mantrap:4,5,6,7", "Big Sand:3,5", "Ida:1,6", "Little Sand:3,4,5,10", "Potato:4,7"
        };



        public static string GetLakeFishList(int lakeIndex){

            Data.Scraper.ScrapeLakeFinder();

            var fishList = new StringBuilder();

            var lakeDataRaw = LakeData[lakeIndex];
            
            var lakeDataTokens = lakeDataRaw.Split(':');
            
            var lakeName =  lakeDataTokens[0];

            var fishArr =  lakeDataTokens[1];
            
            var fishIndexTokens = fishArr.Split(',');

//            fishList.Append($"{lakeName}:");

            foreach(string index in fishIndexTokens){
                int idx = int.Parse(index);
                fishList.Append($"{FishList[ idx  -1 ].ToString()}, ");
            }
            return fishList.ToString();
        }

    }
}
