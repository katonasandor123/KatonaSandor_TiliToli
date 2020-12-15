using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int db = 0;
        public MainWindow()
        {
            InitializeComponent();

            Button1.IsEnabled = false;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button egyikGomb = sender as Button;
            Button xGomb = (Button)FindName("ButtonX");
            int vTav = Math.Abs((int)(egyikGomb.Margin.Left - xGomb.Margin.Left));
            int fTav = Math.Abs((int)(egyikGomb.Margin.Top - xGomb.Margin.Top));
            if ((vTav < 120 && fTav == 0) || (fTav < 120 && vTav == 0))
            {
                var seged = egyikGomb.Margin;
                egyikGomb.Margin = xGomb.Margin;
                xGomb.Margin = seged;
                db++;
                Lepesek.Content = "Lépések száma: " + db;
            }

            Button Button1 = (Button)FindName("Button1");
            Button Button2 = (Button)FindName("Button2");
            Button Button3 = (Button)FindName("Button3");
            Button Button4 = (Button)FindName("Button4");
            Button Button5 = (Button)FindName("Button5");
            Button Button6 = (Button)FindName("Button6");
            Button Button7 = (Button)FindName("Button7");
            Button Button8 = (Button)FindName("Button8");

            if ((int)(Button1.Margin.Left) == 15 && (int)(Button1.Margin.Top) == 70 && (int)(Button2.Margin.Left) == 130 && (int)(Button2.Margin.Top) == 70 && (int)(Button3.Margin.Left) == 245 && (int)(Button3.Margin.Top) == 70 && (int)(Button4.Margin.Left) == 15 && (int)(Button4.Margin.Top) == 185 && (int)(Button5.Margin.Left) == 130 && (int)(Button5.Margin.Top) == 185 && (int)(Button6.Margin.Left) == 245 && (int)(Button6.Margin.Top) == 185 && (int)(Button7.Margin.Left) == 15 && (int)(Button7.Margin.Top) == 300 && (int)(Button8.Margin.Left) == 130 && (int)(Button8.Margin.Top) == 300 && (int)(ButtonX.Margin.Left) == 245 && (int)(ButtonX.Margin.Top) == 300)
            {
                string message1 = "Gratuálok! Sikerült";
                string message2 = "kiraknod " + Convert.ToString(db) + " lépésből!!!";
                Uzenet.Content = message1;
                Uzenet2.Content = message2;
                db = 0;
            }
        }

        private void _new_Click(object sender, RoutedEventArgs e)
        {
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Uj.IsEnabled = true;
            Uzenet.Content = " ";
            byte random = 0;
            byte most = 0;
            byte lepes = 0;
            Lepesek.Content = "Lépések száma: ";
            Button xGomb = (Button)FindName("ButtonX");
            Random r = new Random();
            do
            {
                do
                {
                    random = Convert.ToByte(r.Next(1, 9));
                } while (most == random);
                most = random;
                string gomb = "Button" + random;
                Button szamGomb = (Button)FindName(gomb);
                int vTav = Math.Abs((int)(szamGomb.Margin.Left - xGomb.Margin.Left));
                int fTav = Math.Abs((int)(szamGomb.Margin.Top - xGomb.Margin.Top));
                if ((vTav < 175 && fTav == 0) || (fTav < 175 && vTav == 0))
                {
                    var seged = szamGomb.Margin;
                    szamGomb.Margin = xGomb.Margin;
                    xGomb.Margin = seged;
                    lepes++;
                }
            } while (lepes != 100);
        }
    }
}
