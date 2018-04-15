using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // aici o sa implementam event-ul nostru, ce va avea actiunea de a notifica toti subscriberii abonati la event:
        //[Scurt rezumat]
        //1. Definim un delegat = delegate (contractul dintre publisher si subscriber) - delegate-ul ne va ajuta sa realizam comunicarea dintre subscriber si publisher
        //2. Construim un event pe baza delegate-ului
        //3. publicam eventul - este publisher-ul nostru


        public delegate void VideoEncodedEventHandler(object source, EventArgs args);//1 am declarat un delegate (primul paramentru- este sursa evenimentului sau clasa lui, al doilea parametru - orice informatie aditionala pe care vrem sa o trimitem mai departe in event

        public event VideoEncodedEventHandler videoEncoded; //trecem la trecut numele adica videoEncoded: pentru ca folosim la trecut si chemam event-ul dupa ce sa encodat

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(); //  pasul 4. este ca aici o sa notificam eventul, din metoda asta - iar metoda mai departe o sa notifice toti subscriberii 
        }

        //pentru pasul 3, in care publicam event-ul, trebuie sa avem o metoda responsabila pentru asta
        protected virtual void OnVideoEncoded()//asta este un publisher si responsabilitatea lui este sa notifice toti subscriberii- .NET sugereaza ca publisherii sa fie protected si void si sa se scrie cu 'On' in fata si dupa numele eventului 
        {

           /* if (videoEncoded != null)// mai intai verificam daca avem ceva subscriberi inregistrati la eventul nostru(videoEncoded)
            {
                videoEncoded(this, EventArgs.Empty);//acum tratam partea asta ca o metoda, pentru ca eventul nostru este de tip VideoEncodedEventHandler si ala are 2 parametri(care este sursa eventului = adica clasa curenta sau cine e publisher pentru event, EventArgs.Emty = cand nu vrem sa avem argumente aditionale)
            }*/

            videoEncoded?.Invoke(this, EventArgs.Empty);// asa sugereaza intellisense ca e mult mai simplu de scris - inseamna acelasi lucru ca sus 
        }
    }
}
