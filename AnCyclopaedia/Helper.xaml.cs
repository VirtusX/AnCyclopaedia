using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.EntityFrameworkCore;

namespace AnCyclopaedia.Assets {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Helper : Page
    {
        
        public Helper()
        {
            InitializeComponent();
        }
        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            Navi.IsPaneOpen = !Navi.IsPaneOpen;
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ViewModel));
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

    public class BodyText
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BigText { get; set; }
        public string SmallText { get; set; }
    }

    public class BodyContext : DbContext
    {
        public DbSet<BodyText> Body { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=BodyData.db");
        }
    }
    
}
