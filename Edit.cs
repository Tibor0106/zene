using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zenesszar
{
    public partial class Edit : Form
    {
        private int itemIndex;
       
        public Edit(int itemIndex)
        {
            InitializeComponent();
            this.itemIndex = itemIndex;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            label1.Text = this.itemIndex.ToString();

            var szam = Zene.szams[itemIndex];
            textBox1.Text = szam.cim;
            textBox2.Text = szam.eloado;
            textBox3.Text = szam.mufaj;
            textBox4.Text = szam.hossz_min;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            var szam = Zene.szams[itemIndex];
            Process.Start(new ProcessStartInfo(szam.path) { UseShellExecute = true });
        }
    }
}
