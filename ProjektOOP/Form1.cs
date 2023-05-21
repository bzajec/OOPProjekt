using System.Globalization;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class Form1 : Form
    {
        private const string HR = "hr",
                            EN = "en";

        public Form1()
        {
            
            InitializeComponent();
            init();
        }

        private void init()
        {
            if (System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaKultura.txt")) == EN)
            {
                SetCulture(EN);
            }
            else
            {
                SetCulture(HR);
            }
        }

        private void SetCulture(string culture)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);

                foreach (Control control in Controls)
                {
                    var resursi = new ComponentResourceManager(typeof(Form1));
                    resursi.ApplyResources(control, control.Name, new CultureInfo(culture));
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void pbMen_Click(object sender, EventArgs e)
        {
            if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacija.txt")).Length == 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabraniIgraci.txt")).Length == 0)
            {
                new WorldCup2018().Show();

            }
            else if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacija.txt")).Length != 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabraniIgraci.txt")).Length == 0)
            {
                new SelectPlayer().Show();
            }
            else
            {
                new Players().Show();
            }

            this.Hide();
        }

        private void pbWomen_Click(object sender, EventArgs e)
        {
            if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacijaWomen.txt")).Length == 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabraniIgraciWomen.txt")).Length == 0)
            {
                new WorldCup2019Women().Show();

            }
            else if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacijaWomen.txt")).Length != 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabraniIgraciWomen.txt")).Length == 0)
            {
                new SelectPlayersWomen().Show();
            }
            else
            {
                new PlayersWomen().Show();
            }

            this.Hide();
        }

        private void bntLanguage_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                SetCulture(EN);
                bntLanguage.Text = "EN";
            }
            else
            {
                SetCulture(HR);
                bntLanguage.Text = "HR";
            }
            WriteCulture();
        }

        private void WriteCulture()
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaKultura.txt"), bntLanguage.Text.ToLower());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCulture(HR);
        }
    }
}
