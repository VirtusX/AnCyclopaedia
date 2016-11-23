using AnCyclopaedia.Assets;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AnCyclopaedia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewModel : Page
    {
        public ViewModel()
        {
            InitializeComponent();
        }
        private void ts1_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleswitch = sender as ToggleSwitch;
            if (toggleswitch != null)
            {
                Helper.Visibility = toggleswitch.IsOn ? Visibility.Visible : Visibility.Collapsed;
            }
        }
        private void Brain_Click(object sender, RoutedEventArgs e)
        {
            Guider.Visibility = Visibility.Visible;
            Model3d.Visibility = Visibility.Visible;
        }

        private void Heart_Click(object sender, RoutedEventArgs e)
        {
            Guider.Visibility = Visibility.Visible;
        }

        private void Kidneys_Click(object sender, RoutedEventArgs e)
        {
            Guider.Visibility = Visibility.Visible;
        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            Navi.IsPaneOpen = !Navi.IsPaneOpen;
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        private void MenuButton4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Helper));
        }
        private void MenuButton5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Help));
        }
        private void Theme_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FullMain));
        }
        private void Fullscreen_Click(object sender, RoutedEventArgs e)
        {
            ApplicationView view = ApplicationView.GetForCurrentView();

            bool isInFullScreenMode = view.IsFullScreenMode;

            if (isInFullScreenMode)
            {
                view.ExitFullScreenMode();
            }
            else
            {
                view.TryEnterFullScreenMode();
            }
        }
    }
}
