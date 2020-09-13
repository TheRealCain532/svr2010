using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svr2010
{
    public class FinisherData
    {
        private fEdit fs;
        private uint p; 
        public string Finisher { get { return fs.ReadString(p + 16); } set { fs.WriteBytes(p + 16, new byte[32]); fs.WriteString(p + 16, value); } }
        public FinisherData(string filename, uint entry) { fs = new fEdit(filename); p = entry; }
    }
}
