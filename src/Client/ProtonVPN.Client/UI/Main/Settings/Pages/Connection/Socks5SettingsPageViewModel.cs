using ProtonVPN.Client.Core.Bases.ViewModels;

namespace ProtonVPN.Client.UI.Main.Settings.Pages.Connection
{
    public partial class Socks5SettingsPageViewModel : ActivatableViewModelBase
    {
        public Socks5SettingsPageViewModel()
            : base(null)
        {
        }

        private bool _socksProxyEnabled;
        public bool SocksProxyEnabled
        {
            get => _socksProxyEnabled;
            set => SetProperty(ref _socksProxyEnabled, value);
        }

        private string _socksProxyHost = string.Empty;
        public string SocksProxyHost
        {
            get => _socksProxyHost;
            set => SetProperty(ref _socksProxyHost, value);
        }

        private string _socksProxyPort = string.Empty;
        public string SocksProxyPort
        {
            get => _socksProxyPort;
            set => SetProperty(ref _socksProxyPort, value);
        }

        private string _socksProxyUsername = string.Empty;
        public string SocksProxyUsername
        {
            get => _socksProxyUsername;
            set => SetProperty(ref _socksProxyUsername, value);
        }

        private string _socksProxyPassword = string.Empty;
        public string SocksProxyPassword
        {
            get => _socksProxyPassword;
            set => SetProperty(ref _socksProxyPassword, value);
        }
    }
}
