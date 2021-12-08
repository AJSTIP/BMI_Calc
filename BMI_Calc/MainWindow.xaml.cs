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
        public class Customer
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string phoneNumber { get; set; }
            public int heightInches { get; set; }
            public int weightLbs { get; set; }
            public int custBMI { get; set; }
            public string statusTitle { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        #region PartUno. Clear & Exit BTN
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
        #endregion

        #region PartDos. SubmitBTN
        public void Submit_BTN_Click(object sender, RoutedEventArgs e)
        {
            Customer customer1 = new Customer();

            customer1.lastName = Last_Name_Box.Text;
            customer1.firstName = First_Name_Box.Text;
            customer1.phoneNumber = Phone_Box.Text;

            int currentHeight = 0;
            int currentWeight = 0;
            Int32.TryParse(Height_Inches_Box.Text, out currentHeight);
            Int32.TryParse(Weight_LBS_Box.Text, out currentWeight);
            customer1.heightInches = currentHeight;
            customer1.weightLbs = currentWeight;

           int bmi;
           bmi = 703 * customer1.weightLbs / (customer1.heightInches * customer1.heightInches);
           customer1.custBMI = bmi;

            string yourBMIstatus = "NA";
            customer1.statusTitle = yourBMIstatus;

            Your_BMI_Results.Text = ($"{bmi}");

            if (bmi < 18.5)
            {
                BMI_Message.Text = "According to the CDC.gov BMI Calculator you are underweight.";
                customer1.statusTitle = "Underweight";
            }
            if (bmi < 24.9)
            {
                BMI_Message.Text = "According to the CDC.gov BMI Calculator you have a normal body weight";
                customer1.statusTitle = "Normal";
            }
            if (bmi < 29.9)
            {
                BMI_Message.Text = "According to the CDC.gov BMI Calculator you are overweight.";
                customer1.statusTitle = "Overweight";
            }
            else
            {
                BMI_Message.Text = "According to the CDC.gov BMI Calculator you are obese.";
                customer1.statusTitle = "Obese";
            }

            //MessageBox.Show($"Customers Name:{customer1.lastName}, {customer1.firstName} \n Cell #:{customer1.phoneNumber} \n Customer Height: {Height_Inches_Box} \n Customer Weight:{Weight_LBS_Box} \n Customer BMI: {bmi}");
        }
        #endregion
    }
}
