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
            
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow();
            taskWindow.Show();
            taskWindow.Activate();
        }

        private Border AddNewTask()
        {
            Style taskButtonStyle = (Style)FindResource("TaskButton") as Style;
            Style taskBorderStyle = (Style)FindResource("TaskBorder") as Style;
            Border taskBorder = new Border();
            Button taskButton = new Button();
            taskBorder.Style = taskBorderStyle;
            taskButton.Style = taskButtonStyle;
            taskBorder.Child = taskButton;
            return taskBorder;
        }
        private void AddTaskLane0(object sender, RoutedEventArgs e)
        {
            lane0.Children.Add(AddNewTask());
        }

        private void AddTaskLane1(object sender, RoutedEventArgs e)
        {
            lane1.Children.Add(AddNewTask());
        }

        private void AddTaskLane2(object sender, RoutedEventArgs e)
        {
            lane2.Children.Add(AddNewTask());
        }

        private void AddTaskLane3(object sender, RoutedEventArgs e)
        {
            lane3.Children.Add(AddNewTask());
        }

        private void AddTaskLane4(object sender, RoutedEventArgs e)
        {
            lane4.Children.Add(AddNewTask());
        }

        private void AddTaskLane5(object sender, RoutedEventArgs e)
        {
            lane5.Children.Add(AddNewTask());
        }
    }
    

}
