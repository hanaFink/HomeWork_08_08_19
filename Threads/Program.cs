using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class Program
    {

        static void Main(string[] args)
        {
            WebTheads site = new WebTheads("http://www.ynet.co.il");
           WebTheads site1 = new WebTheads("http://www.walla.co.il");
            Thread thread = new Thread(site.DownloadString);
           Thread thread1 = new Thread(site1.DownloadString);
            thread.Start();
            thread1.Start();



        }
    }
}
