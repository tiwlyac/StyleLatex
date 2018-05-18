using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleLatex
{
    public partial class MainForm : Form
    {
        private DocStyleForm docForm { get; set; }
        private BibStyleForm bibForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.Icon = StyleLatex.Properties.Resources.icons_brush_131605494182433211;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void btnDocStyle_Click(object sender, EventArgs e)
        {
            btnDocStyle.FlatAppearance.BorderSize = 2;
            btnBibStyle.FlatAppearance.BorderSize = 0;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(docForm);
            docForm.Show();
        }

        private void btnBibStyle_Click(object sender, EventArgs e)
        {
            btnDocStyle.FlatAppearance.BorderSize = 0;
            btnBibStyle.FlatAppearance.BorderSize = 2;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(bibForm);
            bibForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SplashForm.ShowSplashScreen();
            docForm = new DocStyleForm();
            docForm.Dock = DockStyle.Fill;
            docForm.TopLevel = false;
            docForm.FormBorderStyle = FormBorderStyle.None;

            bibForm = new BibStyleForm();
            bibForm.Dock = DockStyle.Fill;
            bibForm.TopLevel = false;
            bibForm.FormBorderStyle = FormBorderStyle.None;

            btnDocStyle.PerformClick();
            SplashForm.CloseForm();
            //if (elfpcdj.checkInstalled("MiKTeX"))
            //{

            //    MessageBox.Show("it exists");
            //    // this is what you have tryied but failed.
            //    //The InstallPath of Installlocation is null, hence I use "InstallDate" instead.
            //}
            //else
            //{
            //    MessageBox.Show("it dont exist");
            //    return;
            //}


        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm dialog = new AboutForm();
            dialog.ShowDialog();
        }
    }

    //public class Register
    //{
    //    public bool checkInstalled(string c_name)
    //    {
    //        string displayName;

    //        string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
    //        RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
    //        if (key != null)
    //        {
    //            var regList = key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName));
    //            foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
    //            {
    //                displayName = subkey.GetValue("DisplayName") as string;
    //                if (displayName != null && displayName.Contains(c_name))
    //                {
    //                    return true;
    //                }
    //            }
    //            key.Close();
    //        }

    //        registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
    //        key = Registry.LocalMachine.OpenSubKey(registryKey);
    //        if (key != null)
    //        {
    //            foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
    //            {
    //                displayName = subkey.GetValue("DisplayName") as string;
    //                if (displayName != null && displayName.Contains(c_name))
    //                {
    //                    return true;
    //                }
    //            }
    //            key.Close();
    //        }
    //        return false;
    //    }
    //}
}
