using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Serialization;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        private int currencyId = 0;

        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
            GetData();
        }

        //CRUD Operations
        public void CreateConnection()
        {
            string connnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            con = new SqlConnection(connnectionString);
            con.Open();
        }

        private void BindCurrency()
        {
            CreateConnection();
            DataTable dataTable = new DataTable();
            cmd = new SqlCommand("SELECT Id, CurrencyName FROM Currency_Master", con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            DataRow newRow = dataTable.NewRow();
            newRow["Id"] = 0;
            newRow["CurrencyName"] = "-- Select --";
            dataTable.Rows.InsertAt(newRow, 0);
            if(dataTable != null && dataTable.Rows.Count > 0)
            {
                cmbFromCurrency.ItemsSource = dataTable.DefaultView;
                cmbToCurrency.ItemsSource = dataTable.DefaultView;
            }
            con.Close();
            cmbFromCurrency.DisplayMemberPath = "CurrencyName";
            cmbFromCurrency.SelectedValuePath = "Id";
            cmbFromCurrency.SelectedIndex = 0;

            cmbToCurrency.DisplayMemberPath = "CurrencyName";
            cmbToCurrency.SelectedValuePath = "Id";
            cmbToCurrency.SelectedIndex = 0;

        }

        private void onConvertBtnClick(object sender, RoutedEventArgs e)
        {
            double convertedValue;
            if (!ValidateInputFields()) return;
            if (cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                convertedValue = double.Parse(txtCurrency.Text);
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N3");
            }
            else
            {
                convertedValue = (double.Parse(cmbFromCurrency.SelectedValue.ToString()) *
                    double.Parse(txtCurrency.Text)) /
                    double.Parse(cmbToCurrency.SelectedValue.ToString());
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N3");
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

        private void onSaveBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateAmountInputBox() || !ValidateCurrencyNameInputBox()) return;
                if(currencyId > 0)
                {
                    UpdateCurrency();
                }
                else
                {
                    SaveCurrency();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateAmountInputBox()
        {
            if(string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please Enter Amount", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                txtAmount.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateCurrencyNameInputBox()
        {
            if (string.IsNullOrEmpty(txtCurrencyName.Text))
            {
                MessageBox.Show("Please Enter Currency Name", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                txtCurrencyName.Focus();
                return false;
            }
            return true;
        }

        private void SaveCurrency()
        {
            if(MessageBox.Show("Are you sure you want to save ?", "Information", MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CreateConnection();
                cmd = new SqlCommand("INSERT INTO Currency_Master (Amount, CurrencyName) Values (@Amount, @CurrencyName)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@CurrencyName", txtCurrencyName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            Reset();
        }

        private void UpdateCurrency()
        {
            if(
                MessageBox.Show("Are you sure you want to update ?", "Information", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes
            )
            {
                CreateConnection();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("Update Currency_Master Set Amount = @Amount, CurrencyName = @CurrencyName WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", currencyId);
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@CurrencyName", txtCurrencyName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            Reset();
        }

        private void Reset()
        {
            try
            {
                txtAmount.Text = string.Empty;
                txtCurrencyName.Text = string.Empty;
                btnSave.Content = "Save";
                GetData();
                currencyId = 0;
                BindCurrency();
                txtAmount.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GetData()
        {
            CreateConnection();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Currency_Master", con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
                dgvCurrency.ItemsSource = dt.DefaultView;
            else
                dgvCurrency.ItemsSource = null;
            con.Close();
        }
        
        private void onCancelBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgvCurrencySelectedCellsChanged(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            try
            {
                DataGrid grd = (DataGrid)sender;
                DataRowView rowSelected = grd.CurrentItem as DataRowView;
                if(rowSelected != null && dgvCurrency.Items.Count > 0 && grd.SelectedCells.Count > 0)
                {
                    currencyId = Int32.Parse(rowSelected["Id"].ToString());
                    if (grd.SelectedCells[0].Column.DisplayIndex == 0) TriggerEditAction(rowSelected);
                    else if (grd.SelectedCells[0].Column.DisplayIndex == 1) TriggerDeleteAction(rowSelected);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TriggerEditAction(DataRowView rowSelected)
        {
            txtAmount.Text = rowSelected["Amount"].ToString();
            txtCurrencyName.Text = rowSelected["CurrencyName"].ToString();
            btnSave.Content = "Update";
        }

        private void TriggerDeleteAction(DataRowView rowSelected)
        {
            if (MessageBox.Show("Are you sure you want to delete ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CreateConnection();
                cmd = new SqlCommand("Delete From Currency_Master Where Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", currencyId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            Reset();
        }
    }
}