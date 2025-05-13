using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zenesszar
{
    public partial class MusicAdd : Form
    {
        private string path;
        public MusicAdd(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            List<System.Windows.Forms.TextBox> txs = new List<System.Windows.Forms.TextBox> { textBox1, textBox2, textBox3, textBox4 };


            bool err = false;
            foreach (var i in txs) if (i.Text.Length == 0) { errorProvider1.SetError(i, "Mező kitöltése kötelező!"); err = true; };
            if (err) return;

            string cim = textBox1.Text;
            string eloado = textBox2.Text;
            string mufaja = textBox3.Text;
            string hossz = textBox4.Text;

            Zene.szams.Add(new Zene.Szam(cim, eloado, mufaja, hossz, this.path));
            Zene.SaveUpdates();
            this.Dispose();
            MessageBox.Show("Zene sikeresen hozzáadva");
            Zene.ListBoxLoad();
            Zene.SaveUpdates();
           

        }

        private void MusicAdd_Load(object sender, EventArgs e)
        {
            pathLabel.Text = this.path;
        }
    }
}
