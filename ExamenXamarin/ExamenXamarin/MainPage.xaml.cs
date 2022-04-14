using ExamenXamarin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool reload = true;
        private bool selectedChange = true;
        public MainPage()
        {
            InitializeComponent();

        }

        private void Rv_Refreshing(object sender, EventArgs e)
        {

        }

        private async void CvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selectedChange)
            {
                var livraison = CvProduct.SelectedItem as LivraisonModel;


                if (livraison != null)
                {
                    reload = false;
                    await Navigation.PushAsync(new LivraisonDetailPage(livraison), true);
                }
            }
        }

        protected async override void OnAppearing()
        {
            //Loader.IsVisible = true;
            try
            {
                var livraisons = new List<LivraisonModel>();
                for (var i = 0; i<10; i++)
                {
                    var livraison = new LivraisonModel($"ref{i}", "date", "12h", $"bafoussam{i}");
                    livraisons.Add(livraison);
                    CvProduct.ItemsSource = livraisons;
                }
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                await DisplayAlert("Bad", ex.Message, "Ok");
            }
            base.OnAppearing();
            Loader.IsVisible = false;
            base.OnAppearing();
        }
    }
}
