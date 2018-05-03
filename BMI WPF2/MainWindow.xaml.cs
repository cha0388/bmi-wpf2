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

namespace BMI_WPF2
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
        private void w_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Weightnumber.Text = w.Value.ToString("0.0");
            Canvas.SetLeft(weight, w.Value * 4);
        }

        private void h_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Heightnumber.Text = h.Value.ToString("0.0");
            Canvas.SetLeft(height, h.Value * 2);
            double H = double.Parse(Heightnumber.Text);
            double W = double.Parse(Weightnumber.Text);
            double bmi = W / Math.Pow((H / 100), 2);
            string[] parts = bmi.ToString().Split('.');
            bminumber1.Text = parts[0];
            if (parts.Length > 1)
            {
                bminumber2.Text = "." + parts[1];
            }
            else
            {
                bminumber2.Text = ".0";
            }
        }
    }
}
