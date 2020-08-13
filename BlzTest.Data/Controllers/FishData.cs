using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BlzTest.Data.ViewModels;

namespace BlzTest.Data.Controllers
{
    public class FishData
    {
        //https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=29025000
       
        public List<FishDto> GetLakeFishList(int lakeIndex){

            var fishData = new Data.Controllers.FishData();
            var lakeData = new Data.Controllers.LakeData();
            var lake = lakeData.LakeList.Where(m => m.Id == lakeIndex);
            var fishForLake = new List<FishDto>(); //TODO
            return fishForLake.ToList();
        }

    }
}
