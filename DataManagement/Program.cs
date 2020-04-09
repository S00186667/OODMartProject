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
                AnimalInfo SuffolkF = new AnimalInfo() { ID = 200, TBTesting = true };
                AnimalInfo SuffolkM = new AnimalInfo() { ID = 201, TBTesting = true };
                AnimalInfo GalwayM = new AnimalInfo() { ID = 150, TBTesting = false };
                AnimalInfo GalwayF = new AnimalInfo() { ID = 270, TBTesting = true };
                AnimalInfo RyelandF = new AnimalInfo() { ID = 302, TBTesting = true };
                AnimalInfo RyelandM = new AnimalInfo() { ID = 303, TBTesting = true };

                AnimalInfo DexterM = new AnimalInfo() { ID = 1400, TBTesting = false };
                AnimalInfo DexterF = new AnimalInfo() { ID = 12, TBTesting = true };
                AnimalInfo AngusM = new AnimalInfo() { ID = 780, TBTesting = true };
                AnimalInfo AngusF = new AnimalInfo() { ID = 130, TBTesting = true };
                AnimalInfo LimousinM = new AnimalInfo() { ID = 160, TBTesting = true };
                AnimalInfo LimousinF = new AnimalInfo() { ID = 560, TBTesting = false};

                AnimalInfo FriesianF = new AnimalInfo() { ID = 740, TBTesting = true };
                AnimalInfo FriesianM = new AnimalInfo() { ID = 400, TBTesting = true };
                AnimalInfo JerseyM = new AnimalInfo() { ID = 16, TBTesting = false };
                AnimalInfo JerseyF = new AnimalInfo() { ID = 1700, TBTesting = true };
                AnimalInfo SimmnatalF = new AnimalInfo() { ID = 30, TBTesting = true };
                AnimalInfo SimmnatalM = new AnimalInfo() { ID = 31, TBTesting = true };




                LivestockDetails Sheep1 = new LivestockDetails
                {
                    Breed = "Suffolk",
                    Gender = "F",
                    DOB = new DateTime(2019, 2, 1),
                    Description = "Breeding Ewe",
                    Cost = 110m,
                    HerdID = 200,
                    animalInfo = SuffolkF

                };

                LivestockDetails Sheep2 = new LivestockDetails
                {
                    Breed = "Suffolk",
                    Gender = "M",
                    DOB = new DateTime(2019, 4, 1),
                    Description = "Breeding Ram",
                    Cost = 100m,
                    HerdID = 201,
                    animalInfo = SuffolkM

                };

                LivestockDetails Sheep3 = new LivestockDetails
                {
                    Breed = "Galway",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 14),
                    Description = "Ram",
                    Cost = 70m,
                    HerdID = 150, 
                    animalInfo = GalwayM

                };

                LivestockDetails Sheep4 = new LivestockDetails
                {
                    Breed = "Galway",
                    Gender = "F",
                    DOB = new DateTime(2019, 3, 3),
                    Description = "Ewe",
                    Cost = 140m,
                    HerdID = 270, 
                    animalInfo = GalwayF
                };

                LivestockDetails Sheep5 = new LivestockDetails
                {
                    Breed = "Ryeland",
                    Gender = "F",
                    DOB = new DateTime(2019, 5, 17),
                    Description = "Ewe",
                    Cost = 91m, 
                    HerdID = 302, 
                    animalInfo = RyelandF
                };

                LivestockDetails Sheep6 = new LivestockDetails
                {
                    Breed = "Ryeland",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 16),
                    Description = "Hogget",
                    Cost = 100m,
                    HerdID = 303, 
                    animalInfo = RyelandM
                };

                //Beef Details
                LivestockDetails Beef1 = new LivestockDetails
                {
                    Breed = "Dexter",
                    Gender = "F",
                    DOB = new DateTime(2019, 2, 1), 
                    Description = "Heifer",
                    Cost = 400m, 
                    HerdID = 1400, 
                    animalInfo = DexterF
                };

                LivestockDetails Beef2 = new LivestockDetails
                {
                    Breed = "Dexter",
                    Gender = "M",
                    DOB = new DateTime(2019, 4, 1), 
                    Description = "Bullock",
                    Cost = 600m, 
                    animalInfo = DexterM
                };

                LivestockDetails Beef3 = new LivestockDetails
                {
                    Breed = "Angus",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 14), 
                    Description = "Calf",
                    Cost = 450m,
                    HerdID = 780, 
                    animalInfo = AngusM
                };

                LivestockDetails Beef4 = new LivestockDetails
                {
                    Breed = "Angus",
                    Gender = "F",
                    DOB = new DateTime(2019, 3, 3), 
                    Description = "Heifer", 
                    Cost = 600m,
                    HerdID = 160, 
                    animalInfo = AngusF
                };

                LivestockDetails Beef5 = new LivestockDetails
                {
                    Breed = "Limousin",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 17), 
                    Description = "Bull", 
                    Cost = 350m,
                    HerdID = 130, 
                    animalInfo = LimousinM
                };

                LivestockDetails Beef6 = new LivestockDetails
                {
                    Breed = "Limousin",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 16), 
                    Description = "Male Calf",
                    Cost = 250m,
                    HerdID = 560, 
                    animalInfo = LimousinM
                };


                //Dairy Details
                LivestockDetails Dairy1 = new LivestockDetails
                {
                    Breed = "Friesian",
                    Gender = "F",
                    DOB = new DateTime(2019, 2, 1), 
                    Description = "Heifer",
                    Cost = 600m,
                    HerdID = 740, 
                    animalInfo = FriesianF
                };

                LivestockDetails Dairy2 = new LivestockDetails
                {
                    Breed = "Friesian",
                    Gender = "M",
                    DOB = new DateTime(2019, 4, 1), 
                    Description = "Bullock", 
                    Cost = 150m,
                    HerdID = 400, 
                    animalInfo = FriesianM
                };

                LivestockDetails Dairy3 = new LivestockDetails
                {
                    Breed = "Jersey",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 14), 
                    Description = "Bullock", 
                    Cost = 200m,
                    HerdID = 16, 
                    animalInfo = JerseyM

                };

                LivestockDetails Dairy4 = new LivestockDetails
                {
                    Breed = "Jersey",
                    Gender = "F",
                    DOB = new DateTime(2019, 3, 3), 
                    Description = "Heifer",
                    Cost = 550m,
                    HerdID = 1700, 
                    animalInfo = JerseyF
                };

                LivestockDetails Dairy5 = new LivestockDetails
                {
                    Breed = "Simmnetal",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 17), 
                    Description = "Bullock",
                    Cost = 250m,
                    HerdID = 31, 
                    animalInfo = SimmnatalM

                };

                LivestockDetails Dairy6 = new LivestockDetails
                {
                    Breed = "Simmnetal",
                    Gender = "M",
                    DOB = new DateTime(2019, 5, 16), 
                    Description = "Calf", 
                    Cost = 400m,
                    HerdID = 32, 
                    animalInfo = SimmnatalM
                };

                db.Info.Add(SuffolkF);
                db.Info.Add(SuffolkM);
                db.Info.Add(GalwayF);
                db.Info.Add(GalwayM);
                db.Info.Add(RyelandF);
                db.Info.Add(RyelandM);

                db.Info.Add(DexterF);
                db.Info.Add(DexterM);
                db.Info.Add(AngusF);
                db.Info.Add(AngusM);
                db.Info.Add(LimousinF);
                db.Info.Add(LimousinM);

                db.Info.Add(FriesianF);
                db.Info.Add(FriesianM);
                db.Info.Add(JerseyF);
                db.Info.Add(JerseyM);
                db.Info.Add(SimmnatalF);
                db.Info.Add(SimmnatalM);

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
