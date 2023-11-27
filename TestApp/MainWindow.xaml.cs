using OpenTK.Wpf;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GLWpfControlSettings settings = new GLWpfControlSettings
            {
                MajorVersion = 2,
                MinorVersion = 1,
            };

            openTk.Start(settings);
            openTk.Render += OpenTk_Render; ;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }


        private void OpenTk_Render(TimeSpan obj)
        {
        }
    }
}