using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenXamarin
{
    public partial class App : Application
    {
        private readonly Func<Stream, string, Task<bool>> saveSignatureDelegate;
        public App()
        {
            InitializeComponent();
            //saveSignatureDelegate = saveSignature;

            MainPage = new MainPage();
        }
        public static Task<bool> SaveSignature(Stream bitmap, string filename)
        {
            return ((App)Application.Current).saveSignatureDelegate(bitmap, filename);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
