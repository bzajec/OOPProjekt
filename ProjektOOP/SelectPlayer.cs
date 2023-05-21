using ProjektOOP.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class SelectPlayer : Form
    {
        public SelectPlayer()
        {
            InitializeComponent();
            init();
            this.Hide();
        }

        private void init()
        {
            btnNext.Text = MyResources.btnDalje;
            var myControl = new ProjektOOP.SelectPlayerUC();
            panel1.Controls.Add(myControl);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            new Players().Show();
            this.Hide();
        }
    }
}
