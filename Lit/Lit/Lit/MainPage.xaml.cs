﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        async void OnStart(object sender, System.EventArgs e)
        {
            Navigation.InsertPageBefore(new MenuPage(), this);

            await Navigation.PopAsync();
        }
    }
}
