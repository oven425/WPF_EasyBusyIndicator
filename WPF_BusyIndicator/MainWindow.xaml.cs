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
using System.ComponentModel;

namespace WPF_BusyIndicator
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

        async private void Button_busy_basic_Click(object sender, RoutedEventArgs e)
        {
            this.image_busy_basic.IsEnabled = true;
            await Task.Delay(5000);
            this.image_busy_basic.IsEnabled = false;
        }

        async private void Button_busy_mask_Click(object sender, RoutedEventArgs e)
        {
            this.image_busy_mask.IsEnabled = true;
            this.grid_mask.Visibility = Visibility.Visible;
            await Task.Delay(5000);
            this.image_busy_mask.IsEnabled = false;
            this.grid_mask.Visibility = Visibility.Collapsed;
        }
    }

}
