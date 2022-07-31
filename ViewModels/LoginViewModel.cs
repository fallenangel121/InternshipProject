using Prism.Commands;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

#nullable disable warnings

namespace InternshipProject.Views
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private String username;
        private String password;
        private User user;
        private DelegateCommand loginCommand;

        public LoginViewModel()
        {

        }

        //public ICommand LoginCommand
        //{
        //    get
        //    {
        //        return loginCommand ?? (loginCommand = new DelegateCommand(() =>
        //        {
        //            if (String.IsNullOrEmpty(this.username))
        //            {
        //                MessageBox.Show("Моля въведете потребителско име!");
        //            }
        //            else if (String.IsNullOrEmpty(this.password))
        //            {
        //                MessageBox.Show("Моля въведете парола!");
        //            }
        //            else
        //            {
        //                UserDb context = new UserDb();
        //                user = context.Users.FirstOrDefault(u => u.username == this.Username && u.password == this.Password);

        //                if (user != null)
        //                {
        //                    Window window = new MainWindow(user);
        //                    window.Show();
        //                    System.Windows.Application.Current.MainWindow.Close();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Грешни данни за вход!");
        //                }
        //            }
        //        }));
        //    }
        //}

        //public String Username
        //{
        //    get
        //    {
        //        return username;
        //    }
        //    set
        //    {
        //        username = value.Trim();
        //        OnPropertyChanged("Username");
        //    }
        //}

        //public String Password
        //{
        //    get
        //    {
        //        return password;
        //    }
        //    set
        //    {
        //        password = value;
        //        OnPropertyChanged("Password");
        //    }
        //}

        //private void OnPropertyChanged(String propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;

        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        //private void btnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    CategoriesWindow categoriesWindow = new CategoriesWindow();
        //    System.Windows.Application.Current.MainWindow.Close();
        //    categoriesWindow.Show();

        //}

        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    System.Windows.Application.Current.MainWindow.DragMove();
        //}

        //private void btnExit_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Сигурни ли сте, че желаете да напуснете системата",
        //            "Изход от системата", MessageBoxButton.YesNo);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        System.Windows.Application.Current.MainWindow.Close();
        //    }
        //}
    }
}
