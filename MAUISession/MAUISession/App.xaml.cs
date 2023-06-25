using MAUISession.Pages;

namespace MAUISession;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NewPage1();
	}
}
