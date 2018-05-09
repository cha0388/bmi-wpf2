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

        // 拖動身高條及體重條的觸發事件
        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 令Heightnumber顯示身高條的數值
            Heightnumber.Text = h.Value.ToString("0.0");
            // 令Heightnumber跟著滑桿
            Canvas.SetLeft(height, h.Value * 2);

            // 令Weightnumber顯示體重條的數值
            Weightnumber.Text = w.Value.ToString("0.0");
            // 令Weightnumber跟著滑桿
            Canvas.SetLeft(weight, w.Value * 4);

            // 設變數H、W的值分別為Heightnumber及Weightnumber顯示的數值
            double H = double.Parse(Heightnumber.Text);
            double W = double.Parse(Weightnumber.Text);

            // 計算bmi值
            double bmi = W / Math.Pow((H / 100), 2);

            // 將bmi值分為整數部分及小數部分
            string[] parts = bmi.ToString("0.00").Split('.');

            // 整數部分為parts[0]，顯示在bminumber1
            bminumber1.Text = parts[0];

            // 判斷是否有小數
            if (parts.Length > 1)
            {
                // 有的話將小數顯示在bminumber2
                bminumber2.Text = "." + parts[1];
            }
            else
            {
                // 沒有的話bminumber2顯示0
                bminumber2.Text = ".0";
            } 
        }
    }
}
