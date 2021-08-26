using LoginApp.Views;
using System.ComponentModel;
using Xamarin.Forms;


namespace LoginApp.ViewModels
{
    public class LoginViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string username;
        public string Username { get { return username; } 
            set
            { username = value; PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            
            }
        }

        private string password;
        public string Password { get { return password; } 
            set 
            { password = value; PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            
            }
       
        }
     

        public Command LoginCommand
        {
            get
            {
                return new Command(OnLogin);
            }
        }

        public Command SignUpCommand
        {
            get
            {
                return new Command(OnSignUp);
            }
        }

   

        private async void OnLogin()
        {

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Warning!", "The fields are required.", "Ok");


            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome!", "Hi " + Username, "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());

            }
        }

        private void OnSignUp()
        {
            App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }




    }
}