using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Wk8_9WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Fruit> someFruitObjList = new List<Fruit>
            {
                new Fruit(1, "Apple", "Red Delicious Apple"), //DATABASE PERSON
                new Fruit(2, "Orange", "Blood Oranges are sour"),
                new Fruit(3, "Banana", "A good source of Potasium")
            };


            
            dg_items.ItemsSource = someFruitObjList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
