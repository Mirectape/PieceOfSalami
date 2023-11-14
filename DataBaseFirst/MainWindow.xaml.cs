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

namespace DataBaseFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //List<int> nums = new List<int>() { 1, 5, 11, 34 };
            //var numRes = nums.Where(w => w > 11);

            //foreach (var item in numRes)
            //{
            //    MessageBox.Show($"{item}", "info", MessageBoxButton.OK);
            //}

            InitializeComponent();

            TESTEntities context = new TESTEntities();

            var res = context.PersonSet.Where(w => w.id > 0);
            MessageBox.Show($"{res}", "info", MessageBoxButton.OK);

            foreach (var item in res)
            {
                //Console.WriteLine(item.Name);
                //MessageBox.Show(item.Name, "info", MessageBoxButton.OK);
            }

        }
    }
}

