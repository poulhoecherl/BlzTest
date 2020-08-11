using System;
using System.IO;
using System.Linq;
using System.Text;

namespace BlzTest.Data
{
    public class FishData
    {
        //https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=29025000
       
        public static string GetLakeFishList(int lakeIndex){

            var data = new Data.Loader();
            var lakeInfo = data.LakeList.Where(m => m.Id == lakeIndex.ToString()).SingleOrDefault();
            return lakeInfo.FishList;
        }

    }
}
