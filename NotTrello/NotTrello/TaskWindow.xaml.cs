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
            string name = taskName.Text;
            string description = taskDescription.Text;
            string ticket = ticketNumber.Text;
            Color color = taskColor.SelectedColor;
            DateTime date = dateToggle.DisplayDate;
            object status = taskPanel.Content;

            Debug.Print("Name: " + name);
            Debug.Print("Description: " + description);
            Debug.Print("Ticket Number: " + ticket);
            Debug.Print("Date: " + date);
            Debug.Print("Color: " + color);
            Debug.Print("Status: " + status);
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
