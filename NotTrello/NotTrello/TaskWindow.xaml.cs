using Haley.Services;
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
using System.Windows.Shapes;
using Haley.Utils;
using System.Diagnostics;

namespace NotTrello
{
    /// <summary>
    /// Interaction logic for TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public TaskWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // Value save button event
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Debug.Print("Name: " + taskName.Text);
            Debug.Print("Description: " + taskDescription.Text);
            Debug.Print("Ticket Number: " + ticketNumber.Text);
            Debug.Print("Date: " + dateToggle.Text);
            Debug.Print("Color: " + taskColor.SelectedColor);
            Debug.Print("Status: " + taskPanel.Content);
        }

        // Window close button event
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
