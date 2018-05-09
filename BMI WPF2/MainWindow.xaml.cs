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

        // 把身高、體重、bmi等會用到的數值設為全域變數
        public class Global
        {
           public static string height1, weight1;
            public static float H, bmi1, W;
        }

        // 拖動體重條的觸發事件
        //private void w_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
       // {
            

            
       // }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Heightnumber.Text = h.Value.ToString("0.0");
            Canvas.SetLeft(height, h.Value * 2);

            // 令Weightnumber顯示體重條的數值
            Weightnumber.Text = w.Value.ToString("0.0");
            // 令Weightnumber跟著滑桿
            Canvas.SetLeft(weight, w.Value * 4);

            double H = double.Parse(Heightnumber.Text);
            double W = double.Parse(Weightnumber.Text);

            double bmi = W / Math.Pow((H / 100), 2);
            string[] parts = bmi.ToString("0.00").Split('.');
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
