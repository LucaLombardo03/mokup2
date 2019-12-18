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

namespace mokup2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sldNum1.Minimum = 0;
            sldNum2.Minimum = 0;
            sldNum1.Maximum = 100;
            sldNum2.Maximum = 100;
        }
        int somma;
        int sottrazione;
        int prodotto;
        int divisione;

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            sldNum1.IsEnabled = true;
            sldNum2.IsEnabled = true;
        }
        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            sldNum1.IsEnabled = false;
            sldNum2.IsEnabled = false;
        }
        private void sldNum1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                int n1 = (int)sldNum1.Value;
                txtNum1.Text = n1.ToString();
                int n2 = (int)sldNum2.Value;
                txtNum2.Text = n2.ToString();
                somma = n1 + n2;
                txtSomma.Text = somma.ToString();
                sottrazione = n1 - n2;
                txtSottrazione.Text = sottrazione.ToString();
                prodotto = n1 * n2;
                txtMoltiplicazione.Text = prodotto.ToString();
                divisione = n1 / n2;
                txtDivisione.Text = divisione.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sldNum2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                int n1 = (int)sldNum1.Value;
                txtNum1.Text = n1.ToString();
                int n2 = (int)sldNum2.Value;
                txtNum2.Text = n2.ToString();
                somma = n1 + n2;
                txtSomma.Text = somma.ToString();
                sottrazione = n1 - n2;
                txtSottrazione.Text = sottrazione.ToString();
                prodotto = n1 * n2;
                txtMoltiplicazione.Text = prodotto.ToString();
                divisione = n1 / n2;
                txtDivisione.Text = divisione.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
