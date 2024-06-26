﻿using Ball_Physics_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Peggle
 * Logan Gillett
 * Mr. T
 * 21.06.24
 * ICS4U
 */

namespace Peggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender
                f = current.FindForm();                     //find Form UserControl is on
                f.Controls.Remove(current);                 //remove current UserControl
            }

            // add the new UserControl to the middle of the screen and focus on it
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            Cursor.Position = next.PointToScreen(new Point(next.Width / 2, (next.Height / 2) + 100));
            next.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinScreen.winners = File.ReadAllLines("Winners.txt").ToList();
            ChangeScreen(this, new TitleScreen());
        }
    }
}
