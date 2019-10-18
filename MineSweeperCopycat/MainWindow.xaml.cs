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

namespace MineSweeperCopycat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int bombsNextTo = 0;

        public Random a = new Random();
        private List<int> randomList = new List<int>();
        int MyNumber = 0;
        private void NewNumber()
        {
            MyNumber = a.Next(1, 100);
            if (!randomList.Contains(MyNumber))
                randomList.Add(MyNumber);
        }

        private void FillList()
        {
            while (randomList.Count < 10)
            {
                NewNumber();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }

        private void CheckForMine(object sender, RoutedEventArgs e)
        {
            var tag = int.Parse(((Button)sender).Tag.ToString());
            if (randomList.Contains(tag))
            {
                // game over
            }
            else
            {
                // display number of mines touching that box
            }
        }
    }
}
