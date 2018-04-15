using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Titlu film" };
            var videoEncoder = new VideoEncoder();// acesta este publisher-ul nostru, ce va comunica si va trimite info catre subscriberi
            var mailService = new MailService();// acesta este un subscriber la publisher-ul de mai sus
            var messageService = new MessageService();
            //7. subscribtia ce sa va produce va fi reprezentata in felul de mai jos: 
            videoEncoder.videoEncoded += mailService.OnVideoEncoded;//mai intai facem subscritia si chemama metoda folosind [+= ] ca sa inregistram handlerul la event !! nosta nu avem paranteze petru ca nu chemama metoda din MailService doar ne legam de ea facem o referinta un pointer
            videoEncoder.videoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
