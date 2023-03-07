using System;
using System.Collections.Generic;
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
using System.IO;

namespace mileage_efficiently
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
        public static DateTime Now { get; }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int miles, gallons;
            double MpG;
            string TextPath = @"C:\Users\mackr\source\repos\mileage efficiently\mileage efficiently\Exceptionfile.txt";
            string correct = @"C:\Users\mackr\source\repos\mileage efficiently\mileage efficiently\MilesperGallon.txt";
            bool flag = false;


            try
            {
                miles = int.Parse(txtMilesDriven.Text);
                gallons = int.Parse(txtGas.Text);
                MpG = (double)miles / (double)gallons;

                txtResult.Text = MpG.ToString();
            }
            catch (Exception ex)
            {
                flag = true;
                MessageBox.Show(ex.Message);
                File.AppendAllText(TextPath, ex.ToString() + "\n");
            }
            if (!flag)
            {
                DateTime localDate = DateTime.Now;
                File.AppendAllText(correct , txtResult.Text + " " + localDate.ToString() + "\n");
            }
        }

    }
}
