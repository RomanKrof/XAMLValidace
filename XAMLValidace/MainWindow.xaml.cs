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

namespace XAMLValidace
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zamestnanec zam = new Zamestnanec(Name.Text, Surname.Text, Age.Text, Education.Text, Position.Text, Pay.Text);

            Info.Text = $@"Jméno: {zam.Jmeno}
Příjmení: {zam.Prijmeni}
Rok narození: {zam.Rok}
Vzdělání: {zam.Vzdelani}
Pozice: {zam.Pozice}
Plat: {zam.Plat}";
        }
    }

    public class Osoba
    {
        public Osoba (string jmeno, string prijmeni, string rok)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Rok = rok;
        }

        public string Jmeno
        {
            get;
            private set;
        }

        public string Prijmeni
        {
            get;
            private set;
        }

        public string Rok
        {
            get;
            private set;
        }
    }     

    public class Zamestnanec : Osoba
    {
        public Zamestnanec (string jmeno, string prijmeni, string rok, string vzdelani, string pozice, string plat) : base(jmeno, prijmeni, rok)
        {
            Vzdelani = vzdelani;
            Pozice = pozice;
            Plat = plat;
        }

        public string Vzdelani
        {
            get;
            set;
        }

        public string Pozice
        {
            get;
            set;
        }

        public string Plat
        {
            get;
            set;
        }
    }
}
