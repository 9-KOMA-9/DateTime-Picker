using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            datum.Format = DateTimePickerFormat.Short;
            vrijeme.Format = DateTimePickerFormat.Time;
            vrijeme.ShowUpDown = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rezervacija_Click(object sender, EventArgs e)
        {
            string rezervacijaPoruka = $"Vaša rezervacija je potvrđena za {datum.Value.ToShortDateString()} u {vrijeme.Value.ToShortTimeString()}. Hvala!";
            richTextBox1.Text = rezervacijaPoruka;
        }
    }
}
