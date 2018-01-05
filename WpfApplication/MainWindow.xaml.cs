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

namespace WpfApplication
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new {
                管理者 = new { 姓 = "岩永", 名 = "信之" },
                コンテンツ = new[]
                {
                    new { タイトル = "C# 入門", URL = "csharp" },
                    new { タイトル = "信号処理", URL = "dsp" },
                    new { タイトル = "力学", URL = "dynamics" },
                }
            };
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button_Click_1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button_Click_2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button_Click_3");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button_Click_4");
        }
    }
}
