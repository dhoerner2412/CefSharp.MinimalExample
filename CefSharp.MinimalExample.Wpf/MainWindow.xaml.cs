using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Browser.BrowserSettings == null)
            {
              Browser.BrowserSettings = new BrowserSettings();
            }

            Browser.BrowserSettings.WebSecurity = CefState.Disabled;
            Browser.IsBrowserInitializedChanged += BrowserControl_IsBrowserInitializedChanged;
        }

        private void BrowserControl_IsBrowserInitializedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
          Browser.ShowDevTools();
        }
    }
}
