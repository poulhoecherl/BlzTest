using System;
using System.IO;
using System.Text;

namespace BlzTest.Data
{
    public class FishData
    {
        //https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=29025000
       
        private void loadData(){
             string location = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string filePath = Path.Combine(Path.GetDirectoryName(location),"DataFiles", "LakeIndex.csv");

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Bad LakeIndexFile path: {filePath}");
                
            // load up the lake index list
            var lakeList = _Helpers.Csv.ImportLakeIndexLine(filePath);

            foreach (var lake in lakeList)
            {

            }
        }

        public static string GetLakeFishList(int lakeIndex){

            //Data.Scraper.ScrapeLakeFinder();

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
