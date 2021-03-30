using System;
using System.Windows;
using WpfRectangleGrid.ViewModels;

namespace WpfRectangleGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel model = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void btnInvalidate_Click(object sender, RoutedEventArgs e)
        {
            int i = new Random().Next(0, 399);
            
            model.Cells[i].IsValid = false;
        }
    }
}
