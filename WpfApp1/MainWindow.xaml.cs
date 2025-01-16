using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Funzione che viene svolta al click del button Applay
        private void ApplayButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"La descrizione inserita è: {this.DescriptionInput.Text}");
        }

        private void Resetbutton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.RollCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.FoldCheckbox.IsChecked = this.LatheCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.LaserCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.NoteText.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropdown, null);
        }
    }
}