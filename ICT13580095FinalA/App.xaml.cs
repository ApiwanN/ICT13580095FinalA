using ICT13580095FinalA.Helpers;
using Xamarin.Forms;

namespace ICT13580095FinalA
{
	public partial class App : Application
	{
        public static  Dbhelper DbHelper
        {
            get;
            set;
        }

		public App()
		{
			InitializeComponent();
		}
		public App(string dbPath)
		{
			InitializeComponent();

			DbHelper = new Dbhelper(dbPath);


			MainPage = new NavigationPage(new MainPage());

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