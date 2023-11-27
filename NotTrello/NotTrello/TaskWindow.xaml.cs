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
        string[]laneNames = ((MainWindow) System.Windows.Application.Current.MainWindow).getLaneNames();

        public TaskWindow(object sender)
        {
            InitializeComponent();
            for (int i = 0; i < laneNames.Length; i++)
            {
                MoveComboBox.Items.Add(laneNames[i]);
            }

           

            taskButton = sender;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
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

        private void Move_Task(object sender, EventArgs e)
        {
            if(MoveComboBox.SelectedIndex == (int)taskPanel.Tag || MoveComboBox.SelectedIndex == -1)
            {
                return;
            }

            int taskID = (int)Save.Tag;
            List<Task> tasks = XMLFileManagement.ReadTasks();
            int t = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskID == taskID)
                {
                    t = i;
                    break;
                }
            }
            tasks[t].Status = MoveComboBox.SelectedIndex;
            taskPanel.Tag = MoveComboBox.SelectedIndex;
            taskPanel.Content = laneNames[MoveComboBox.SelectedIndex];
            XMLFileManagement.SaveTasks(tasks);
            ((MainWindow)System.Windows.Application.Current.MainWindow).ResetLanes();

        }

        private void Delete_Task(object sender, RoutedEventArgs e)
        {
            int taskID = (int)Save.Tag;
            List<Task> tasks = XMLFileManagement.ReadTasks();
            int t = -1;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskID == taskID)
                {
                    t = i;
                    break;
                }
            }
            if (t != -1)
            {
                tasks.RemoveAt(t);
            }
            XMLFileManagement.SaveTasks(tasks);
            ((MainWindow)System.Windows.Application.Current.MainWindow).ResetLanes();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

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
