﻿using System;
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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _01_WPF_ZooManager
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["_01_WPF_ZooManager.Properties.Settings.JustinsDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
        }


        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    // Which Information of the Table in DataTable should br shown in our ListBox?
                    listZoos.DisplayMemberPath = "Location";
                    // Which Value should be delivered, when an Item from our ListBox is s
                    listZoos.SelectedValuePath = "Id";
                    // The Referance to the Data the ListBox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "select * from Animal a inner join ZooAnimal " + 
                    "za on a.Id = za.AnimalId where za.ZooId = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    // Which Information of the Table in DataTable should br shown in our ListBox?
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    // Which Value should be delivered, when an Item from our ListBox is s
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    // The Referance to the Data the ListBox should populate
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void ListZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("ListZoos was clicked");
            //MessageBox.Show(listZoos.SelectedValue.ToString());
            ShowAssociatedAnimals();
        }
    }
}