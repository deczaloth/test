using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
	public class ModalPage : ContentPage
	{
		public ModalPage ()
		{
            Title = "Modal Page";

            Button goBack = new Button
            {
                Text = "Go Back!",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            goBack.Clicked += async (sender, args) =>
            {
                await Navigation.PopModalAsync();
            };

            Content = new StackLayout
            {
                Children = {
                    goBack
                }
            };
        }
	}
}
