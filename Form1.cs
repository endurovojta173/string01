﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < textBox1.Lines.Length; i++)
            {
                string radek = textBox1.Lines[i].ToString();
                radek.Replace(radek[0], char.ToUpper(radek[0]));
                int j = 0;
                while(j<radek.Length)
                {
                    if (radek[j] == ' ' && radek[j + 1] == ' ')
                    {
                        radek.Remove(j, 1);
                    }
                    else j++;
                }
                if (radek[radek.Length-1]!='.')
                {
                    radek.Insert(radek.Length, ".");
                }
                textBox1.Lines[i] = radek;
            }
        }
    }
}
