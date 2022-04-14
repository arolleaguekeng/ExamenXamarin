using ExamenXamarin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenXamarin.Repository
{
    public class LivraisonRepository
    {
        List<LivraisonModel> livraisons;
        public LivraisonRepository()
        {
            livraisons = new List<LivraisonModel>();
        }

        public LivraisonModel Delete(LivraisonModel livraison)
        {
            var index = -1;

            for (int i = 0; i < livraisons.Count; i++)
                if (livraisons[i].Equals(livraison))
                    index = i;
            if (index >= 0)
                livraisons.RemoveAt(index);
            return livraison;
        }

        public LivraisonModel Add(LivraisonModel livraison)
        {
            if (livraison == null)
                throw new ArgumentNullException(nameof(LivraisonModel));

            foreach (var livraiso in livraisons)
                if (livraiso.Equals(livraison))
                    throw new DuplicateWaitObjectException($"{typeof(LivraisonModel)} already exits ! ");
            var data = JsonConvert.SerializeObject(livraison);
            File.WriteAllText("Livraison.json", data);
            return livraison;
        }
    }
}
