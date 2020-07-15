﻿using Apps.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeDatabase();
            MainPage = new MainPage();
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
        public static void InitializeDatabase()
        {
            Datamanager objDatamanager = new Datamanager();
            objDatamanager.CreateUserTable();
        }
    }
}
