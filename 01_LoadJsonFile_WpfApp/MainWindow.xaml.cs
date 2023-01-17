using _01_LoadJsonFile_WpfApp.Models;
using _01_LoadJsonFile_WpfApp.Services;
using Newtonsoft.Json;
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

namespace _01_LoadJsonFile_WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ContactService contactService = new ContactService();

        public MainWindow()
        {
            InitializeComponent();
            lv_ContactList.ItemsSource = contactService.PopulateContactList();
        }

        private void btn_AddContact_Click(object sender, RoutedEventArgs e)
        {
            contactService.AddToList(new Contact { FirstName = "DEMO", LastName = "DEMO" });
        }
    }
}
