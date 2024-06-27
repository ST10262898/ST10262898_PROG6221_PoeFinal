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

namespace ST10262898_PROG6221_PoeFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Recipe> recipeList; // Assuming you have a Recipe class and a list of recipes

        public MainWindow()
        {
            InitializeComponent();
            recipeList = new List<Recipe>(); // Initialize your recipe list or load it from somewhere
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            AddDetailsWindow details = new AddDetailsWindow(recipeList);
            details.ShowDialog();
        }
    }
}
