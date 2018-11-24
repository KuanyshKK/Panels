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

namespace WpfPanels
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            TabularGrid tabularGrid = new TabularGrid();
            tabularGrid.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            GridUnits1 gridUnits1 = new GridUnits1();
            gridUnits1.Show();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            GridColumnSpan gridColSpan = new GridColumnSpan();
            gridColSpan.Show();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Canvas canvas = new Canvas();
            canvas.Show();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            StackPanelVertical stv = new StackPanelVertical();
            stv.Show();
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            StackPanelHo stv = new StackPanelHo();
            stv.Show();
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            DockPanelK stv = new DockPanelK();
            stv.Show();
        }

    }
}
