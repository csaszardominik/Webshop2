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
using System.Windows.Shapes;
using Webshop.UserControls;

namespace Webshop
{
    /// <summary>
    /// Interaction logic for DeviceOrder.xaml
    /// </summary>
    public partial class DeviceOrder : Window
    {
        public DeviceOrder()
        {
            InitializeComponent();

            var devices = new List<string> { "ASUS", "DELL", "IPAD", "IPHONE", "LENOVO", "LENOVO TABLET", "MAC", "MICROSOFT SURFACE", "NOTHING", "PIXEL", "SAMSUNG", "SAMSUNG TABLET" };
            DeviceCmbx.ItemsSource = devices;

        }
        private void Orders_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {


        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Success");
            this.Close();
        }
    }
}
