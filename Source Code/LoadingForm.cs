using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleLatex
{
    public partial class LoadingForm : Form
    {

        public LoadingForm()
        {
            InitializeComponent();
        }
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static LoadingForm loadForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.
            if (loadForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(LoadingForm.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            loadForm = new LoadingForm();
            loadForm.ShowInTaskbar = false;
            Cursor.Hide();
            Application.Run(loadForm);
        }

        static public void CloseForm()
        {
            loadForm.Invoke(new CloseDelegate(LoadingForm.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            Cursor.Show();
            loadForm.Close();
            loadForm = null;
           
        }
    }
}

