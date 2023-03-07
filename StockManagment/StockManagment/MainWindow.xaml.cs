using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockManagment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Product, Category, SellingPrice, CostPrice, Quantity, Barcode;

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            ProductList prodlist new ProductList();
            prodlist.Show();
            this.Close();
        }

        public MainWindow()
        {
            InitializeComponent();

        }

        

        private void btnBCd_Click(object sender, RoutedEventArgs e)
        {
            PrintBCode printbarcode = new PrintBCode();
            printbarcode.Show();
            this.Close();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Category = cmbCat.Text;
            Product = txtPrdName.Text;
            SellingPrice = txtPrdPrice_Copy.Text;
            CostPrice = txtPrdCostPrice.Text;
            Quantity = txtPrdQuantity.Text;
            Barcode = Bcode.Text;

            string connectionString = "Data Source=Macks;Initial Catalog=StockSystem;Integrated Security=True";
            string query = "INSERT INTO dbo.Products(ProductCategory,ProductName,SellingPrice,CostPrice,Quantity,Barcode)" + 
                "VALUES('"+ Category + "', '"+ Product +"','"+ SellingPrice + "','" + CostPrice + "','" + Quantity + "','" + Barcode + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Product has been successfully saved!");
            }
            connection.Close();

        }
    }

    

}
