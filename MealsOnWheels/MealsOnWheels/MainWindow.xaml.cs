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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CoffeeShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager manager;
        string linkString = "Data Source=Macks;Initial Catalog=dbo.ManangerTable;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public string sqlCommand;


        public MainWindow()
        {
            InitializeComponent();
        }

        string CoffeeType, Quantity;
        bool Small, Medium, Large, Sugar, Cream;



////////////////////////////////////////////////////////////////////////////////////////
///Ingrienets///
////////////////////////////////////////////////////////////////////////////////////////

        private void rbLarge_Checked(object sender, RoutedEventArgs e)
        {
            if (rbLarge.IsChecked == true)
                MessageBox.Show(rbLarge.Content.ToString());
        }


        private void rbMedium_Checked(object sender, RoutedEventArgs e)
        {
            if (rbMedium.IsChecked == true)
                MessageBox.Show(rbMedium.Content.ToString());
        }

        private void rbSmall_Checked(object sender, RoutedEventArgs e)
        {
            if (rbSmall.IsChecked == true)
                MessageBox.Show(rbSmall.Content.ToString());          
            else
                MessageBox.Show("Oof");
        }

        private void cbSugar_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        ///Placing Order///
        ////////////////////////////////////////////////////////////////////////////////////////

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrder();
        }
        public void AddOrder()
        {
            try
            {
                Random rnd = new Random();
                int id = rnd.Next();

                SqlConnection sc = new SqlConnection(linkString);
                SqlCommand com = new SqlCommand();
                com.Connection = sc;

                sc.Open();
                if (rbSmall.IsChecked == true)
                {
                    com.CommandText = ("SELECT Small_Price  FROM dbo.CoffeePriceTable WHERE Coffee_Type ='" + cmbCoffeeType.Text + "'");
                }
                else if (rbMedium.IsChecked == true)
                {
                    com.CommandText = ("SELECT Medium_Price FROM dbo.CoffeePriceTable WHERE Coffee_Type = '" + cmbCoffeeType.Text + "'");
                }
                else if (rbLarge.IsChecked == true)
                {
                    com.CommandText = ("SELECT Large_Price  FROM dbo.CoffeePriceTable WHERE Coffee_Type ='" + cmbCoffeeType.Text + "'");
                }
                double price = 0.00;
                string size;
                if (rbSmall.IsChecked == true)
                {
                    size = "small";
                    using (SqlDataReader read = com.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            price = ((double)read["Small_Price"]);
                            MessageBox.Show(price.ToString());
                        }
                    }
                }
                else if (rbMedium.IsChecked == true)
                {
                    size = "medium";
                    using (SqlDataReader read = com.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            price = ((double)read["Medium_Price"]);
                            MessageBox.Show(price.ToString());
                        }
                    }
                }
                else if (rbLarge.IsChecked == true)
                {
                    size = "large";
                    using (SqlDataReader read = com.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            price = ((double)read["Large_Price"]);
                            MessageBox.Show(price.ToString());
                        }
                    }
                }

                DateTime today = DateTime.Today;
                sqlCommand = "INSERT INTO dbo.SalesTable (Id_Sale,Quantity,Description,Price ,Total,Date) VALUES ('" + id + "','" + cmbQtity.Text + "','" + cmbCoffeeType.Text + "','" + price + "','" + (price * Int32.Parse(cmbQtity.Text)) + "', " + today + ")";
                sqlCon = new SqlConnection(linkString);
                sqlCon.Open();

                cmd = new SqlCommand(sqlCommand, sqlCon);
                adapter.InsertCommand = cmd;

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("order added succesfully");
                }
                cmd.Dispose();
                sqlCon.Dispose();

                this.manager = new Manager(cmbCoffeeType.Text, price, size, 5, "sugar, cream");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        ///Interface///
        ////////////////////////////////////////////////////////////////////////////////////////

        interface Interface1
        {
            public double totalOrderSummary(double price, int qntity);
        }

        public class Order : Interface1
        {
            public string coffeeType;
            public double price;
            public string size;
            public int qntity;
            public string ingredients;

            public Order(string coffeeType, double price, string size, int qnt, string ingredients)
            {
                this.coffeeType = coffeeType;
                this.price = price;
                this.size = size;
                this.qntity = qnt;
                this.ingredients = ingredients;
            }

            public virtual double totalOrderSummary(double price, int qnt)
            {
                double bill = price * qnt;
                return bill;
            }
            public virtual string totalOrderSummary(int qnt, string type, string size, string ingredients, double price)
            {
                string message = qnt + " " + type + " " + size + ingredients + " " + price + " " + totalOrderSummary(price, qnt);
                return message;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        ///Order///
        ////////////////////////////////////////////////////////////////////////////////////////

        public class Manager : Order
        {
            string conString = "Data Source=LAPTOP-E24492J8;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
            SqlConnection sqlCon;
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            public string SqlAdd;
            string fileName = @"C:\Temp\order.txt";

            public Manager(string coffeeType, double price, string size, int qnt, string ingredients) : base(coffeeType, price, size, qnt, ingredients)
            {
            }
            public override double totalOrderSummary(double price, int qnt)
            {
                double bill = price * qnt;
                return bill;
            }
            public override string totalOrderSummary(int qnt, string type, string size, string ingredients, double price)
            {
                string message = qnt + " " + type + " " + size + ingredients + " " + price + " " + totalOrderSummary(price, qnt);
                return message;
            }
            public void DisplayInfos(int period)
            {

            }

            public void SaveToTxt(int period)
            {
                using (StreamWriter sw = new StreamWriter (@"C:\Users\mackr\Desktop\Project.txt"))
                sw.WriteLine("Order date:", DateTime.Now.ToString());
                sw.WriteLine(this.qntity + " x " + this.size + " " + this.coffeeType + "@ " + this.price);
                Console.WriteLine("Test");
                //
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        //////
        ////////////////////////////////////////////////////////////////////////////////////////


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //manager.SaveToTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            if (rbSmall.IsChecked == true)
            {
                sqlCommand = "SELECT Small_Price  FROM dbo.CoffeePriceTable WHERE CoffeePriceTable =" + cmbCoffeeType.Text;
            }
            else if (rbMedium.IsChecked == true)
            {
                sqlCommand = "SELECT Medium_Price FROM dbo.CoffeePriceTable WHERE CoffeePriceTable =" + cmbCoffeeType.Text;
            }
            else if (rbLarge.IsChecked == true)
            {
                sqlCommand = "SELECT Large_Price  FROM dbo.CoffeePriceTable WHERE CoffeePriceTable =" + cmbCoffeeType.Text;
            }

            sqlCon = new SqlConnection(linkString);
            sqlCon.Open();

            SqlCommand command = new SqlCommand(sqlCommand, sqlCon);



            cmd.Dispose();
            sqlCon.Dispose();

            this.manager = new Manager(cmbCoffeeType.Text, 100.50, "Large", 5, "sugar, cream");
        }
    }
}
