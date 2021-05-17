﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFO
{
    public partial class Form1 : Form
    {
        public Form1(string roads)
        {
            InitializeComponent();
            road.Text = roads;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = road.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
