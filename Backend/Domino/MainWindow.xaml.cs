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
using System.IO;

namespace DominoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Class1
    {
        public int szam1;
        public int szam2;

        public Class1(string sor)
        {
            string[] darabok = sor.Split(' ');
            this.szam1 = Convert.ToInt32(darabok[0]);
            this.szam2 = Convert.ToInt32(darabok[1]);
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainwindow1.Height = 368;

        }

        private void betolt_click(object sender, RoutedEventArgs e)
        {
            List<Class1> list = new List<Class1>();
            var sorok = File.ReadAllLines("domino.txt");
            foreach (var sor in sorok)
            {
                list.Add(new Class1(sor));
            }
            foreach (var item in list)
            {
                wpfLista.Items.Add($"{item.szam1} {item.szam2}");
            }
        }

        private void illesztes_Click(object sender, RoutedEventArgs e)
        {
            List<Class1> list = new List<Class1>();
            var sorok = File.ReadAllLines("domino.txt");
            foreach (var sor in sorok)
            {
                list.Add(new Class1(sor));
            }


            foreach (var item in list)
            {
                do
                {
                    MessageBox.Show("Nincsenek beolvasva a dominók");
                } while (!File.Exists("domino.txt"));
            }

            if (File.Exists("domino.txt"))
            {
                MessageBox.Show("Már van domino.txt");
            }
            else
            {
                MessageBox.Show("Megtörtént a mentés");
            }
          
        }

  
    }
}
