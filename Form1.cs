using System.Windows.Forms;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using IWshRuntimeLibrary;
namespace kisayol2
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"C:\Users\hp\Desktop\notepad.ico"; // Seçmek istediðin ico dosyasýnýn yeri
        }

        private void buttonexe_Click(object sender, EventArgs e)
        {
            ofd.Filter =  "Exacutable File|*exe|All Files|*.*"; // kýsayolunu oluþturmak istediðin exe dosyasý
            if (ofd.ShowDialog() == DialogResult.OK)
                textBoxexefile.Text = ofd.FileName;
        }
        private void buttonkisayol_Click(object sender, EventArgs e)
        {
            if (ofd.FileName == "")
            {
                MessageBox.Show("dosya seçin", "Uyarý",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WshShell shell = new WshShell();
            string txtname = textBoxexefile.Text.Substring(textBoxexefile.Text.LastIndexOf("\\")).Split(".")[0];
            
            string masaustu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string shortcutAddress = masaustu+@"\"+ txtname + ".lnk";
            
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.IconLocation = ofd.InitialDirectory;
            shortcut.TargetPath = ofd.FileName;
            shortcut.Save();
            MessageBox.Show("Kýsayol baþarýyla oluþturulmuþtur", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }


    }
}