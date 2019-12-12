using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            textBox1.Visibility = Visibility.Collapsed;
            textBlock1.Visibility = Visibility.Collapsed;
            textBlock2.Visibility = Visibility.Collapsed;
            submitIntro.Visibility = Visibility.Collapsed;
            categoryChoices.Visibility = Visibility.Collapsed;

        }

        private void typeOfList_TextChanged(object sender, TextChangedEventArgs e)
        { }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Visible;
            submitIntro.Visibility = Visibility.Visible;
            categoryChoices.Visibility = Visibility.Visible;

            categoryChoices.Items.Add("name");
            categoryChoices.Items.Add("weight");
            categoryChoices.Items.Add("height");
            categoryChoices.Items.Add("age");
            categoryChoices.Items.Add("type");
            categoryChoices.Items.Add("rating");


        }

        private void submitIntro_Click(object sender, RoutedEventArgs e)
        {
            string listSelection = textBox1.Text;
            List<string> categories = new List<string>();
            categories.AddRange(categoryChoices.SelectedItems.Cast<string>().ToList<string>());
                

          
          
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
