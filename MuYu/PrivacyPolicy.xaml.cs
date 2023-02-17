namespace MuYu;

public partial class PrivacyPolicy : ContentPage
{
	public PrivacyPolicy()
	{
		InitializeComponent();
	}

    private void Exit_Clicked(object sender, EventArgs e)
    {
		Application.Current.Quit();
    }

    private void Agree_Clicked(object sender, EventArgs e)
    {
        Preferences.Default.Set("read", true);
        Application.Current.MainPage = new MainPage();
    }

    private void OnLabel1Tapped(object sender, EventArgs e)
    {
        Launcher.Default.OpenAsync("https://github.com/sangyuxiaowu/MuYu/blob/main/MuYu/Resources/Raw/SLA.txt");
    }
    private void OnLabel2Tapped(object sender, EventArgs e)
    {
        Launcher.Default.OpenAsync("https://github.com/sangyuxiaowu/MuYu/blob/main/MuYu/Resources/Raw/PrivacyPolicy.txt");
    }


}