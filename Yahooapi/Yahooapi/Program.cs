using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Yahooapi
{

    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Write in the stock you want");
            var userstock = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter start day");
            var startday = Console.ReadLine();

            Console.WriteLine("please enter start month");
            var startmonth = Console.ReadLine();

            Console.WriteLine("enter start year");
            var startyear = Console.ReadLine();

            Console.WriteLine("enter end day");
            var endday = Console.ReadLine();

            Console.WriteLine("enter end month");
            var endmonth = Console.ReadLine();

            Console.WriteLine("enter end year");
            var endyear = Console.ReadLine();

            var urlPrototype = @"http://ichart.finance.yahoo.com/table.csv?s={0}&a{1}&b={2}&c={3}&d={4}&e={5}&f={6}&g=d&ignore=.csv";

            var url = string.Format(urlPrototype, userstock, startmonth, startday, startyear, endmonth, endday, endyear);
            Console.WriteLine(url);

            //var url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22YHOO%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Console.WriteLine("{0}:{1}", i, sLine);
            }
            Console.ReadLine();
        }
    }
}

