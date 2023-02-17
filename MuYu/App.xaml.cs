

namespace MuYu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if DEBUG
        MainPage = new PrivacyPolicy();
#else
        #if ANDROID
        MainPage = Preferences.Default.Get("read", false) ? new MainPage() : new PrivacyPolicy();
        #else
        MainPage = new MainPage();
        #endif
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
