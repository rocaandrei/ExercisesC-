using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Sending a text message...");
        }
    }
}
