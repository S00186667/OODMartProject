using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarlaMulliganProject; 

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalData db = new AnimalData(); 

           

            using(db) //safely closing all connections to database
            {
                //AnimalInfo SuffolkF = new AnimalInfo() { ID = 200, TBTesting = true };
                //AnimalInfo SuffolkM = new AnimalInfo() { ID = 201, TBTesting = true };
                //AnimalInfo GalwayM = new AnimalInfo() { ID = 150, TBTesting = false };
                //AnimalInfo GalwayF = new AnimalInfo() { ID = 270, TBTesting = true };
                //AnimalInfo RyelandF = new AnimalInfo() { ID = 302, TBTesting = true };
                //AnimalInfo RyelandM = new AnimalInfo() { ID = 303, TBTesting = true };

                //AnimalInfo DexterM = new AnimalInfo() { ID = 1400, TBTesting = false };
                //AnimalInfo DexterF = new AnimalInfo() { ID = 12, TBTesting = true };
                //AnimalInfo AngusM = new AnimalInfo() { ID = 780, TBTesting = true };
                //AnimalInfo AngusF = new AnimalInfo() { ID = 130, TBTesting = true };
                //AnimalInfo LimousinM = new AnimalInfo() { ID = 160, TBTesting = true };
                //AnimalInfo LimousinF = new AnimalInfo() { ID = 560, TBTesting = false};

                //AnimalInfo FriesianF = new AnimalInfo() { ID = 740, TBTesting = true };
                //AnimalInfo FriesianM = new AnimalInfo() { ID = 400, TBTesting = true };
                //AnimalInfo JerseyM = new AnimalInfo() { ID = 16, TBTesting = false };
                //AnimalInfo JerseyF = new AnimalInfo() { ID = 1700, TBTesting = true };
                //AnimalInfo SimmnatalF = new AnimalInfo() { ID = 30, TBTesting = true };
                //AnimalInfo SimmnatalM = new AnimalInfo() { ID = 31, TBTesting = true };




                Animal Sheep1 = new Animal
                {
                    Breed = "Suffolk",
                    Gender = "F",
                    DOB = new DateTime(2019, 2, 1),
                    Description = "Breeding Ewe",
                    Cost = 110m,
                    ID = 200,
                    TBTesting = true

                };

                Animal Sheep2 = new Animal
                {
                    Breed = "Suffolk",
                    Gender = "M",
                    DOB = new DateTime(2019, 4, 1),
                    Description = "Breeding Ram",
                    Cost = 100m,
                    ID = 201,
                    TBTesting = true


                };

                Animal Sheep3 = new Animal
                {
                    Breed = "Galway",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 14),
                    Description = "Ram",
                    Cost = 70m,
                    ID = 150, 
                    TBTesting = true

                };

                Animal Sheep4 = new Animal
                {
                    Breed = "Galway",
                    Gender = "F",
                    DOB = new DateTime(2019, 3, 3),
                    Description = "Ewe",
                    Cost = 140m,
                    ID = 270, 
                    TBTesting = true
                };

                Animal Sheep5 = new Animal
                {
                    Breed = "Ryeland",
                    Gender = "F",
                    DOB = new DateTime(2019, 5, 17),
                    Description = "Ewe",
                    Cost = 91m, 
                    ID = 302, 
                    TBTesting = true
                };

                Animal Sheep6 = new Animal
                {
                    Breed = "Ryeland",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 16),
                    Description = "Hogget",
                    Cost = 100m,
                    ID = 303, 
                    TBTesting = true
                };

                //Beef Details
                Animal Beef1 = new Animal
                {
                    Breed = "Dexter",
                    Gender = "F",
                    DOB = new DateTime(2019, 2, 1), 
                    Description = "Heifer",
                    Cost = 400m, 
                    ID = 1400, 
                    TBTesting = true
                };

                Animal Beef2 = new Animal
                {
                    Breed = "Dexter",
                    Gender = "M",
                    DOB = new DateTime(2019, 4, 1), 
                    Description = "Bullock",
                    Cost = 600m, 
                    TBTesting = true
                };

                Animal Beef3 = new Animal
                {
                    Breed = "Angus",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 14), 
                    Description = "Calf",
                    Cost = 450m,
                    ID = 780, 
                    TBTesting = true
                };

                Animal Beef4 = new Animal
                {
                    Breed = "Angus",
                    Gender = "F",
                    DOB = new DateTime(2019, 3, 3), 
                    Description = "Heifer", 
                    Cost = 600m,
                    ID = 160, 
                    TBTesting = true
                };

                Animal Beef5 = new Animal
                {
                    Breed = "Limousin",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 17), 
                    Description = "Bull", 
                    Cost = 350m,
                    ID = 130, 
                    TBTesting = true
                };

                Animal Beef6 = new Animal
                {
                    Breed = "Limousin",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 16), 
                    Description = "Male Calf",
                    Cost = 250m,
                    ID = 560, 
                    TBTesting = true
                };


                //Dairy Details
                Animal Dairy1 = new Animal
                {
                    Breed = "Friesian",
                    Gender = "F",
                    DOB = new DateTime(2019, 2, 1), 
                    Description = "Heifer",
                    Cost = 600m,
                    ID = 740, 
                    TBTesting = true
                };

                Animal Dairy2 = new Animal
                {
                    Breed = "Friesian",
                    Gender = "M",
                    DOB = new DateTime(2019, 4, 1), 
                    Description = "Bullock", 
                    Cost = 150m,
                    ID = 400, 
                    TBTesting = true
                };

                Animal Dairy3 = new Animal
                {
                    Breed = "Jersey",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 14), 
                    Description = "Bullock", 
                    Cost = 200m,
                    ID = 16, 
                    TBTesting = true

                };

                Animal Dairy4 = new Animal
                {
                    Breed = "Jersey",
                    Gender = "F",
                    DOB = new DateTime(2019, 3, 3), 
                    Description = "Heifer",
                    Cost = 550m,
                    ID = 1700, 
                    TBTesting = true
                };

                Animal Dairy5 = new Animal
                {
                    Breed = "Simmnetal",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 17), 
                    Description = "Bullock",
                    Cost = 250m,
                    ID = 31, 
                    TBTesting = true

                };

                Animal Dairy6 = new Animal
                {
                    Breed = "Simmnetal",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 16), 
                    Description = "Calf", 
                    Cost = 400m,
                    ID = 32, 
                    TBTesting = true
                };

                //db.Info.Add(SuffolkF);
                //db.Info.Add(SuffolkM);
                //db.Info.Add(GalwayF);
                //db.Info.Add(GalwayM);
                //db.Info.Add(RyelandF);
                //db.Info.Add(RyelandM);

                //db.Info.Add(DexterF);
                //db.Info.Add(DexterM);
                //db.Info.Add(AngusF);
                //db.Info.Add(AngusM);
                //db.Info.Add(LimousinF);
                //db.Info.Add(LimousinM);

                //db.Info.Add(FriesianF);
                //db.Info.Add(FriesianM);
                //db.Info.Add(JerseyF);
                //db.Info.Add(JerseyM);
                //db.Info.Add(SimmnatalF);
                //db.Info.Add(SimmnatalM);

                Console.WriteLine("Animal info added to database");

                db.Livestock.Add(Sheep1);
                db.Livestock.Add(Sheep2);
                db.Livestock.Add(Sheep3);
                db.Livestock.Add(Sheep4);
                db.Livestock.Add(Sheep5);
                db.Livestock.Add(Sheep6);

                db.Livestock.Add(Beef1);
                db.Livestock.Add(Beef2);
                db.Livestock.Add(Beef3);
                db.Livestock.Add(Beef4);
                db.Livestock.Add(Beef5);
                db.Livestock.Add(Beef6);

                db.Livestock.Add(Dairy1);
                db.Livestock.Add(Dairy2);
                db.Livestock.Add(Dairy3);
                db.Livestock.Add(Dairy4);
                db.Livestock.Add(Dairy5);
                db.Livestock.Add(Dairy6);

                Console.WriteLine("Added livestock to database");

                db.SaveChanges();



                Console.WriteLine("Saved to database");














            }




        }
    }
}
