using LoginApp.Views;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class SignUpViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

   
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value; PropertyChanged(this, new PropertyChangedEventArgs("Email"));

            }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value; PropertyChanged(this, new PropertyChangedEventArgs("Username"));

            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value; PropertyChanged(this, new PropertyChangedEventArgs("Password"));

            }

        }

        public Command OnSignUpCommand
        {
            get
            {
                return new Command(OnSignUp);
            }
        }

        private async void OnSignUp()
        {

            if (string.IsNullOrEmpty(Email)||string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Warning!", "The fields are required.", "Ok");


            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Thank you for Signing Up!", "Welcome " + Username, "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());

            }
        }
    }
}