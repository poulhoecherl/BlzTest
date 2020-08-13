
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using BlzTest.Data.Models;

namespace BlzTest.Data.Controllers
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class LakeData{

        private List<Lake> _lakeList = null;

        public List<Lake> LakeList { 
            get{
                if(_lakeList.Any())
                    return _lakeList;
                else
                    return LoadLakeData();
            } 
        }

        public List<Lake> LoadLakeData(){

            List<Lake> reval = new List<Lake>();
            
            return reval;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}