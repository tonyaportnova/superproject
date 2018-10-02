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

namespace svet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double sum, diff, led, incandescent;
            if (double.TryParse(sumTextBox.Text, out sum) && double.TryParse(diffTextBox.Text, out diff))
            {
                led = (sum - diff) / 2;
                incandescent = led + diff;
                status.Text = String.Format("Стоимость LED: {0}; энергосберегающей лампы: {1}", led, incandescent);
                return;
            }

            status.Text = "ты втираешь мне какую-то дичь";
        }
    }
}
