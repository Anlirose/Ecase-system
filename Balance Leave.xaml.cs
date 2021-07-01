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
    public sealed partial class Balance_Leave : Page
    {



        public Balance_Leave()
        {
            this.InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)

        {

            Employee emp = (Employee)e.Parameter;
            Dictionary<string, Employee> DataDictionary = new Dictionary<string, Employee>();
            try
            {
                if (emp != null)
                {
                    DataDictionary.Add(emp.Name, emp);
                    DataDictionary.Add(emp.EmployeeId, emp);
                    DataDictionary.Add(emp.StartDate, emp);
                    DataDictionary.Add(emp.EndDate, emp);
                    DataDictionary.Add(emp.LeaveType, emp);
                    DataDictionary.Add(emp.Reason, emp);
                }
                else { Frame.Navigate(typeof(ErrorPage)); }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                Frame.Navigate(typeof(ErrorPage));
                
                
            }

            foreach (KeyValuePair<string, Employee> ed in DataDictionary)

                try
                {
                    if (ed.Value != null)
                    {
                        EName.Text = ed.Value.Name;
                        E_Id.Text = ed.Value.EmployeeId;
                        StartDate.Text = ed.Value.StartDate;
                        EndDate.Text = ed.Value.StartDate;
                        Leavetype.Text = ed.Value.LeaveType.ToString();
                        Reason.Text = ed.Value.Reason;
                        
                    }
                    else 
                    {
                        Frame.Navigate(typeof(ErrorPage));
                    }
                }
                catch (Exception ex2)
                {
                    Debug.WriteLine("Error: " + ex2);
                    Frame.Navigate(typeof(ErrorPage));

                }







        }

        private void EmpName_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void E_Id_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Startdate_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void EndDate_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Reason_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
