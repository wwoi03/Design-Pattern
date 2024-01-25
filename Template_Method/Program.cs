using System;
using Template_Method;

class Program
{
    static void Main()
    {
        PDFDataMiner pdfDataMiner = new PDFDataMiner();
        pdfDataMiner.mine("pdf path");

        CSVDataMiner csvDataMiner = new CSVDataMiner();
        csvDataMiner.mine("csv path");
    }
}