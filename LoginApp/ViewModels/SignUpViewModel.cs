using LoginApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class SignUpViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

   
        private string email;
        public string emailEntry
        {
            get { return email; }
            set
            {
                email = value; PropertyChanged(this, new PropertyChangedEventArgs("Email"));

            }
        }

        private string username;
        public string usernameEntry
        {
            get { return username; }
            set
            {
                username = value; PropertyChanged(this, new PropertyChangedEventArgs("Username"));

            }
        }

        private string password;
        public string passwordEntry
        {
            get { return password; }
            set
            {
                password = value; PropertyChanged(this, new PropertyChangedEventArgs("Password"));

            }

        }
        public SignUpViewModel()
        {
           
        }

        public Command ButtonCommand
        {
            get
            {
                return new Command(OnButtonClicked);
            }
        }

        private async void OnButtonClicked()
        {

            if (string.IsNullOrEmpty(emailEntry)||string.IsNullOrEmpty(usernameEntry) || string.IsNullOrEmpty(passwordEntry))
            {
                await App.Current.MainPage.DisplayAlert("Warning!", "The fields are required.", "Ok");


            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Thank you for Signing Up!", "Welcome " + usernameEntry, "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());

            }
        }
    }
}