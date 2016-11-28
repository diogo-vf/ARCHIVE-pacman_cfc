﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            lblRegles.Visible = false;
        }
        
        private void cmdRegles_MouseEnter(object sender, EventArgs e)
        {
            this.lblRegles.Visible = true;
        }

        private void cmdRegles_MouseLeave(object sender, EventArgs e)
        {
            this.lblRegles.Visible = false;
        }

        private void cmdNouvellePartie_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cmdNouvellePartie_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cmdScores_MouseEnter(object sender, EventArgs e)
        {

        }
        
        private void cmdScores_MouseLeave(object sender, EventArgs e)
        {

        }
        
    }
}