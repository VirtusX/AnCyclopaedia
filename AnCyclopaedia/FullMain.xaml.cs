using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AnCyclopaedia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FullMain : Page
    {
        public FullMain()
        {
            this.InitializeComponent();
          
        }
        private void PartModelButton_Click(object sender, RoutedEventArgs e)
        {
            FullModel.Visibility = Visibility.Collapsed;
            PartModel.Visibility = Visibility.Visible;
            PartModelText.Visibility = Visibility.Visible;
            More.Visibility = Visibility.Visible;
            Full.Visibility = Visibility.Visible;
        }

        private void More_Click(object sender, RoutedEventArgs e)
        {
            PartModel.Visibility = Visibility.Collapsed;
            PartModelText.Visibility = Visibility.Collapsed;
            More.Visibility = Visibility.Collapsed;
            MoreText.Visibility = Visibility.Visible;
            Less.Visibility = Visibility.Visible;
            Full.Visibility = Visibility.Collapsed;

        }

        private void Less_Click(object sender, RoutedEventArgs e)
        {
            MoreText.Visibility = Visibility.Collapsed;
            Less.Visibility = Visibility.Collapsed;
            PartModel.Visibility = Visibility.Visible;
            PartModelText.Visibility = Visibility.Visible;
            More.Visibility = Visibility.Visible;
            Full.Visibility = Visibility.Visible;
        }

        private void Full_Click(object sender, RoutedEventArgs e)
        {
            FullModel.Visibility = Visibility.Visible;
            PartModel.Visibility = Visibility.Collapsed;
            PartModelText.Visibility = Visibility.Collapsed;
            More.Visibility = Visibility.Collapsed;
            Full.Visibility = Visibility.Collapsed;
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
