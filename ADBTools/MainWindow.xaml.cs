using System;
using System.Windows;

namespace ADBTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // 结束线程
            Application.Current.Shutdown();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            // 修改最小化窗口为隐藏
            if (WindowState == WindowState.Minimized)
            {
                Application.Current.MainWindow.Hide();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TitleBarTextBlock.Text = "ADBTools Ver" + (Application.ResourceAssembly.GetName().Version.ToString());
        }

    }
}
