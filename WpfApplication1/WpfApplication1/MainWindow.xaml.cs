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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btm_clearHeight_Click(object sender, RoutedEventArgs e)
        {
            txtbox_height.Text = "";

        }

        private void btn_clearWieght_Click(object sender, RoutedEventArgs e)
        {
            txtboc_weight.Text = "";
        }

        private void btn_calculate_Click(object sender, RoutedEventArgs e)
        {
            double height = int.Parse(txtbox_height.Text);
            double weight = int.Parse(txtboc_weight.Text);

            double mheight = height / 100;
            double hh = mheight * mheight;
            double bmi = weight / hh;

            txtbox_result.Text =bmi.ToString() ;
        }
    }
}
