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

namespace HW2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User user;
        public MainWindow()
        {
            InitializeComponent();
            using (var context = new HwContext())
            {
                user = context.Users.ToList()[0];
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            fullNameTB.Text = user.FullName;
            hobbiesTB.Text = user.HobbyList;
            loginTB.Text = user.Login;
            Uri uri = new Uri(user.ImagePath, UriKind.RelativeOrAbsolute);
            ImageSource imgSource = new BitmapImage(uri);
            profileImage.Source = imgSource;
            //profileImage.Source = new BitmapImage(new Uri(user.ImagePath, UriKind.Absolute));
        }

        private void Ava1BtnClick(object sender, RoutedEventArgs e)
        {
            profileImage.Source = new BitmapImage(new Uri("ava1.jpg", UriKind.RelativeOrAbsolute));
        }

        private void Ava2BtnClick(object sender, RoutedEventArgs e)
        {
            profileImage.Source = new BitmapImage(new Uri("ava2.jpg", UriKind.RelativeOrAbsolute));
        }

        private void Ava3BtnClick(object sender, RoutedEventArgs e)
        {
            profileImage.Source = new BitmapImage(new Uri("ava3.jpg", UriKind.RelativeOrAbsolute));
        }

        private void Ava4BtnClick(object sender, RoutedEventArgs e)
        {
            profileImage.Source = new BitmapImage(new Uri("ava4.jpg", UriKind.RelativeOrAbsolute));
        }

        private void AcceptBtnClick(object sender, RoutedEventArgs e)
        {
            using (var context = new HwContext())
            {
                var user = context.Users.ToList()[0];
                if (fullNameTB.Text != string.Empty)
                {
                    user.FullName = fullNameTB.Text;
                }
                if (hobbiesTB.Text != string.Empty)
                {
                    user.HobbyList = hobbiesTB.Text;
                }
                if (loginTB.Text != string.Empty)
                {
                    user.Login = loginTB.Text;
                }
                if (user.ImagePath != profileImage.Source.ToString())
                {
                    user.ImagePath = profileImage.Source.ToString();
                }
                context.Update(user);
                context.SaveChanges();
            }
        }
    }
}
