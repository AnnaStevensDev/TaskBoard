using Haley.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NotTrello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
            ReloadTasks();    
            
        }
        
        private void ReloadTasks()
        {
            List<Task> tasks = XMLFileManagement.ReadTasks();
            int taskID = 0;
            int status = 0;
            Color taskColor = (Color)ColorConverter.ConvertFromString("LimeGreen");
            string taskName = "New Task";
            for (int i = 0; i < tasks.Count; i++)
            {
                taskID = tasks[i].TaskID;
                taskName = tasks[i].Name;
                taskColor = tasks[i].TaskColor;
                status = (int)tasks[i].Status;
                if (status == 0)
                {
                    lane0.Children.Add(ReloadTask(taskID, taskName, taskColor));
                }
                else if (status == 1)
                {
                    lane1.Children.Add(ReloadTask(taskID, taskName, taskColor));
                }
                else if (status == 2)
                {
                    lane2.Children.Add(ReloadTask(taskID, taskName, taskColor));
                }
                else if (status == 3)
                {
                    lane3.Children.Add(ReloadTask(taskID, taskName, taskColor));
                }
                else if (status == 4)
                {
                    lane4.Children.Add(ReloadTask(taskID, taskName, taskColor));
                }
                else if (status == 5)
                {
                    lane5.Children.Add(ReloadTask(taskID, taskName, taskColor));
                }
            }


        }

        private Border ReloadTask(int taskID, string taskName, Color taskColor)
        {
            Style taskButtonStyle = (Style)FindResource("TaskButton") as Style;
            Style taskBorderStyle = (Style)FindResource("TaskBorder") as Style;
            Border taskBorder = new Border();
            Button taskButton = new Button();
            taskBorder.Style = taskBorderStyle;
            taskButton.Style = taskButtonStyle;
            taskButton.Background = new SolidColorBrush(taskColor);
            taskButton.Tag = taskID;
            taskButton.Content = taskName;
            taskBorder.Child = taskButton;
            return taskBorder;
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow(sender);
            taskWindow.Save.Tag = ((Button)sender).Tag;

            List<Task> tasks = XMLFileManagement.ReadTasks();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskID == (int)taskWindow.Save.Tag)
                {
                    taskWindow.taskName.Text = tasks[i].Name;
                    taskWindow.taskDescription.Text = tasks[i].Description;
                    taskWindow.ticketNumber.Text = tasks[i].TicketNumber;
                    taskWindow.taskColor.SelectedColor = tasks[i].TaskColor;
                    taskWindow.dateToggle.DisplayDate = tasks[i].Date;
                    
                    int status = (int)tasks[i].Status;
                    taskWindow.taskPanel.Tag = status;
                    string laneName = "";
                    if (status == 0)
                    {
                        laneName = laneName0.Text;
                    }
                    else if (status == 1)
                    {
                        laneName = laneName1.Text;
                    }
                    else if (status == 2)
                    {
                        laneName = laneName2.Text;
                    }
                    else if (status == 3)
                    {
                        laneName = laneName3.Text;
                    }
                    else if (status == 4)
                    {
                        laneName = laneName4.Text;
                    }
                    else if (status == 5)
                    {
                        laneName = laneName5.Text;
                    }
                    taskWindow.taskPanel.Content = laneName;
                    break;
                }
            }

            taskWindow.Show();
            taskWindow.Activate();
        }

        private Border AddNewTask(int status)
        {
            List<Task> tasks = XMLFileManagement.ReadTasks();
            int taskID = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskID > taskID)
                {
                    taskID = tasks[i].TaskID;
                }
            }
            taskID++;

            Style taskButtonStyle = (Style)FindResource("TaskButton") as Style;
            Style taskBorderStyle = (Style)FindResource("TaskBorder") as Style;
            Border taskBorder = new Border();
            Button taskButton = new Button();
            taskBorder.Style = taskBorderStyle;
            taskButton.Style = taskButtonStyle;
            taskButton.Tag = taskID;

            Task task = new Task(taskID, status);
            tasks.Add(task);
            XMLFileManagement.SaveTasks(tasks);
            
            taskBorder.Child = taskButton;
            return taskBorder;
        }
        private void AddTaskLane0(object sender, RoutedEventArgs e)
        {
            lane0.Children.Add(AddNewTask(0));
        }

        private void AddTaskLane1(object sender, RoutedEventArgs e)
        {
            lane1.Children.Add(AddNewTask(1));
        }

        private void AddTaskLane2(object sender, RoutedEventArgs e)
        {
            lane2.Children.Add(AddNewTask(2));
        }

        private void AddTaskLane3(object sender, RoutedEventArgs e)
        {
            lane3.Children.Add(AddNewTask(3));
        }

        private void AddTaskLane4(object sender, RoutedEventArgs e)
        {
            lane4.Children.Add(AddNewTask(4));
        }

        private void AddTaskLane5(object sender, RoutedEventArgs e)
        {
            lane5.Children.Add(AddNewTask(5));
        }

    }
    

}
