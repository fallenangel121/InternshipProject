using InternshipProject.Views;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace InternshipProject

{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
           
        }
    }
}
