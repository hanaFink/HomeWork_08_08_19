using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Asynchronic
{
    class WebAsinc
    {
        

        private string reply;
   
        public int Counter { get; protected set; }

        public async Task DownloadString(string address)
        {
            WebClient client = new WebClient();
            reply = client.DownloadString(address);
            Console.WriteLine(reply);
            for (int i = 0; i < reply.Length; i++)
            {
                if (reply[i] == 'a')
                    Counter++;
            }
            Console.WriteLine("number of a in this object is " + Counter);
        }
        public async Task DoWorkAsync ()
        {
            var t1 = DownloadString("http://www.walla.co.il");
            var t2 = DownloadString("http://www.ynet.co.il");
            await Task.WhenAll(t1, t2);
            Console.WriteLine("Done");


        }


    }

}
