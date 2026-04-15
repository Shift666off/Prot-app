
using ProtonVPN.Client.Common;

namespace ProtonVPN.Client.UI.Main.Settings.Pages.Connection
{
    public class Socks5SettingsPageViewModel : ViewModelBase
    {
        private bool _socksProxyEnabled;
        public bool SocksProxyEnabled
        {
            get => _socksProxyEnabled;
            set => SetProperty(ref _socksProxyEnabled, value);
        }

        private string _socksProxyHost;
        public string SocksProxyHost
        {
            get => _socksProxyHost;
            set => SetProperty(ref _socksProxyHost, value);
        }

        private string _socksProxyPort;
        public string SocksProxyPort
        {
            get => _socksProxyPort;
            set => SetProperty(ref _socksProxyPort, value);
        }

        private string _socksProxyUsername;
        public string SocksProxyUsername
        {
            get => _socksProxyUsername;
            set => SetProperty(ref _socksProxyUsername, value);
        }

        private string _socksProxyPassword;
        public string SocksProxyPassword
        {
            get => _socksProxyPassword;
            set => SetProperty(ref _socksProxyPassword, value);
        }
    }
}
