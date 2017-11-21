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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double result = 0;
        private bool div = false;
        private bool mul = false;
        private bool sub = false;
        private bool add = false;
        private bool per = false;
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn1.Content;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn2.Content;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn3.Content;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn4.Content;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn5.Content;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn6.Content;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn7.Content;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn8.Content;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn9.Content;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Text = "";
            tbxResult.Text += btn0.Content;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!tbxResult.Text.Contains('.'))
                tbxResult.Text += btnDot.Content;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxResult.Text = "0";
            result = 0;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            String str = "";
            for(int i = 0; i < (tbxResult.Text).Length - 1; i++)
            {
                str += tbxResult.Text[i];
            }
            if (str.Equals(""))
                str = "0";
            tbxResult.Text = str;
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            div = true;
            mul = false;
            sub = false;
            add = false;
            per = false;
            result += Double.Parse(tbxResult.Text);
            tbxResult.Text = "0";
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            div = false;
            mul = true;
            sub = false;
            add = false;
            per = false;
            result += Double.Parse(tbxResult.Text);
            tbxResult.Text = "0";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            div = false;
            mul = false;
            sub = true;
            add = false;
            per = false;
            result += Double.Parse(tbxResult.Text);
            tbxResult.Text = "0";            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            div = false;
            mul = false;
            sub = false;
            add = true;
            per = false;
            result += Double.Parse(tbxResult.Text);
            tbxResult.Text = "0";
            
        }

        private void btnRec_Click(object sender, RoutedEventArgs e)
        {
            tbxResult.Text = (1 / Double.Parse(tbxResult.Text)).ToString();
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            tbxResult.Text = (Math.Sqrt(Double.Parse(tbxResult.Text))).ToString();
        }

        private void btnNeg_Click(object sender, RoutedEventArgs e)
        {
            tbxResult.Text = (-1*Double.Parse(tbxResult.Text)).ToString();
        }

        private void btnPer_Click(object sender, RoutedEventArgs e)
        {
            div = false;
            mul = false;
            sub = false;
            add = false;
            per = true;
            result += Double.Parse(tbxResult.Text);
            tbxResult.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (div)
                result /= Double.Parse(tbxResult.Text);
            else if (mul)
                result *= Double.Parse(tbxResult.Text);
            else if (sub)
                result -= Double.Parse(tbxResult.Text);
            else if (add)
                result += Double.Parse(tbxResult.Text);
            else if (per)
                result = result * Double.Parse(tbxResult.Text) / 100;
            tbxResult.Text = "";
            tbxResult.Text = result.ToString();
        }

    }
}
