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
        List<LivestockDetails> AllLiveStock = new List<LivestockDetails>();
        List<LivestockDetails> fliteredlivestock;
      //  List<LivestockDetails> FliteredList; 
       
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SheepLBX.ItemsSource = AllLiveStock; 

            fliteredlivestock = new List<LivestockDetails>();
            //FliteredList = new List<LivestockDetails>(); 

            //Sheep Details
            LivestockDetails Sheep1 = new LivestockDetails
            {
                Breed = "Suffolk",
                Gender = "F",
                DOB = new DateTime(2019, 2, 1),
                Description = "Breeding Ewe", 
                Cost = 110m 
           
                
            };

            LivestockDetails Sheep2 = new LivestockDetails
            {
                Breed = "Suffolk",
                Gender = "M",
                DOB = new DateTime(2019, 4, 1), 
                Description = "Breeding Ram", 
                Cost = 100m 
                
            };

            LivestockDetails Sheep3 = new LivestockDetails
            {
                Breed = "Galway",
                Gender = "M",
                DOB = new DateTime(2019, 5, 14),
                Description = "Cull Ram",
                Cost = 70m

            };

            LivestockDetails Sheep4 = new LivestockDetails
            {
                Breed = "Galway",
                Gender = "F",
                DOB = new DateTime(2019, 3, 3), 
                Description = "Ewe", 
                Cost = 140m 
            };

            LivestockDetails Sheep5 = new LivestockDetails
            {
                Breed = "Ryeland",
                Gender = "F",
                DOB = new DateTime(2019, 5, 17), 
                Description = "Ewe", 
                Cost = 91m
            };

            LivestockDetails Sheep6 = new LivestockDetails
            {
                Breed = "Ryeland",
                Gender = "M",
                DOB = new DateTime(2019, 5, 16),
                Description = "Hogget",
                Cost = 100m 
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



            AllLiveStock.Add(Sheep1);
            AllLiveStock.Add(Sheep2);
            AllLiveStock.Add(Sheep3);
            AllLiveStock.Add(Sheep4);
            AllLiveStock.Add(Sheep5);
            AllLiveStock.Add(Sheep6);
            AllLiveStock.Add(Beef1);
            AllLiveStock.Add(Beef2);
            AllLiveStock.Add(Beef3);
            AllLiveStock.Add(Beef4);
            AllLiveStock.Add(Beef5);
            AllLiveStock.Add(Beef6);
            AllLiveStock.Add(Dairy1);
            AllLiveStock.Add(Dairy2);
            AllLiveStock.Add(Dairy3);
            AllLiveStock.Add(Dairy4);
            AllLiveStock.Add(Dairy5);
            AllLiveStock.Add(Dairy6);

           // List<string> fliteredsheep = AllLiveStock.Where(LivestockDetails == "Sheep"); 

          /*  foreach(var s in AllLiveStock)
                if(s.Breed == "Suffolk" || s.Breed == "Galway" || s.Breed == "Ryeland")
                {
                    SheepLBX.ItemsSource = s.Breed; 
                }*/

        }

        private void SheepLBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LivestockDetails selectedlivestock = SheepLBX.SelectedItem as LivestockDetails;
            if (selectedlivestock != null)
                sheepdescription.Text = selectedlivestock.Description; 
                
                
           

        }


        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void All_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton selectedRB = sender as RadioButton;
            string fliterBy = selectedRB.Content as string;

            FliterType(fliterBy);
        }

        private void FliterType(string fliterby)
        {
            fliteredlivestock.Clear(); 

            switch(fliterby)
            {
                case "Suffolk":
                    foreach(LivestockDetails livestock in AllLiveStock)
                    {
                        if (livestock.Breed == "Suffolk")
                            fliteredlivestock.Add(livestock); 
                    }

                    SheepLBX.ItemsSource = null;
                    SheepLBX.ItemsSource = fliteredlivestock;

                    break;

                case "Galway":
                    foreach (LivestockDetails livestock in AllLiveStock)
                    {
                        if (livestock.Breed == "Galway")
                            fliteredlivestock.Add(livestock);
                    }

                    SheepLBX.ItemsSource = null;
                    SheepLBX.ItemsSource = fliteredlivestock;
                    break;

                case "Ryeland":
                    foreach (LivestockDetails livestock in AllLiveStock)
                    {
                        if (livestock.Breed == "Ryeland")
                            fliteredlivestock.Add(livestock);
                    }

                    SheepLBX.ItemsSource = null;
                    SheepLBX.ItemsSource = fliteredlivestock;
                    break;

                default:
                    SheepLBX.ItemsSource = AllLiveStock;
                    break; 

            }


        }

        private void Flitersheep_Click(object sender, RoutedEventArgs e)
        {

            if (SheepLBX != null)
            {
                if (rbsuffolk.IsChecked == true) FliterType("Suffolk");
                if (rbgalway.IsChecked == true) FliterType("Galway");
                if (rbryeland.IsChecked == true) FliterType("Ryeland");
            }
        }

        private void Combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
