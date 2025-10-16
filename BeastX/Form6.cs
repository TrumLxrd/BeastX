using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDarkAPI;

namespace _3rd_try
{
    public partial class BeastX : Form
    {
        ExploitAPI api = new ExploitAPI();
        public BeastX()
        {
            InitializeComponent();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void flatRadioButton1_CheckedChanged(object sender)
        {
            api.LaunchExploit();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {

        }

        private void flatButton4_Click_1(object sender, EventArgs e)
        {
            //wassup
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            api.DownloadLatestVersion();
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            api.KillRoblox();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            string luac = fastColoredTextBox1.Text;
            api.ExecuteScript(luac);
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }
    }
}
