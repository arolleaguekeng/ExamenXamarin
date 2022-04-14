using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenXamarin.Model
{
    public class LivraisonModel
    {
        public string Reference { get; set; }
        public string Date { get; set; }
        public string Heure { get; set; }
        public string Lieux { get; set; }

        public LivraisonModel(string reference, string date, string heure, string lieux)
        {
            Reference = reference;
            Date = date;
            Heure = heure;
            Lieux = lieux;
        }

        public override bool Equals(object obj)
        {
            
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
