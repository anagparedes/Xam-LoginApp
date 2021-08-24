using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class SignUpViewModel : ContentPage
    {
        public SignUpViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Signup!" }
                }
            };
        }
    }
}