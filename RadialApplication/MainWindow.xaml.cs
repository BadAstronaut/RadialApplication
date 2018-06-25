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
using Autodesk.Revit;
using RadialMenu;
using System.Windows.Interop;

namespace RadialApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        public  MainWindow()
        {
            var point = GetMousePositionWindowsForms();
            this.Left = point.X-175;
            this.Top = point.Y-175;
            InitializeComponent();

        }


        private void RadialMenuCentralItem_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
        public void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show("Executing function");
            }
        }
        public static Point GetMousePositionWindowsForms()
        {
            var point = System.Windows.Forms.Control.MousePosition;
            return new Point(point.X, point.Y);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadFamily_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Dispose()
        {
            this.Close();
        }
    }
}
