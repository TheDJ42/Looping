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

namespace Looping
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

        private void calculateX_Click(object sender, RoutedEventArgs e)
        {
            long n = Convert.ToInt64(textBox_3.Text);
            long x = Convert.ToInt32(textBox.Text);
            long count = n;
            long answer = 1;

            while (count != 0)
            {
                answer = x * answer;
                count--;
            }
            
            answerBlock.Text = "Answer: " + answer.ToString();
            


        }

        private void calculate1_Click(object sender, RoutedEventArgs e)
        {
            long loanAmount = Convert.ToInt64(loanAmountText.Text);
            long monthlyPay = Convert.ToInt64(monthPay.Text);
            long count = 0;
            // Calculate Loan Length
            for (loanAmount = Convert.ToInt64(loanAmountText.Text); loanAmount > 0; loanAmount -= monthlyPay)
            {

              count++;
            }
            block3.Text ="The amount of time it will take to pay this debt is " + Convert.ToString(count) + " months";
        }

        private void startSeq_Click(object sender, RoutedEventArgs e)
        {
            long startVal = Convert.ToInt64(hailStartVal.Text);
            long n = startVal;
            string text = Convert.ToString(n);
            do
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                text = text + " " + Convert.ToString(n);
                textBox2.Text = text;
            }
            while (n != 1);
            
        }
    }
}
