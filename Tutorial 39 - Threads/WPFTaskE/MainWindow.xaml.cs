using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFTaskE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty HtmlProperty =
            DependencyProperty.RegisterAttached(
                "Html", typeof(string), typeof(MainWindow),
                new FrameworkPropertyMetadata(OnHtmlChanged)
            );

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Mr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                webClient.DefaultRequestHeaders.Add("User-Agent",
                   "Mozilla/5.0 (Windows NT 10.0; Win64; x64) " +
                   "AppleWebKit/537.36 (KHTML, like Gecko) " +
                   "Chrome/123.0.0.0 Safari/537.36");
                webClient.DefaultRequestHeaders.Add("Accept",
                    "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
                webClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");
                webClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com:80/20MB.zip").Result;
                MyButton.Dispatcher.Invoke(() =>
                {
                    MyButton.Content = "Done";
                });
            });
        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "Bla";
            Debug.WriteLine($"Thread Mr. {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(async () =>
            {
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });
            MyButton.Content = "Done";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
                webBrowser.NavigateToString(e.NewValue as string);
        }
    }
}
