using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ind.project.petashvili1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LeftGrid.Visibility == Visibility.Hidden)
                LeftGrid.Visibility = Visibility.Visible;
            else
                LeftGrid.Visibility = Visibility.Hidden;
        }

        private void Id_Click(object sender, RoutedEventArgs e)
        {
            Window1 IdWindow = new Window1();
            IdWindow.Show();
        }

        private void Bezopasno_Click(object sender, RoutedEventArgs e)
        {
            Window2 BezoWindow = new Window2();
            BezoWindow.Show();
        }

        private void Yvedomlenie_Click(object sender, RoutedEventArgs e)
        {
            Window3 YvedWindow = new Window3();
            YvedWindow.Show();
        }

        private void Parol_Click(object sender, RoutedEventArgs e)
        {
            Window4 ParolWindow = new Window4();
            ParolWindow.Show();
        }

        private void Pomogite_Click(object sender, RoutedEventArgs e)
        {
            Window5 PomogiteWindow = new Window5();
            PomogiteWindow.Show();
        }

        private void Podderzhka_Click(object sender, RoutedEventArgs e)
        {
            Window6 PodWindow = new Window6();
            PodWindow.Show();
        }

        private void PaymentsButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PaymentsWindow paymentsWindow = new PaymentsWindow();
            paymentsWindow.Show();
        }

        private void Daan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DaanWindow daanWindow = new DaanWindow();
            daanWindow.Show();
        }

        private void Rashod_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RashodWindow rashodWindow = new RashodWindow();
            rashodWindow.Show();
        }

        private void DepositButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PopolnenieWindow popolnenieWindow = new PopolnenieWindow();
            popolnenieWindow.Show();
        }

        private void BalanceButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BalanceWindow balanceWindow = new BalanceWindow();
            balanceWindow.Show();
        }

        private void Chetpassive_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ChetaWindow chetaWindow = new ChetaWindow();
            chetaWindow.Show();
        }
    }
}