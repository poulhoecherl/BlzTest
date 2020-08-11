
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using BlzTest.Data._Helpers;
using BlzTest.Data.Models;

namespace BlzTest.Data
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Loader{

        private List<LakeIndexLine> _lakeList = null;

        public List<LakeIndexLine> LakeList { 
            get{
                if(LakeList.Any())
                    return LakeList;
                else
                    return LoadLakeData();
            } 
        }

        public List<LakeIndexLine> LoadLakeData(){
            
            if(_lakeList.Any())
                return LakeList;

            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string filePath = Path.Combine(Path.GetDirectoryName(location),"DataFiles", "LakeIndex.csv");

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Bad LakeIndexFile path: {filePath}");
                
            // load up the lake index list
            _lakeList = Csv.LoadLakeData(filePath);

            return _lakeList;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}