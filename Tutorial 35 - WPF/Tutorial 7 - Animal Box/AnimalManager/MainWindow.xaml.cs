using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace AnimalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["AnimalManager.Properties.Settings.animalConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            showZoos();
            showAnimals();
        }

        private void showZoos()
        {
            try
            {
                string query = "Select * From Zoo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    zooList.DisplayMemberPath = "Location";
                    zooList.SelectedValuePath = "Id";
                    zooList.ItemsSource = zooTable.DefaultView;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                using(sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    animalList.DisplayMemberPath = "Name";
                    animalList.SelectedValuePath = "Id";
                    animalList.ItemsSource = animalTable.DefaultView;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showAssociatedAnimals()
        {
            try
            {
                if (zooList.SelectedValue == null || string.IsNullOrEmpty(zooList.SelectedValue.ToString())) return;
                string zooId = zooList.SelectedValue.ToString();
                string query = " Select za.Id, a.Name AS Name From ZooAnimal za Inner Join " +
                    " Animal a On za.AnimalId = a.Id Where za.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ZooId", zooId);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    DataTable associatedAnimalTable = new DataTable();
                    sqlDataAdapter.Fill(associatedAnimalTable);
                    associatedAnimalList.DisplayMemberPath = "Name";
                    associatedAnimalList.SelectedValuePath = "Id";
                    associatedAnimalList.ItemsSource = associatedAnimalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zooList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (zooList.SelectedValue != null)
            {
                showAssociatedAnimals();
                showZooInTextBox();
            }
        }

        private void showZooInTextBox()
        {
            try
            {
                if (zooList.SelectedValue == null) return;
                string query = "Select TOP 1 * FROM Zoo WHERE Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", zooList.SelectedValue.ToString());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    nameTextBox.Text = reader["Location"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void addAnimalToZooButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateZooId()) return;
                if (!ValidateAnimalId()) return;
                string query = "Insert into ZooAnimal Values (@ZooId, @AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", zooList.SelectedValue.ToString());
                sqlCommand.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue.ToString());
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                showAssociatedAnimals();
            }
        }

        private void deleteAnimalButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateAnimalId()) return;
                string query = "DELETE FROM Animal WHERE Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                showAnimals();
                showAssociatedAnimals();
            }
        }

        private void addZooButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateNameTextInput()) return;
                string query = "Insert into Zoo Values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", nameTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                nameTextBox.Text = string.Empty;
                showZoos();
            }
        }

        private void addAnimalButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateNameTextInput()) return;
                string query = "Insert into Animal Values (@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                nameTextBox.Text = string.Empty;
                showAnimals();
            }
        }

        private void updateZooButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateZooId()) return;
                if (!ValidateNameTextInput()) return;
                string zooId =  zooList.SelectedValue.ToString();
                string query = "UPDATE Zoo SET Location = @Location WHERE Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", nameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@ZooId", zooId);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                showZoos();
            }
        }

        private void updateAnimalButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateAnimalId()) return;
                if (!ValidateNameTextInput()) return;
                string animalId = animalList.SelectedValue.ToString();
                string query = "UPDATE Animal SET Name = @Name WHERE Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@AnimalId", animalId);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                showAnimals();
                showAssociatedAnimals();
            }
        }

        private bool ValidateZooId()
        {
            bool isValid = true;
            if (zooList.SelectedValue == null || string.IsNullOrEmpty(zooList.SelectedValue.ToString()))
            {
                isValid = false;
                MessageBox.Show("Please select a zoo");
            }
            return isValid;
        }

        private bool ValidateAssociateAnimalId ()
        {
            bool isValid = true;
            if (associatedAnimalList.SelectedValue == null || string.IsNullOrEmpty(associatedAnimalList.SelectedValue.ToString()))
            {
                isValid = false;
                MessageBox.Show("Please select an associated animal");
            }
            return isValid;
        }

        private bool ValidateAnimalId()
        {
            bool isValid = true;
            if (animalList.SelectedValue == null || string.IsNullOrEmpty(animalList.SelectedValue.ToString()))
            {
                isValid = false;
                MessageBox.Show("Please select an animal");
            }
            return isValid;
        }

        private bool ValidateNameTextInput()
        {
            bool isValid = true;
            if(nameTextBox.Text == null || string.IsNullOrEmpty(nameTextBox.Text))
            {
                isValid = false;
                MessageBox.Show("Please enter a name");
            }
            return isValid;
        }

        private void deleteZooButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Zoo WHERE Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", zooList.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                showZoos();
            }
        }

        private void removeAnimalFromZooButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateZooId()) return;
                if (!ValidateAssociateAnimalId()) return;
                string query = "DELETE FROM ZooAnimal WHERE Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Id", associatedAnimalList.SelectedValue.ToString());
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                showAssociatedAnimals();
            }
        }

        private void animalList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (animalList.SelectedValue == null) return;
                string query = "Select TOP 1 * FROM Animal WHERE Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue.ToString());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.Read())
                {
                    nameTextBox.Text = reader["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
