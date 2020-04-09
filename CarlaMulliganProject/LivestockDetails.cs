using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlaMulliganProject
{
    public class LivestockDetails
    {

        public string Breed { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public decimal Cost { get; set;  }

        private string description; 


        public int HerdID { get; set; }
        public virtual AnimalInfo animalInfo { get; set; }


        public string Description
        {
            get
            {
                return string.Format("{0} Price - {1:C}", description, Cost); 
            }
            set
            {
                description = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Breed, Gender, DOB.ToShortDateString()); 
        }

    }
    public class AnimalInfo
    {
        public int ID { get; set; }

        public bool TBTesting { get; set; } 

        public virtual List<LivestockDetails> Livestock { get; set; }


    }

    public class AnimalData : DbContext
    {

        public AnimalData():base("GranardMartData") { }

        public DbSet<LivestockDetails> Livestock { get; set; }
        public DbSet<AnimalInfo> Info { get; set; }


    }
}
