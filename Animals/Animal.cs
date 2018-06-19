using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;//am nevoie de namesapce-ul asta daca vreau sa foloses serializarea
using System.Runtime.Serialization.Formatters.Binary;//am nevoie de namespace-ul asta pentru serializare

namespace Animals
{
    //pentru inceput trebuie sa adaug atributul clasei ce o face sa fie serializabila
    [Serializable]
    public class Animal : ISerializable // dupa trebuie sa implementam interfata asta ce ne aduce o metoda cu care o sa facem serializarea 
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal()
        {

        }
        public Animal(string name = "No Name", double weight = 0, double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return string.Format("{0} weights: {1} and is {2} tall.", Name, Weight, Height);
        }
        /// <summary>
        /// Metoda asta sa ne ajute sa facem serializarea 
        /// </summary>
        /// <param name="info">o sa folosim acest parametru pentru a adauga valori in fisierul nostru serializat</param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
        }
        /// <summary>
        /// Constructorul asta o sa ne ajute a deserializare
        /// </summary>
        /// <param name="info">parametru ce va aduce valoarea serializata si o va converti in obiect</param>
        /// <param name="context"></param>
        public Animal(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
        }
    }
}
