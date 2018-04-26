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
            double height = int.Parse(txtbox_height.Text)/100;
            double weight = int.Parse(txtboc_weight.Text);
            double bmi = weight / (height * height);

            txtbox_result.Text =bmi.ToString() ;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("恭喜你！要繼續保持下去哦！");
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("這樣不行哦！好好努力減肥吧！");
        }
    }
}
