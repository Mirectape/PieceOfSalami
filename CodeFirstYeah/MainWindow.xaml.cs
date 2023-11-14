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

namespace CodeFirstYeah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CatContext db = new CatContext();

            Cat cat1 = new Cat("Барсик", "Русская голубая кошка");
            Cat cat2 = new Cat("Мурзик", "Мейн-кун");

            var storageCats = new List<Cat>() { cat1, cat2 };

            foreach (var item in storageCats)
            {
                db.Cats.Add(item);
            }
            db.SaveChanges();

            var cats = db.Cats;
            foreach (var cat in cats)
            {
                MessageBox.Show(cat.Nickname, "info", MessageBoxButton.OK);
            }
        }
    }
}
