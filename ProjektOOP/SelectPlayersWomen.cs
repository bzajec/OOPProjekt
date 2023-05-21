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
    public partial class SelectPlayersWomen : Form
    {
        public SelectPlayersWomen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btnNext.Text = MyResources.btnDalje;
            var myControl = new ProjektOOP.SelectPlayersUCWomen();
            panel1.Controls.Add(myControl);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            new PlayersWomen().Show();
            this.Hide();
        }
    }
}
