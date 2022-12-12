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

namespace janecek_20221212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Soldier soldier1;
        Soldier soldier2;

        public MainWindow()
        {
            InitializeComponent();

            soldier1 = new Soldier();
            soldier1.Jmeno = "Soldier 76";
            Zobraz(soldier1, txt1);

            soldier2 = new Soldier();
            soldier2.Jmeno = "Soldier 67";
            Zobraz(soldier2, txt2);
        }

       

        public void Zobraz(Soldier soldier, TextBox textBox)
        {
            textBox.Text = soldier.Jmeno + "\n";
            textBox.Text += "Život: " + soldier.Zivot.ToString() + "\n";
            textBox.Text += "MaxHP:" + soldier.MaxHP.ToString() + "/n"; 
            textBox.Text += "Dovednost: " + soldier.Dovednost.ToString() + "\n";
            textBox.Text += "Volné healy: " + soldier.Heals.ToString() + "\n";
            textBox.Text += "DMG: " + soldier.Dmg.ToString() + "\n";
        }
        public void dead(Soldier soldier, TextBox textbox)
        {
            textbox.Text = soldier.Jmeno + " je mrtev";
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            soldier1.ZvysitDovednost();
            Zobraz(soldier1, txt1);
            if (soldier1.Zivot <= 0)
            {
                dead(soldier1, txt1);
            }
            if (soldier2.Zivot <= 0)
            {
                dead(soldier2, txt2);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            soldier2.Attack();
            Zobraz(soldier2, txt2);
            Zobraz(soldier1, txt1);
            if (soldier1.Zivot <= 0)
            {
                dead(soldier1, txt1);
                Window win2 = new Window();
                win2.Show();
            }
            if (soldier2.Zivot <= 0)
            {
                dead(soldier2, txt2);
                Window win1 = new Window();
                win1.Show();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            soldier1.Attack();
            Zobraz(soldier1, txt1);
            Zobraz(soldier2, txt2);
            if (soldier2.Zivot <= 0)
            {
                dead(soldier2, txt2);
                Window win1 = new Window();
                win1.Show();
            }
            if (soldier1.Zivot <= 0)
            {
                dead(soldier1, txt1);
                Window win2 = new Window();
                win2.Show();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            soldier1.Heal();
            Zobraz(soldier1, txt1);


            if (soldier1.Zivot <= 0)
            {
                dead(soldier1, txt1);

            }
            if (soldier2.Zivot <= 0)
            {
                dead(soldier2, txt2);

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            soldier2.Heal();
            Zobraz(soldier2, txt2);
            if (soldier1.Zivot <= 0)
            {
                dead(soldier1, txt1);
            }
            if (soldier2.Zivot <= 0)
            {
                dead(soldier2, txt2);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window win2 = new Window();
            win2.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            soldier2.ZvysitDovednost();
            Zobraz(soldier2, txt2);
            if (soldier2.Zivot <= 0)
            {
                dead(soldier2, txt2);
            }
            if (soldier1.Zivot <= 0)
            {
                dead(soldier1, txt1);
            }
        }
    }
}
