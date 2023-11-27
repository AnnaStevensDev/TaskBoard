using static System.Net.Mime.MediaTypeNames;

namespace NotTrello {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    public sealed partial class NotTrelloSettings {
        
        public NotTrelloSettings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            //NotTrelloSettings.Default.LaneName0 = ((MainWindow)System.Windows.Application.Current.MainWindow).laneText0.Text;
            //NotTrelloSettings.Default.LaneName1 = ((MainWindow)System.Windows.Application.Current.MainWindow).laneText1.Text;
            //NotTrelloSettings.Default.LaneName2 = ((MainWindow)System.Windows.Application.Current.MainWindow).laneText2.Text;
            //NotTrelloSettings.Default.LaneName3 = ((MainWindow)System.Windows.Application.Current.MainWindow).laneText3.Text;
            //NotTrelloSettings.Default.LaneName4 = ((MainWindow)System.Windows.Application.Current.MainWindow).laneText4.Text;
            //NotTrelloSettings.Default.Lane6 = ((MainWindow)System.Windows.Application.Current.MainWindow).laneText5.Text;
            //NotTrelloSettings.Default.BoardName = ((MainWindow)System.Windows.Application.Current.MainWindow).boardText.Text;
        }
    }
}
