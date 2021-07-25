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

namespace HW_CalSavingDay
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double income = double.Parse(txtIncome.Text);
            double expense = double.Parse(txtExpense.Text);
            double price = double.Parse(txtPrice.Text);
            double day = price / (income - expense);
            double d = Math.Round(day, 2);
            txtDay.Text = d.ToString();
        }
    }
}
