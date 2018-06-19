using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//acesta o sa ne ajute sa scriem catre un fisier
using System.Runtime.Serialization.Formatters.Binary;// tot asa ca sa citim serializarile 
using System.Xml.Serialization;//ca sa serilizam in XML
using Animals;

namespace Execute
{
    class Program
    {

        public static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser", 34, 23);

            //ca sa serilizam catre un fisier facem

            Stream stream = File.Open("AnimalData.dat", FileMode.Create);//daca fisierul AnimalData nu exista, o sa-l creeze al doilea parametru 
                                                                         //dat = este un tip generic, se poate salva orice in el si este preferat in DLL

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, bowser);// ASTA O SA FIE SALVATA 
            stream.Close();
            bowser = null;///aoco stergem sa verificam daca s-a salvat

            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();
            bowser = (Animal)bf.Deserialize(stream);
            Console.WriteLine(bowser.ToString());
            bowser.Weight = 50;

            XmlSerializer serilizer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\tony\Desktop\serializare\bowser.xml"))
            {
                serilizer.Serialize(tw, bowser);
            }
            bowser = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\tony\Desktop\serializare\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();
            Console.WriteLine(bowser.ToString());

            List<Animal> myListOfAnimal = new List<Animal>()
            {
                new Animal("Mario", 34,14),
                new Animal("Colicica",14,10),
                new Animal("Lestat", 45, 23.3)
        };
            //mai intai salvam ca XML in fisierul in care l-am salvat si pe bowser 
            using (Stream fs = new FileStream(@"C:\Users\tony\Desktop\serializare\animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, myListOfAnimal);
            }
            myListOfAnimal = null;

            //acum o sa luam lista din XML animals si o sa o afisam in consola

            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\tony\Desktop\serializare\animals.xml"))//aici deschidem mai intai lista din xml
            {
                myListOfAnimal = (List<Animal>)serializer3.Deserialize(fs2);//AICI DESERIALIZAM DIN FS2
            }
            Console.WriteLine();
            foreach (var item in myListOfAnimal)
            {
                Console.WriteLine(item.ToString());
            }




            Console.ReadKey();
        }
    }
}
