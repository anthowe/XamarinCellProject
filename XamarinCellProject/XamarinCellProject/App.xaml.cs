﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace XamarinCellProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
           MainPage = new NavigationPage (new Main2());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
