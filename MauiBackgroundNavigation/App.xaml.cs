namespace MauiBackgroundNavigation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage();
		Start();
	}

    private async void Start()
    {
		await Task.Delay(2000);
		var navPage = (NavigationPage)MainPage!;
		await navPage.PushAsync(new MainPage());
    }
}

