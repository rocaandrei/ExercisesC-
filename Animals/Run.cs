using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//acesta o sa ne ajute sa scriem catre un fisier
using System.Runtime.Serialization.Formatters.Binary;// tot asa ca sa citim serializarile 
using System.Xml.Serialization;//ca sa serilizam in XML
namespace Animals
{
    class Run
    {
        public void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser", 34, 23);

            //ca sa serilizam catre un fisier facem

            Stream stream = File.Open("AnimalData.dat", FileMode.Create);//daca fisierul AnimalData nu exista, o sa-l creeze al doilea parametru 
            //dat = este un tip generic, se poate salva orice in el si este preferat in DLL

            Console.ReadKey();
        }
    }
}
