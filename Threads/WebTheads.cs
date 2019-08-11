using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace Threads
{
    class WebTheads
    {

        private string reply;
        private string address;
        public int Counter { get; protected set;}

        public WebTheads(string address)
        {
            this.address = address;
        }
        public void DownloadString()
        {
            WebClient client = new WebClient();
            reply = client.DownloadString(this.address);
            Console.WriteLine(reply);
            for (int i = 0; i < reply.Length; i++)
            {
                if (reply[i] == 'a')
                    Counter++;
            }
            Console.WriteLine("number of a in this object is"+Counter);
        }



    }
}
