using System.Data;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using CurrencyConverter.Response;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            BindCurrency();
        }
        private async Task BindCurrency()
        {
            Rate rates = await GetRates();
            DataTable dtCurrency = new DataTable();
            dtCurrency.Columns.Add("Text");
            dtCurrency.Columns.Add("Value");
            dtCurrency.Rows.Add("-- Select --", 0);
            dtCurrency.Rows.Add("INR", rates.INR);
            dtCurrency.Rows.Add("USD", rates.JPY);
            dtCurrency.Rows.Add("EUR", rates.USD);
            dtCurrency.Rows.Add("INR", rates.NZD);
            dtCurrency.Rows.Add("USD", rates.EUR);
            dtCurrency.Rows.Add("EUR", rates.CAD);
            dtCurrency.Rows.Add("INR", rates.ISK);
            dtCurrency.Rows.Add("USD", rates.PHP);
            dtCurrency.Rows.Add("DKK", rates.DKK);
            dtCurrency.Rows.Add("CZK", rates.CZK);

            cmbFromCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbFromCurrency.SelectedValuePath = "Value";
            cmbFromCurrency.SelectedIndex = 0;
            cmbToCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedIndex = 0;
        }
        private async Task<Rate> GetRates()
        {
            string link = "https://openexchangerates.org/api/latest.json?app_id=2151c9fcc0c940b086175f56fac18249";
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(link);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK) throw new Exception("Error in API call");
                    string json = await response.Content.ReadAsStringAsync();
                    CurrencyResponse cresponse = JsonSerializer.Deserialize<CurrencyResponse>(json);
                    return cresponse.Rates;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void onConvertBtnClick(object sender, RoutedEventArgs e)
        {
            double convertedValue;
            if(!ValidateInputFields()) return;
            if(cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                convertedValue = double.Parse(txtCurrency.Text);
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N2");
            }
            else
            {
                convertedValue = (double.Parse(cmbToCurrency.SelectedValue.ToString()) * 
                    double.Parse(txtCurrency.Text)) / 
                    double.Parse(cmbFromCurrency.SelectedValue.ToString());
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N2");
            }
        }

        private bool ValidateInputFields()
        {
            bool isValid = true;
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Currency", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                txtCurrency.Focus();
                isValid = false;
            }
            else if (cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Currency From", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cmbFromCurrency.Focus();
                isValid = false;
            }
            else if (cmbToCurrency.SelectedValue == null || cmbToCurrency.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Currency To", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cmbToCurrency.Focus();
                isValid = false;
            }
            return isValid;
        }

        private void onClearBtnClick(object sender, RoutedEventArgs e)
        {
            lblCurrency.Content = string.Empty;
            if (cmbFromCurrency.Items.Count > 0)
                cmbFromCurrency.SelectedIndex = 0;
            if (cmbToCurrency.Items.Count > 0)
                cmbToCurrency.SelectedIndex = 0;
            txtCurrency.Text = string.Empty;
            txtCurrency.Focus();
        }

        private void txtCurrencyPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}