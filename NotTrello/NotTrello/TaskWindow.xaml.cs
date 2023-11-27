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
        object taskButton = null;

        public TaskWindow(object sender)
        {
            InitializeComponent();

            taskButton = sender;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // Save button event
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int taskID = (int)((Button)sender).Tag;
            string name = taskName.Text;
            string description = taskDescription.Text;
            string ticket = ticketNumber.Text;
            Color color = taskColor.SelectedColor;
            DateTime date = dateToggle.DisplayDate;
            object status = taskPanel.Tag;

            List<Task> tasks = XMLFileManagement.ReadTasks();
            
            Task task = null;
            int t = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskID == taskID)
                {
                    t = i;
                    task = tasks[i];
                    break;
                }
            }
            if (task == null)
            {
                task = new Task(taskID, name, description, ticket, color, date, status);
                tasks.Add(task);
            }
            else
            {
                tasks[t].Name = name;
                tasks[t].Description = description;
                tasks[t].TicketNumber = ticket;
                tasks[t].TaskColor = color;
                tasks[t].Date = date;
            }

            if (taskButton != null)
            {
                ((Button)taskButton).Background = new SolidColorBrush(color);
                ((Button)taskButton).Content = name;

            }

            XMLFileManagement.SaveTasks(tasks);
            
            

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
