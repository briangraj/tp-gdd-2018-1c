﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class AbmHabitacion : Form
    {
        public AbmHabitacion()
        {
            InitializeComponent();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            DatosHabitacion datos = new DatosHabitacion();
            datos.Show();
        }
    }
}
