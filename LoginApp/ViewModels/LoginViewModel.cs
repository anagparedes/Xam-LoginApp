using LoginApp.Views;
using System.ComponentModel;
using Xamarin.Forms;


namespace LoginApp.ViewModels
{
    public class LoginViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string username;
        public string usernameEntry { get { return username; } 
            set
            { username = value; PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            
            }
        }

        private string password;
        public string passwordEntry { get { return password; } 
            set 
            { password = value; PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            
            }
       
        }
       
        //public LoginViewModel()
        //{
           


        //}
       
     

        public Command ButtonCommand
        {
            get
            {
                return new Command(OnButtonClicked);
            }
        }

        public Command ButtonSignUpCommand
        {
            get
            {
                return new Command(TapGestureRecognizerOnTapped);
            }
        }

   

        private async void OnButtonClicked()
        {

            if (string.IsNullOrEmpty(usernameEntry) || string.IsNullOrEmpty(passwordEntry))
            {
                await App.Current.MainPage.DisplayAlert("Warning!", "The fields are required.", "Ok");


            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome!", "Hi " + usernameEntry, "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());

            }
        }

        private void TapGestureRecognizerOnTapped()
        {
            App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }




    }
}