using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace HomeWork_08_08_19
{

    class Program
    {
        public static void DownloadString(string address)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(address);

            Console.WriteLine(reply);
        }
        static void Main(string[] args)
        {
            DownloadString("http://www.ynet.co.il");
            DownloadString("http://www.walla.co.il");
        }
       
    }
}
