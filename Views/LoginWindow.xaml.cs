using InternshipProject.Views;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace InternshipProject

{
    public partial class LoginWindow : Window
    {
        public PropertyChangedEventHandler PropertyChanged { get; private set; }

        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
           
        }

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            CategoriesWindow categoriesWindow = new CategoriesWindow();
            System.Windows.Application.Current.MainWindow.Close();
            categoriesWindow.Show();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //System.Windows.Application.Current.MainWindow.DragMove();
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Сигурни ли сте, че желаете да напуснете системата",
                    "Изход от системата", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //System.Windows.Application.Current.MainWindow.Close();
                Close();
            }
        }
    }
}
