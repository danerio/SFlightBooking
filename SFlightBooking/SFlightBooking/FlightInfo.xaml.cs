﻿using System;
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

namespace SFlightBooking {
    /// <summary>
    /// Interaction logic for FlightInfo.xaml
    /// </summary>
    public partial class FlightInfo : Window {

        private Flight flightInfo;

        public FlightInfo() {
            InitializeComponent();
        }

        public FlightInfo(Flight f)
        {
            flightInfo = f;


        }

    }
}
