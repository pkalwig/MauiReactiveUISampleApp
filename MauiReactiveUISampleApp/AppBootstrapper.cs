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

        // Fix for similar issue on XF https://github.com/reactiveui/ReactiveUI/issues/759
        Router
            .NavigateAndReset
            .Execute(new MainViewModel())
            .Subscribe();
    }

    public RoutingState Router { get; }

    public static Page CreateMainPage() => new ReactiveUI.Maui.RoutedViewHost();
}