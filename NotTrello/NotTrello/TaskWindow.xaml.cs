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
        object taskButton = null; // Object for task button in main window
        string[]laneNames = ((MainWindow) System.Windows.Application.Current.MainWindow).getLaneNames(); // Names of lanes in main window

        public TaskWindow(object sender)
        {
            InitializeComponent();
            for (int i = 0; i < laneNames.Length; i++)
            {
                MoveComboBox.Items.Add(laneNames[i]); // Initialize lane names
            }

            taskButton = sender; // Initialize task button
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        // Save button event
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Get values from task window
            int taskID = (int)((Button)sender).Tag;
            string name = taskName.Text;
            string description = taskDescription.Text;
            string ticket = ticketNumber.Text;
            Color color = taskColor.SelectedColor;
            DateTime date = dateToggle.DisplayDate;
            object status = taskPanel.Tag;

            // Read existing tasks
            List<Task> tasks = XMLFileManagement.ReadTasks();
            
            Task task = null;
            int t = 0;
            for (int i = 0; i < tasks.Count; i++) // Find current task
            {
                if (tasks[i].TaskID == taskID)
                {
                    t = i;
                    task = tasks[i];
                    break;
                }
            }
            if (task == null) // If task does not exist, make one
            {
                task = new Task(taskID, name, description, ticket, color, date, status);
                tasks.Add(task);
            }
            else // Update values of task
            {
                tasks[t].Name = name;
                tasks[t].Description = description;
                tasks[t].TicketNumber = ticket;
                tasks[t].TaskColor = color;
                tasks[t].Date = date;
            }

            if (taskButton != null) // Update task button values
            {
                ((Button)taskButton).Background = new SolidColorBrush(color);
                ((Button)taskButton).Content = name;

            }

            XMLFileManagement.SaveTasks(tasks); // Save the tasks to file
            
            

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

        // Move task button event
        private void Move_Task(object sender, EventArgs e)
        {
            // If no lane or current lane is selected from dropdown, return
            if(MoveComboBox.SelectedIndex == (int)taskPanel.Tag || MoveComboBox.SelectedIndex == -1)
            {
                return;
            }

            // Read the tasks
            int taskID = (int)Save.Tag;
            List<Task> tasks = XMLFileManagement.ReadTasks();
            int t = 0;
            for (int i = 0; i < tasks.Count; i++) // Find the current task
            {
                if (tasks[i].TaskID == taskID) 
                {
                    t = i;
                    break;
                }
            }

            // Update the task status
            tasks[t].Status = MoveComboBox.SelectedIndex;
            taskPanel.Tag = MoveComboBox.SelectedIndex;
            taskPanel.Content = laneNames[MoveComboBox.SelectedIndex];

            // Save the tasks
            XMLFileManagement.SaveTasks(tasks);

            // Reload the main window task buttons
            ((MainWindow)System.Windows.Application.Current.MainWindow).ResetLanes();

        }

        // Delete task button event
        private void Delete_Task(object sender, RoutedEventArgs e)
        {
            // Read the tasks
            int taskID = (int)Save.Tag;
            List<Task> tasks = XMLFileManagement.ReadTasks();
            int t = -1;
            for (int i = 0; i < tasks.Count; i++) // Find the current task
            {
                if (tasks[i].TaskID == taskID)
                {
                    t = i;
                    break;
                }
            }
            if (t != -1)
            {
                tasks.RemoveAt(t); // Remove the task
            }

            // Save the tasks
            XMLFileManagement.SaveTasks(tasks);

            // Reload the main window task buttons
            ((MainWindow)System.Windows.Application.Current.MainWindow).ResetLanes();

            // Close the window
            this.Close();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // Add activity button event
        private void Add_Activity(object sender, RoutedEventArgs e)
        {

            Style activityCheckBoxStyle = (Style)FindResource("ActivityCheckBox") as Style;
            Style activityTextBoxStyle = (Style)FindResource("ActivityTextBox") as Style;
            CheckBox activity = new CheckBox();
            TextBox activityContent = new TextBox();
            activity.Style = activityCheckBoxStyle;
            activityContent.Style = activityTextBoxStyle;
            activity.Content= activityContent;
            activities.Items.Add(activity);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
