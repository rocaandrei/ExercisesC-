using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesLinq// Language Integrated Query 
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            QueryArrayList();
            QueryCollection();
            QueryAnimalData();

            Console.ReadLine();
        }
        static void QueryStringArray()
        {
            string[] dogs = { "Scooby", "Lesie", "Cola", "Rin Tin Tin", "K 9", "Pablo Escobar", "Lestat", "Tony Montana", "Edgar Quinet", "Bobita" };

            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog descending select dog;
            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            var gt20 = from num in nums where num > 20 orderby num ascending select num;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Mai jos am updatat valoarea unei valori nums[0]");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();
            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            return arrayGT20;
        }
        static void QueryArrayList()
        {
            ArrayList famAnimal = new ArrayList()
            {
                new Animal
                {
                    Name = "Heidi",
                    Height = 0.8,
                    Weight = 32.50
                },
                new Animal
                {
                    Name = "Sherek",
                    Height = 1.5,
                    Weight = 45.5
                },
                new Animal
                {
                    Name = "Congo",
                    Height = 4.5,
                    Weight =120
                }

            };
            var famAnimalEnum = famAnimal.OfType<Animal>();// aici am facut lista de animale Enumerable 
            var smAnimals = from animal in famAnimalEnum where animal.Weight <= 50 orderby animal.Name select animal;

            foreach (var i in smAnimals)
            {
                Console.WriteLine("Name {0} and weight {1} KG.", i.Name, i.Weight);
            }
            Console.WriteLine();
        }
        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal
                {
                    Name = "German Shepard",
                    Height = 125.6,
                    Weight = 65
                },
                new Animal
                {
                    Name = "Chihuahua",
                    Height = 10.5,
                    Weight = 10
                },
                new Animal
                {
                    Name = "Saint Bernard",
                    Height = 140.8,
                    Weight = 110
                }
            };

            var bigDogs = from dog in animalList where (dog.Height > 100 && dog.Weight > 50) orderby dog.Name select dog;
            foreach (var i in bigDogs)
            {
                Console.WriteLine("{0} wheighs {1} kg.", i.Name, i.Weight);
            }
            Console.WriteLine();
        }
        static void QueryAnimalData()
        {
            #region animal list
            Animal[] animals = new Animal[]
            {
                new Animal
                {
                    Name = "Saint Bernard",
                    Height = 75,
                    Weight = 120,
                    AnimalID = 1
                },
                new Animal
                {
                    Name = "Chiuhuahua",
                    Height = 15,
                    Weight = 8,
                    AnimalID = 2
                },
                new Animal
                {
                    Name = "German Shepherd",
                    Height = 55,
                    Weight = 90,
                    AnimalID = 3
                },
                new Animal
                {
                    Name = "Pug",
                    Height = 12,
                    Weight = 14,
                    AnimalID = 1
                },
                new Animal
                {
                    Name = "Beagle",
                    Height = 25,
                    Weight = 23,
                    AnimalID =2
                }
            };
            #endregion
            #region Owners

            Owner[] owners = new Owner[]
            {
                new Owner
                {
                    Name ="Jon Smith",
                    OwnerID = 1,
                },
                new Owner
                {
                    Name = "Sally Fitzgerald",
                    OwnerID = 2,
                },
                new Owner
                {
                    Name = "Paul Brooks",
                    OwnerID = 3
                }
            };
            #endregion

            var nameHeight = from a in animals// asa iti creezi o colectie noua prin care scoti doar numele si inaltimea animalului
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };
            Array arrayNameHeight = nameHeight.ToArray();// asa convertesti colectia de mai sus intr-un array
            foreach (var item in arrayNameHeight)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            #region INNER JOIN - combini val din 2 liste in cazul nostru dupa ID

            var innerJoin = from animal in animals
                            join owner in owners on animal.AnimalID equals owner.OwnerID
                            select new
                            {
                                OwnerName = owner.Name,
                                AnimalName = animal.Name
                            };
            foreach (var item in innerJoin)
            {
                Console.WriteLine("Owner {0} has {1}", item.OwnerName, item.AnimalName);
            }
            Console.WriteLine();
            #endregion
            #region GROUP JOIN - in cazul asta o sa grupeze inormatia daca ID-ul este asamanator 

            var grupJoin = from owner in owners orderby owner.OwnerID
                           join animal in animals on owner.OwnerID equals animal.AnimalID into ownerGrup
                           select new
                           {
                               OwnerName = owner.Name,
                               Animals = from owner2 in ownerGrup orderby owner2.Name select owner2
                           };
            foreach (var ownerGrup in grupJoin)
            {
                Console.WriteLine(ownerGrup.OwnerName);
                foreach (var animal in ownerGrup.Animals)//asta ca sub numele fiecarui stapan sa ii trecem anumalul cu bulet 
                {
                    Console.WriteLine("* {0}", animal.Name);
                }
            }
            Console.WriteLine();
            #endregion
        }

    }


}

