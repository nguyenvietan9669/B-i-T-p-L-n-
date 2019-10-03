using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace An
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    private void btnCong_Click(object sender, EventArgs e)
{
 if (txtA.Text != String.Empty && txtB.Text != String.Empty)
 {
 double a = double.Parse(txtA.Text);
 double b = double.Parse(txtB.Text);
 double c = a + b;
 txtKetQua.Text = c.ToString();
 }
}
}
