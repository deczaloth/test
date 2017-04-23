using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
            Title = "Main Page";

            Button goToModelessPage = new Button
            {
                Text = "Go To the Modeless Page!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            goToModelessPage.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new ModelessPage());
            };

            Button goToModalPage = new Button
            {
                Text = "Go To the Modal Page!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            goToModalPage.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new ModalPage());
            };

            Content = new StackLayout {
				Children = {
					new Label { Text = "Choose your Page mode: " },
                    goToModelessPage, goToModalPage
				}
			};
		}
	}
}
