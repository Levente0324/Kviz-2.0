﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Kviz
{
    /// <summary>
    /// Interaction logic for window2.xaml
    /// </summary>
    public partial class window2 : Window
    {
        List<Allat> allatok = new List<Allat>();


        public window2()
        {
            InitializeComponent();
            elemzes.Text = File.ReadAllText("allatok.txt");
        }

    }
}
