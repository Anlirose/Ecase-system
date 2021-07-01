using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace eCase
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Welcome));
            TitleTextBlock.Text = "Welcome";
            Welcome.IsSelected = true;

        }


        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }





        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Welcome.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Welcome));
                TitleTextBlock.Text = "Welcome";
            }
            else if (Client.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Client));
                TitleTextBlock.Text = "Clients";
            }
            else if (Houses.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Houses));
                TitleTextBlock.Text = "Houses";
            }

            else if (RosterOn.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Page1));
                TitleTextBlock.Text = "Your Roster";
            }
            else if (Forms.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Forms));
                TitleTextBlock.Text = "Keep Everything Documented";
            }

            else if (OutLook.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Outlook));
                TitleTextBlock.Text = "Your Mail";
            }
            else if (Courses.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Courses));
                TitleTextBlock.Text = "Do you want a career growth?";
            }
            else if (Careers.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Careers));
                TitleTextBlock.Text = "Looking for new job/position?";
            }
            else if (News.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(News));
                TitleTextBlock.Text = "Looking for new job/position?";
            }

        }



    }
}
