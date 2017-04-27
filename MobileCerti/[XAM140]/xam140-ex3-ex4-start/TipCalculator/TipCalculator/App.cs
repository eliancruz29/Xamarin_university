using Xamarin.Forms;

namespace TipCalculator
{
	public class App : Application
	{
		public App()
		{
			MainPage = new NavigationPage(new StandardTipPage());
		}
	}
}
