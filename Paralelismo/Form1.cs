using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paralelismo
{
    public partial class Form1 : Form
    {
        Random velocidadRamdon = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => comenzarCarrera(textBox1, 70, velocidadRamdon.Next(1, 30)));
            Task.Run(() => comenzarCarrera(textBox2, 110, velocidadRamdon.Next(1, 30)));
            Task.Run(() => comenzarCarrera(textBox3, 150, velocidadRamdon.Next(1, 30)));
            Task.Run(() => comenzarCarrera(textBox4, 190, velocidadRamdon.Next(1, 30)));
           
        }

        private void comenzarCarrera(TextBox textBox1, int posY, int velocidad)
        {

            for(int i= 0; i<=500; i++)
            {
                textBox1.Location = new Point(i, posY);
                Thread.Sleep(velocidad);
            }

        }
    }
}
