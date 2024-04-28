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
using System.Windows.Shapes;
using System.IO;

namespace Kviz
{
    /// <summary>
    /// Interaction logic for window3.xaml
    /// </summary>
    public partial class window3 : Window
    {
        public window3()
        {
            InitializeComponent();
        }

        private void button_Press(object sender,  RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("allatok.txt", true);
            sw.WriteLine(kerdesh.Text + ";" + v1h.Text + ";" + v2h.Text + ";" + v3h.Text + ";" + v4h.Text);
            sw.Close();
            kerdesh.Text = "";
            v1h.Text = "";
            v2h.Text = "";
            v3h.Text = "";
            v4h.Text = "";
        }
    }
}
