using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlaMulliganProject
{
    class LivestockDetails
    {

        public string Breed { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public decimal Cost { get; set;  }

        private string description; 

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
}
