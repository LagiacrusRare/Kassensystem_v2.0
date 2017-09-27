using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Kassensystem_v2._0
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            InitializeComponent();

            MainPage = new Kassensystem_v2._0.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
