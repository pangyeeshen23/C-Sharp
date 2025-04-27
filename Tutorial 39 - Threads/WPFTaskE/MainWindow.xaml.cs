using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Windows;

namespace WPFTaskE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
            HttpClient webClient = new HttpClient();
            webClient.DefaultRequestHeaders.Add("User-Agent",
           "Mozilla/5.0 (Windows NT 10.0; Win64; x64) " +
           "AppleWebKit/537.36 (KHTML, like Gecko) " +
           "Chrome/123.0.0.0 Safari/537.36");

            webClient.DefaultRequestHeaders.Add("Accept",
                "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");

            webClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");

            // Optional: Accept-Encoding for gzip
            webClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com:80/20MB.zip").Result;
            MyButton.Content = "Done";
        }
    }
}
