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

namespace doga
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{

			if (TextBox.Text == "" || ComboBox.Text == "")
			{
				MessageBox.Show("Nem adtál meg minden adatot");
				return;
			}
			string Mufaj = ComboBox.Text;
			string Cim = TextBox.Text;

			ListBox.Items.Add($"{Cim}, műfaja: {Mufaj}");

			TextBox.Text = string.Empty;

		}

		private void ListBox_MouseUp(object sender, MouseButtonEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Biztosan ki szeretnéd törölni?", "Könyv törlése" ,MessageBoxButton.YesNo);

			if (result == MessageBoxResult.Yes)
			{
				ListBox.Items.Remove(ListBox.SelectedItem);
			}

		}

		private void ShowButton_Click(object sender, RoutedEventArgs e)
		{
			string mindenKonyv = string.Join(Environment.NewLine, ListBox.Items.Cast<string>());
			MessageBox.Show(mindenKonyv, "Az összes könyv a listában:");
		}
	}
}