using ExamenXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LivraisonDetailPage : ContentPage
    {
        public LivraisonDetailPage(LivraisonModel livraison)
        {
            InitializeComponent();
            Livraison = livraison;
        }

        public LivraisonModel Livraison { get; }
    }
}