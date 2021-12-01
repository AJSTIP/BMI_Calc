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

namespace BMI_Calc
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

        private void Clear_BTN_Click(object sender, RoutedEventArgs e)
        {
            Phone_Box.Text = "";
            First_Name_Box.Text = "";
            Last_Name_Box.Text = "";
            Height_Inches_Box.Text = "";
            Weight_LBS_Box.Text = "";
        }

        private void Exit_BTN_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(500);
        }
    }
}
