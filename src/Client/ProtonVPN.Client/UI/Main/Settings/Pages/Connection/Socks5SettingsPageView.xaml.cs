using Microsoft.UI.Xaml.Controls;

namespace ProtonVPN.Client.UI.Main.Settings.Pages.Connection
{
    public sealed partial class Socks5SettingsPageView : UserControl
    {
        public Socks5SettingsPageView()
        {
            this.InitializeComponent();
            this.DataContext = new Socks5SettingsPageViewModel();
        }
    }
}
