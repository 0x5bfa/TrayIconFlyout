using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Controls;

namespace TrayIconFlyout.Uwp.Sample.SecondaryApp;

public sealed partial class MainPage2 : Page
{
    public MainPage2()
    {
        InitializeComponent();
    }

    private void CloseApp(object sender, Windows.UI.Xaml.RoutedEventArgs e)
    {
        CoreApplication.Exit();
    }
}
