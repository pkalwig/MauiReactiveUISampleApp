namespace MauiReactiveUISampleApp;

public partial class App
{
    public App()
    {
        InitializeComponent();

        new AppBootstrapper();
        MainPage = AppBootstrapper.CreateMainPage();
    }
}