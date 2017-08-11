using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorHub
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(Login.Instance))
            {
                this.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }
            else
                Login.Instance.BringToFront();
        }
    }
}
