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
}