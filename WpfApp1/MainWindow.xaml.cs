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

namespace WpfApp1
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

        // 開啟檔案按鈕
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                //讀檔(路徑)
                TextArea.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }


        // 存檔檔案按鈕
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                //寫入檔案
                System.IO.File.WriteAllText(dlg.FileName, TextArea.Text);
            }
        }
        private void frontSize12_Click(object sender, RoutedEventArgs e)

        {
            TextArea.FontSize = 12;
        }
        private void frontSize18_Click(object sender, RoutedEventArgs e)

        {
            TextArea.FontSize = 20;
        }
        private void frontSize24_Click(object sender, RoutedEventArgs e)

        {
            TextArea.FontSize = 24;
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            TextArea.Text = "";
        }

        private void SaveasBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();


            Nullable<bool> result = dlg.ShowDialog();
        }


    }
}
