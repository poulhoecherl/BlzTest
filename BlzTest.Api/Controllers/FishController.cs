using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlzTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FishDataController: ControllerBase
    {
        //https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=29025000
        private static readonly string[] FishList = new[]
        {
            "Sunfish", "LargeMouth", "SmallMouth", "Northern", "Walleye", "Perch", "Musky", "Bullhead", "BlueGill", "Crappie"
        };

        private static readonly string[] LakeData = new[]
        {
            "Pickerel:1,2,3,4,5,6", "Blue:1,4,5,6", "Bottle:1,9,10", "Spider:2,3,4", "Bad Axe:4,5,6,7", "Mantrap:4,5,6,7", "Big Sand:3,5", "Ida:1,6", "Little Sand:3,4,5,10", "Potato:4,7"
        };

        private readonly ILogger<FishDataController> _logger;

        public FishDataController(ILogger<FishDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            int lakeIndex = 1;

            var fishList = new StringBuilder();

            LakeData = Data.LoadLakeData();

            //Data.Scraper.ScrapeLakeFinder();
            //Data.Scraper.ScrapeWiki();

            var lakeDataRaw = LakeData[lakeIndex];

            var lakeDataTokens = lakeDataRaw.Split(':');

            var lakeName = lakeDataTokens[0];

            var fishArr = lakeDataTokens[1];

            var fishIndexTokens = fishArr.Split(',');

            //            fishList.Append($"{lakeName}:");

            foreach (string index in fishIndexTokens)
            {
                int idx = int.Parse(index);
                fishList.Append($"{FishList[idx - 1]}, ");
            }
            return fishList.ToString();
        }
    }
}
