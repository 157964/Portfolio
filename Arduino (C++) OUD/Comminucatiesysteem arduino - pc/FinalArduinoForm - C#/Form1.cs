using COMreadLine;
using COMwriteLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalArduinoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ONbtCLICK(object sender, EventArgs e)
        {
            string COM = "aan";
            Writer.mail(COM);
        }

        private void OFFbtCLICK(object sender, EventArgs e)
        {
            string COM = "uit";
            Writer.mail(COM);
        }

        private void COMbtCLICK(object sender, EventArgs e)
        {
            string COM = textBox1.Text;
            label3.Text = Writer.mail(COM);
        }

        private void READbtCLICK(object sender, EventArgs e)
        {
            label3.Text = Reader.Bericht();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!LOOPREADcx.ThreeState)
                {
                    LOOPREADcx.ThreeState = true;
                    while (true)
                    {
                        label3.Text = Reader.Bericht();
                       
                    }
                }
                else
                {
                    LOOPREADcx.ThreeState = false;
                }
            }
            catch
            {
                label3.Text = "LoopError";
            }
        }
    }
}
