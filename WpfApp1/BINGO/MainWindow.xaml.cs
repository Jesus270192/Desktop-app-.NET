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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BINGO {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<int> numbers;
        public MainWindow() {
            InitializeComponent();
            numbers = new List<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Random random;
            int number;
            int max;

            max = 110;

            while (true) {
                random = new Random();
                number = random.Next(1, max);

                if (numbers.Count(s => s == number) == 0) {
                    lblNumber.Content = number.ToString();
                    numbers.Add(number);
                    break;
                }

                if (numbers.Count== (max-1)) {
                    MessageBox.Show("El juego termino");
                }
            }
        }
    }
}
