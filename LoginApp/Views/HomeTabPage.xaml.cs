using LoginApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabPage : ContentPage
    {
        public HomeTabPage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}