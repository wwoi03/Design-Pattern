using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class CSVDataMiner : DataMiner
    {
        public override void extractData()
        {
            Console.WriteLine("Extract CSV");
        }

        public override void parseData()
        {
            Console.WriteLine("Parse CSV");
        }
    }
}
