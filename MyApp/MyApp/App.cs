using MyApp.Views;
using Xamarin.Forms;

namespace MyApp
{
	public class App : Application
	{
		public App ()
		{
            MainPage = new MyView();
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
