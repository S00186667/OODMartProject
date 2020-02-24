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

namespace CarlaMulliganProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<LivestockDetails> AllSheep = new List<LivestockDetails>();
        List<LivestockDetails> AllBeef = new List<LivestockDetails>();
        List<LivestockDetails> AllDairy = new List<LivestockDetails>();


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SheepLBX.ItemsSource = AllSheep;
            BeefLBX.ItemsSource = AllBeef;
            DairyLBX.ItemsSource = AllDairy; 

            //Sheep Details
            LivestockDetails Sheep1 = new LivestockDetails
            {
                Breed = "Suffolk",
                Gender = "F",
                DOB = new DateTime(2019, 2, 1)
            };

            LivestockDetails Sheep2 = new LivestockDetails
            {
                Breed = "Suffolk",
                Gender = "M",
                DOB = new DateTime(2019, 4, 1)
            };

            LivestockDetails Sheep3 = new LivestockDetails
            {
                Breed = "Galway",
                Gender = "M",
                DOB = new DateTime(2019, 5, 14)
            };

            LivestockDetails Sheep4 = new LivestockDetails
            {
                Breed = "Galway",
                Gender = "F",
                DOB = new DateTime(2019, 3, 3)
            };

            LivestockDetails Sheep5 = new LivestockDetails
            {
                Breed = "Ryeland",
                Gender = "M",
                DOB = new DateTime(2019, 5, 17)
            };

            LivestockDetails Sheep6 = new LivestockDetails
            {
                Breed = "Ryeland",
                Gender = "M",
                DOB = new DateTime(2019, 5, 16)
            };

            //Beef Details
            LivestockDetails Beef1 = new LivestockDetails
            {
                Breed = "Dexter",
                Gender = "F",
                DOB = new DateTime(2019, 2, 1)
            };

            LivestockDetails Beef2 = new LivestockDetails
            {
                Breed = "Dexter",
                Gender = "M",
                DOB = new DateTime(2019, 4, 1)
            };

            LivestockDetails Beef3 = new LivestockDetails
            {
                Breed = "Angus",
                Gender = "M",
                DOB = new DateTime(2019, 5, 14)
            };

            LivestockDetails Beef4 = new LivestockDetails
            {
                Breed = "Angus",
                Gender = "F",
                DOB = new DateTime(2019, 3, 3)
            };

            LivestockDetails Beef5 = new LivestockDetails
            {
                Breed = "Limousin",
                Gender = "M",
                DOB = new DateTime(2019, 5, 17)
            };

            LivestockDetails Beef6 = new LivestockDetails
            {
                Breed = "Limousin",
                Gender = "M",
                DOB = new DateTime(2019, 5, 16)
            };


            //Dairy Details
            LivestockDetails Dairy1 = new LivestockDetails
            {
                Breed = "Friesian",
                Gender = "F",
                DOB = new DateTime(2019, 2, 1)
            };

            LivestockDetails Dairy2 = new LivestockDetails
            {
                Breed = "Friesian",
                Gender = "M",
                DOB = new DateTime(2019, 4, 1)
            };

            LivestockDetails Dairy3 = new LivestockDetails
            {
                Breed = "Jersey",
                Gender = "M",
                DOB = new DateTime(2019, 5, 14)
            };

            LivestockDetails Dairy4 = new LivestockDetails
            {
                Breed = "Jersey",
                Gender = "F",
                DOB = new DateTime(2019, 3, 3)
            };

            LivestockDetails Dairy5 = new LivestockDetails
            {
                Breed = "Simmnetal",
                Gender = "M",
                DOB = new DateTime(2019, 5, 17)
            };

            LivestockDetails Dairy6 = new LivestockDetails
            {
                Breed = "Simmnetal",
                Gender = "M",
                DOB = new DateTime(2019, 5, 16)
            };


            AllSheep.Add(Sheep1);
            AllSheep.Add(Sheep2);
            AllSheep.Add(Sheep3);
            AllSheep.Add(Sheep4);
            AllSheep.Add(Sheep5);
            AllSheep.Add(Sheep6);

            AllBeef.Add(Beef1);
            AllBeef.Add(Beef2);
            AllBeef.Add(Beef3);
            AllBeef.Add(Beef4);
            AllBeef.Add(Beef5);
            AllBeef.Add(Beef6);

            AllDairy.Add(Dairy1);
            AllDairy.Add(Dairy2);
            AllDairy.Add(Dairy3);
            AllDairy.Add(Dairy4);
            AllDairy.Add(Dairy5);
            AllDairy.Add(Dairy6);


        }
       
        

        
    }
}
