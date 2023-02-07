

namespace MuYu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
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
