using Hardcodet.Wpf.TaskbarNotification;
using System.Windows;

namespace ADBTools
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static TaskbarIcon TaskbarIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            TaskbarIcon = (TaskbarIcon)FindResource("Taskbar");
            TaskbarIcon.ToolTipText = "ADBTools Ver" + (Application.ResourceAssembly.GetName().Version.ToString());

        }
    }
}
