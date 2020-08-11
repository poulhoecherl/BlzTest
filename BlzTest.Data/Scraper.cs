using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace BlzTest.Data
{
    public class Scraper
    {
        private string Title { get; set; }
        private string Url { get; set; }
        
        
        
        public string[] QueryTerms { get; } = { "" };

        public static async void ScrapeLakeFinder()
        {
            
            var config = Configuration.Default.WithXml();

            string surveyAddy = "https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=";

            string lakeAddy = "https://www.dnr.state.mn.us/lakefind/lake.html?id=";

            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string filePath = Path.Combine(Path.GetDirectoryName(location),"DataFiles", "LakeIndex.csv");

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Bad LakeIndexFile path: {filePath}");
                
            // load up the lake index list
            var lakeList = _Helpers.Csv.LoadLakeData(filePath);

            foreach (var lake in lakeList)
            {
                string address = $"{lakeAddy}{lake.DnrNumber}";

                var document = await BrowsingContext.New(config).OpenAsync(address);

                // This CSS selector gets the desired content
                var cellSelector = "#lake > div.row.clearfix > div:nth-child(1)";
                
                // Perform the query to get all cells with the content
                var cells = document.QuerySelectorAll(cellSelector);
                
                // We are only interested in the text - select it with LINQ
                var titles = cells.Select(m => m.TextContent);

                Debug.WriteLine("Overall {0} titles found...", titles.Count());

                foreach (var title in titles)
                    Debug.WriteLine("* {0}", title.Trim(new[] { '"' }));

            }
        }

        public static async void ScrapeWiki()
        {
            var config = Configuration.Default.WithDefaultLoader();

            string address = $"http://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";

            var document = await BrowsingContext.New(config).OpenAsync(address);
            // This CSS selector gets the desired content
            var cellSelector = "tr.vevent td:nth-child(3)";
            // Perform the query to get all cells with the content
            var cells = document.QuerySelectorAll(cellSelector);
            // We are only interested in the text - select it with LINQ
            var titles = cells.Select(m => m.TextContent);

            Console.WriteLine("Overall {0} titles found...", titles.Count());

            foreach (var title in titles)
                Debug.WriteLine("* {0}", title.Trim(new[] { '"' }));

        }

        private static string GetScrapeResults(IHtmlDocument document)
        {
            //string targetClassName = "region region-content"; // "field field--name-field-content field--type-text-long field--label-hidden field--item";
            IEnumerable<IElement> articleLink = new List<IElement>();

            var bold = document.QuerySelector("b");

            if (bold != null && bold.HasTextNodes())
            {
                Debug.WriteLine(bold.TextContent);
            }
            //foreach (var term in bold)
            //{

            //    articleLink = document.All.Where(x => x.Id == "lake"); //document.All.Where(x => x.ClassName == targetClassName); //&& (x.ParentElement.InnerHtml.Contains(term) || x.ParentElement.InnerHtml.Contains(term.ToLower()))
            ////}

            //if (articleLink.Any())
            //{
            //    // Print Results: See Next Step
            //    return PrintResults(articleLink);
            //}

            return string.Empty;
        }

        
        
        List<Tuple<string, string>> fishList = new List<Tuple<string, string>>();


        public static string PrintResults(IEnumerable<IElement> articleLink)
        {
            var sb = new StringBuilder();

            // Clean Up Results: See Next Step
            foreach(var elem in articleLink)
            {
                //Tuple<string, string> fishCsv = new Tuple<string, string>($"{} - {Url}{Environment.NewLine}";
                Debug.WriteLine(elem.InnerHtml);
                sb.Append(elem.InnerHtml);
            }
            return sb.ToString();
        }
    }
}
