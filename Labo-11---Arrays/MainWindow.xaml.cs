using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_11___Arrays
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

        StringBuilder sb = new StringBuilder();

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = { 100, 50, 20, 60, 90, 80 };
            int[] biggestAndSmallest = ReturnSmallestAndBiggest(numbers);
            sb.AppendLine("-----------------------------");
            sb.AppendLine($"Er zijn in totaal {numbers.Length} getallen.");
            sb.AppendLine($"Het kleinste getal is: {biggestAndSmallest[0].ToString()}");
            sb.AppendLine($"Het grootste getal is: {biggestAndSmallest[1].ToString()}");
            OrderArray();
        }

        private int[] ReturnSmallestAndBiggest(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }

            int[] smallestAndBiggest = { min, max };
            return smallestAndBiggest;
        }

        private void OrderArray()
        {
            int[] orderNumbers = { 100, 50, 20, 60, 90, 80 };
            int numberSwitch;

            for (int i = 0; i < orderNumbers.Length; i++)
            {
                for (int a = (1 + i); a < orderNumbers.Length; a++)
                {
                    if (orderNumbers[i] > orderNumbers[a])
                    {
                        numberSwitch = orderNumbers[i];
                        orderNumbers[i] = orderNumbers[a];
                        orderNumbers[a] = numberSwitch;
                    }
                }
            }

            foreach (int value in orderNumbers)
            {
                sb.AppendLine(value.ToString());
            }

            outputTextBox.Text = sb.ToString();
        }


    }
}