﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FYP_Mockup.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        async void Go_To_Items(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ItemsPage()));
        }
    }
}