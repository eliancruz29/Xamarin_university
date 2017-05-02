using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace People
{
	public class App : Application
	{
        public static PersonRepository PersonRepo { get; private set; }

        public App(string dbPath)
        {
            PersonRepo = new PersonRepository(dbPath);

            this.MainPage = new MainPage();

            // The root page of your application
   //         MainPage = new ContentPage
			//{
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = dbPath
   //                     }
			//		}
			//	}
			//};
		}
		
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
