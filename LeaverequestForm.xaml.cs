using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class LeaverequestForm : Page
    {
        Employee emp;
        string st, et, lt;
        public LeaverequestForm()
        {
            this.InitializeComponent();
        }


        Dictionary<string, Employee> elementDictionary = new Dictionary<string, Employee>();



        Frame rootFrame = Window.Current.Content as Frame;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(Page1));

        }
        private void StartDate_DateChanged(CalendarDatePicker sender,
                                              CalendarDatePickerDateChangedEventArgs args)
        {
            if (StartDate.Date != null)
            {

                st = StartDate.Date.Value.Day.ToString() + "-" +
                     StartDate.Date.Value.Month.ToString() + "-" +
                     StartDate.Date.Value.Year.ToString();
            }
            else
            {
                st = "Invalid Date";
            }
        }
        private void EndDate_DateChanged(CalendarDatePicker sender,
                                              CalendarDatePickerDateChangedEventArgs args)
        {
            if (StartDate.Date != null)
            {

                et = EndDate.Date.Value.Day.ToString() + "-" +
                     EndDate.Date.Value.Month.ToString() + "-" +
                     EndDate.Date.Value.Year.ToString();
            }
            else
            {
                et = "Invalid Date";
            }
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ExtendedComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LeaveType == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            lt = item.Content.ToString();

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            emp = new Employee();


            emp.Name = Emp_Name.Text;
            emp.EmployeeId = Emp_Id.Text;
            emp.StartDate = st;
            emp.EndDate = et;
            emp.LeaveType = lt;
            emp.Reason = Reason.Text;


            if (emp != null)
            {

                Frame.Navigate(typeof(Balance_Leave), emp);
            }
            else
            { Frame.Navigate(typeof(ErrorPage)); }


        }







    }
}
