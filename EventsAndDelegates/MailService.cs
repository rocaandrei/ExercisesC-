using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService//5. aceasta calasa este destinata sa tina un subscriber pentru ce se va abona la event-ul nostru
    {
        //6. MailService va fi subscris la evenimentul VideoEncoder
        public void OnVideoEncoded(object source, EventArgs e)// acesta este un event handeler
        {
            Console.WriteLine("Mail service, sending an email...");
        }
    }
}
