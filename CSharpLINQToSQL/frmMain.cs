using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSharpLINQ.View;

namespace CSharpLINQ
{
    public partial class frmMain : Form
    {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            navStudent.PerformClick();
        }

        private void navStudent_Click(object sender, EventArgs e) {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new ViewStudent());
            Navigate((Kimmy.Nav)sender);
        }

        private void navCourse_Click(object sender, EventArgs e) {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new ViewCourse());
            Navigate((Kimmy.Nav)sender);
        }

        void Navigate(Kimmy.Nav nav) {
            foreach (var n in navigation.Controls.OfType<Kimmy.Nav>()) {
                n.Active = false;
            }
            nav.Active = true;
        }
    }
}
