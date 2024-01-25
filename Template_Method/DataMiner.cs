using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    abstract class DataMiner
    {
        string file;
        public string File { get => file; set => file = value; }

        string rawData;
        public string RawData { get => rawData; set => rawData = value; }

        public virtual void openFile(string path)
        {
            Console.WriteLine("Open " + path);
        }
        public virtual void closeFile()
        {
            Console.WriteLine("Close file\n");
        }
        public abstract void extractData();
        public abstract void parseData();

        public void mine(string path)
        {
            openFile(path);
            extractData();
            parseData();
            closeFile();
        }

    }
}
