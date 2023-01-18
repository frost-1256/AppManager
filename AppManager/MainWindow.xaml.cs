using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AppManager
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo explorer = new ProcessStartInfo();
            explorer.FileName = "explorer";
            Process.Start(explorer);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("終了時にエラーが出ます");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo bdcam = new ProcessStartInfo();
            bdcam.FileName = @"C:\Program Files\Bandicam\bdcam.exe";
            Process.Start(bdcam);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo inksc = new ProcessStartInfo();
            inksc.FileName = @"C:\Program Files\Inkscape\bin\inkscape.exe";
            Process.Start(inksc);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo capcut = new ProcessStartInfo();
            capcut.FileName = @"C:\Users\sae.AMDRYZEN3\AppData\Local\CapCut\Apps\CapCut.exe";
            Process.Start(capcut);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo gimp = new ProcessStartInfo();
            gimp.FileName = @"C:\Program Files\GIMP 2\bin\gimp-2.10.exe";
            Process.Start(gimp);
        }
    }
}
