﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Reebok : ContentPage
	{
		public Reebok ()
		{
			InitializeComponent ();
		}

        private async void AddedCart(object sender, EventArgs e)
        {
            await DisplayAlert("Added To Cart", "Your Cart has been updated", "Ok");
        }

        async void Bought(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Payment());
        }
    }
}