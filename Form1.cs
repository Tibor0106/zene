using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace zenesszar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Zene.ReadTxt();
            Zene.ls = listBox1;
            Zene.ListBoxLoad();
        }


        private void HandleAddMusic_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "(*.mp3|*.mp3|All files (*.*)|*.*";
            openFileDialog1.Title = "Válassz!";
            openFileDialog1.ShowDialog();
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path = openFileDialog1.FileName;

            new MusicAdd(path).ShowDialog();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0) return;
           
            new Edit(listBox1.SelectedIndex-1).ShowDialog();
        }
    }
}
