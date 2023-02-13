

namespace MuYu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if ANDROID
        MainPage = Preferences.Default.Get("read", false) ? new MainPage() : new PrivacyPolicy();
#else
        MainPage = new MainPage();
#endif
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
        
        window.Stopped += (s, e) =>
        {
            Data.HitCounter.Save();
        };

        return window;
    }
}
