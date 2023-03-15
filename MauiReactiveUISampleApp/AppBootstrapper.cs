using ReactiveUI;
using Splat;

namespace MauiReactiveUISampleApp;

public class AppBootstrapper : ReactiveObject, IScreen
{
    public AppBootstrapper()
    {
        Router = new RoutingState();
        Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
        Locator.CurrentMutable.Register(() => new MainPage(), typeof(IViewFor<MainViewModel>));
    }

    public RoutingState Router { get; }

    public static Page CreateMainPage()
    {
        var routedViewHost = new ReactiveUI.Maui.RoutedViewHost();
        // Workaround for similar issue on XF https://github.com/reactiveui/ReactiveUI/issues/759
        routedViewHost.PushAsync(new ContentPage()).Wait();
        routedViewHost.Router
            .NavigateAndReset
            .Execute(new MainViewModel())
            .Subscribe();
        return routedViewHost;
    }
}