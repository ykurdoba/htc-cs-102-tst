using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InterfacesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<iWalker> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<iWalker>();

            // make siome aminals
            Frog frog = new Frog(4,"Bart",true, 4, 5.5);
            Dog dog = new Dog("Labradoodle", 35, "Pax", 4, 10.1);
            Duck duck = new Duck(4, "Moo", 2, 7.3);
            StarWarsRobot C3PO = new StarWarsRobot(1, 2, 3);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);

            lvAnimals.ItemsSource = Animals;
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (iWalker a in Animals)
            {
                a.walk();
            }
        }

		private void LvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			iWalker selectedAnimal = lvAnimals.SelectedItem as iWalker;
			if (selectedAnimal != null)
			{
				selectedAnimal.walk();
			}
		}
	}
}
