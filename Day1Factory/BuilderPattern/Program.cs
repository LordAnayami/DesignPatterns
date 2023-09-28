using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
    
            static void Main(string[] args)
            {
                PDFReport pdfReport = new PDFReport();

                ReportDirector reportDirector = new ReportDirector();

                Report report = reportDirector.MakeReport(pdfReport);

                report.DisplayReport();

                Console.WriteLine("-------------------");

                ExcelReport excelReport = new ExcelReport();
                report = reportDirector.MakeReport(excelReport);
                report.DisplayReport();

                Console.ReadKey();
            }
     }
}
