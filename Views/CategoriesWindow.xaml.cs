using System;
using System.Windows;
using System.Windows.Input;


namespace InternshipProject
{
    /// <summary>
    /// Interaction logic for CategoriesWindow.xaml
    /// </summary>
    public partial class CategoriesWindow : Window
    {
        public CategoriesWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnAnimals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
