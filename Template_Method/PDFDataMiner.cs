using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class PDFDataMiner : DataMiner
    {
        public override void openFile(string path)
        {
            base.openFile(path);
            this.File = "PDF";
        }
        public override void extractData()
        {
            Console.WriteLine("Extract " + this.File);
            this.RawData = "PDF";
        }

        public override void parseData()
        {
            Console.WriteLine("Parse " + this.RawData);
        }
    }
}
