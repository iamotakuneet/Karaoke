﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class ChangeRoom : UserControl
    {
        private static ChangeRoom _instance;

        public static ChangeRoom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChangeRoom();
                return _instance;
            }
        }

        public ChangeRoom() => InitializeComponent();

        private void ChangeRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
