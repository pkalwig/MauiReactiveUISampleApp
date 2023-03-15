using ReactiveUI;
using Splat;

namespace MauiReactiveUISampleApp;

public class MainViewModel : ReactiveObject, IRoutableViewModel
{
    public MainViewModel(IScreen hostScreen = null)
    {
        HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
    }

    public string UrlPathSegment => "main";

    public IScreen HostScreen { get; }
}