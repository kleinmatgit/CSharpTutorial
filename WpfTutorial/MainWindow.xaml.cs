using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Wpf.BusyIndicatorEasy;

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginButton.Content = "Loading...";
                LoginButton.IsEnabled = false;
                LoginButton.Content = await LoginAsync();
                LoginButton.IsEnabled = true;
            }
            catch (Exception)
            {
                LoginButton.Content = "Internal Error!";
            }
        }

        private async Task<string> LoginAsync()
        {
            try
            {
                var loginTask = Task.Run(() =>
                {
                    Thread.Sleep(2000);

                    //uncomment to test exception throw within async method
                    //throw new UnauthorizedAccessException();

                    return "Login successfull!";
                });

                var logTask = Task.Delay(1000); //simulate logs
                var purchaseTask = Task.Delay(2000); //simulate purchase

                await Task.WhenAll(loginTask, logTask, purchaseTask);

                return loginTask.Result;
            }
            catch (Exception)
            {

                return "Login Failed!";
            }
            
        }
    }
}
