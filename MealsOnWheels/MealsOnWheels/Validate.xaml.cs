using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace CoffeeShop
{
    /// <summary>
    /// Interaction logic for Validate.xaml
    /// </summary>
    public partial class Validate : Page
    {
        public Validate()
        {
            InitializeComponent();
        }

        string linkString = "Data Source=Macks;Initial Catalog=dbo.ManangerTable;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string SqlAdd;
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            register();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int id = rnd.Next();
                SqlAdd = "INSERT INTO dbo.ManagerTable (Id_Man ,Username, Password) VALUES ('" + id + "','" + txtName.Text + "','" + txtPassword.Text + "')";
                sqlCon = new SqlConnection(linkString);
                sqlCon.Open();

                cmd = new SqlCommand(SqlAdd, sqlCon);
                adapter.InsertCommand = cmd;

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("You've registered succesfully");
                }
                cmd.Dispose();
                sqlCon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
