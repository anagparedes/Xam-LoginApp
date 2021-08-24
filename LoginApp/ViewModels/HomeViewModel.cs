
using LoginApp.Models;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class HomeViewModel : ContentPage
    {
        public MenuOption option { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            option.Title = "GameBoyAdvance";
            
        }
    }
}