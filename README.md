
# ReactiveUI.Maui sample app
This sample is based on [ReactiveUI.Samples/Xamarin/Cinephile at main · reactiveui/ReactiveUI.Samples · GitHub](https://github.com/reactiveui/ReactiveUI.Samples/tree/main/Xamarin/Cinephile) for XF.
Identical app setup works correctly for XF.
| Platform | Status |
| - | - |  
| Android | OK |
| iOS | Crashes |
| MacCatalyst | Crashes |
| Windows | Not tested |
| Tizen | Not tested |
### Comments
Please check comments in `AppBootstrapper.cs` and on iOS platform `Info.plist`.
### Stacktrace
    Unhandled Exception:
    System.InvalidOperationException: NavigationPage must have a root Page before being used. Either call PushAsync with a valid Page, or pass a Page to the constructor before usage.
       at Microsoft.Maui.Controls.Handlers.Compatibility.NavigationRenderer.ViewDidLoad()
       at UIKit.UIViewController.get_View()
       at Microsoft.Maui.Controls.Handlers.Compatibility.NavigationRenderer.get_NativeView()
       at Microsoft.Maui.Controls.Handlers.Compatibility.NavigationRenderer.Microsoft.Maui.IElementHandler.get_PlatformView()
       at Microsoft.Maui.Handlers.ViewHandler.MapInputTransparent(IViewHandler handler, IView view)
       at Microsoft.Maui.PropertyMapper`2.<>c__DisplayClass5_0[[Microsoft.Maui.IView, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[Microsoft.Maui.IViewHandler, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].<Add>b__0(IElementHandler h, IElement v)
       at Microsoft.Maui.PropertyMapper.UpdatePropertyCore(String key, IElementHandler viewHandler, IElement virtualView)
       at Microsoft.Maui.PropertyMapper.UpdateProperty(IElementHandler viewHandler, IElement virtualView, String property)
       at Microsoft.Maui.PropertyMapper`2.<>c__DisplayClass5_0[[Microsoft.Maui.Controls.Layout, Microsoft.Maui.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[Microsoft.Maui.Handlers.LayoutHandler, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].<Add>b__0(IElementHandler h, IElement v)
       at Microsoft.Maui.PropertyMapper.UpdatePropertyCore(String key, IElementHandler viewHandler, IElement virtualView)
       at Microsoft.Maui.PropertyMapper.UpdateProperties(IElementHandler viewHandler, IElement virtualView)
       at Microsoft.Maui.Controls.Handlers.Compatibility.VisualElementRenderer`1[[Microsoft.Maui.Controls.NavigationPage, Microsoft.Maui.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].SetVirtualView(IElement view, IPlatformViewHandler nativeViewHandler, Action`1 onElementChanged, NavigationPage& currentVirtualView, IPropertyMapper& _mapper, IPropertyMapper _defaultMapper, Boolean autoPackage)
       at Microsoft.Maui.Controls.Handlers.Compatibility.ViewHandlerDelegator`1[[Microsoft.Maui.Controls.NavigationPage, Microsoft.Maui.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].SetVirtualView(IElement view, Action`1 onElementChanged, Boolean autoPackage)
       at Microsoft.Maui.Controls.Handlers.Compatibility.NavigationRenderer.Microsoft.Maui.IElementHandler.SetVirtualView(IElement view)
       at Microsoft.Maui.Controls.Element.SetHandler(IElementHandler newHandler)
       at Microsoft.Maui.Controls.Element.set_Handler(IElementHandler value)
       at Microsoft.Maui.Controls.VisualElement.Microsoft.Maui.IElement.set_Handler(IElementHandler value)
       at Microsoft.Maui.Platform.ElementExtensions.ToHandler(IElement view, IMauiContext context)
       at Microsoft.Maui.Platform.ElementExtensions.ToPlatform(IElement view, IMauiContext context)
       at Microsoft.Maui.Platform.ElementExtensions.ToUIViewController(IElement view, IMauiContext context)
       at Microsoft.Maui.Handlers.WindowHandler.MapContent(IWindowHandler handler, IWindow window)
       at Microsoft.Maui.PropertyMapper`2.<>c__DisplayClass5_0[[Microsoft.Maui.IWindow, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[Microsoft.Maui.Handlers.IWindowHandler, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].<Add>b__0(IElementHandler h, IElement v)
       at Microsoft.Maui.PropertyMapper.UpdatePropertyCore(String key, IElementHandler viewHandler, IElement virtualView)
       at Microsoft.Maui.PropertyMapper.UpdateProperties(IElementHandler viewHandler, IElement virtualView)
       at Microsoft.Maui.Handlers.ElementHandler.SetVirtualView(IElement view)
       at Microsoft.Maui.Controls.Element.SetHandler(IElementHandler newHandler)
       at Microsoft.Maui.Controls.Element.set_Handler(IElementHandler value)
       at Microsoft.Maui.Platform.ElementExtensions.SetHandler(INativeObject nativeElement, IElement element, IMauiContext context)
       at Microsoft.Maui.Platform.ElementExtensions.SetWindowHandler(UIWindow platformWindow, IWindow window, IMauiContext context)
       at Microsoft.Maui.Platform.ApplicationExtensions.CreatePlatformWindow(IApplication application, UIWindowScene windowScene, NSDictionary[] states)
       at Microsoft.Maui.Platform.ApplicationExtensions.CreatePlatformWindow(IUIApplicationDelegate platformApplication, IApplication application, UIApplication uiApplication, NSDictionary launchOptions)
       at Microsoft.Maui.MauiUIApplicationDelegate.FinishedLaunching(UIApplication application, NSDictionary launchOptions)
       at UIKit.UIApplication.UIApplicationMain(Int32 argc, String[] argv, IntPtr principalClassName, IntPtr delegateClassName)
       at UIKit.UIApplication.Main(String[] args, Type principalClass, Type delegateClass)
       at MauiReactiveUISampleApp.Program.Main(String[] args)