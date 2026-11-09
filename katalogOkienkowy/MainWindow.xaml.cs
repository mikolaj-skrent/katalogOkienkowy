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

namespace katalogOkienkowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // stworz liste kilku prodtuktow
            List<Produkt> produkty = new List<Produkt>
            {
                new Produkt("Okno 1", 200.0, "Okna", 10),
                new Produkt("Okno 2", 250.0, "Okna", 5),
                new Produkt("Drzwi 1", 500.0, "Drzwi", 3)
            };

            EtykietaLiczbaProduktow.Text = $" {produkty.Count}";

            // stworz liste wartosci magazynu
            List<double> wartosciMagazynu = produkty.Select(p => p.WartoscMagazynu).ToList();

            EtykietaMagazynu.Text = $"Wartość magazynu: {wartosciMagazynu.Sum():f2} zł";
        }
    }
}