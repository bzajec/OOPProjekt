using Newtonsoft.Json;
using ProjektOOP.Languages;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class PlayersWomen : Form
    {
        List<StartingEleven> players = new List<StartingEleven>();
        public PlayersWomen()
        {
            InitializeComponent();
            init();
            LoadData();
        }

        private void init()
        {
            lblName.Text = MyResources.lblName;
            lblSurname.Text = MyResources.lblSurname;
            lblPosition.Text = MyResources.lblPosition;
            lblCaptain.Text = MyResources.lblCaptain;
            lblNumber.Text = MyResources.lblBroj;
            btnAddPic.Text = MyResources.btnSave;
            btnDalje.Text = MyResources.btnDalje;
        }

        private async void LoadData()
        {

            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacijaWomen.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country;
            if (parts.Count() == 3)
            {
                country = parts[0] + " " + parts[1];
            }
            else
            {
                country = parts[0];
            }
            var team = await GetData();
            for (int i = 0; i < 12; i++)
            {
                if (team[i].AwayTeamCountry == country)
                {
                    for (int j = 0; j < team[i].AwayTeamStatistics.StartingEleven.Count; j++)
                    {
                        players.Add(team[i].AwayTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < team[i].AwayTeamStatistics.Substitutes.Count; j++)
                    {
                        players.Add(team[i].AwayTeamStatistics.Substitutes[j]);
                    }
                }
                else if (team[i].HomeTeamCountry == country)
                {
                    for (int j = 0; j < team[i].HomeTeamStatistics.StartingEleven.Count; j++)
                    {
                        players.Add(team[i].HomeTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < team[i].HomeTeamStatistics.Substitutes.Count; j++)
                    {
                        players.Add(team[i].HomeTeamStatistics.Substitutes[j]);
                    }
                }

            }
            foreach (var player in players)
            {
                lbPlayers.Items.Add(player);
            }

        }

        private Task<List<Fixture>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://pastebin.com/raw/c7PeRM8p");


                var result = restClient.Execute<Fixture>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Fixture>>(result.Content);

            });
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lines = lbPlayers.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 5)
            {
                tbName.Text = parts[0];
                tbSurname.Text = parts[1];
                tbNumber.Text = parts[2];
                tbPosition.Text = parts[3];
                tbCaptain.Text = parts[4];
            }
            else if (parts.Length == 6)
            {
                tbName.Text = parts[0];
                tbSurname.Text = parts[1] + " " + parts[2];
                tbNumber.Text = parts[3];
                tbPosition.Text = parts[4];
                tbCaptain.Text = parts[5];
            }
            else
            {
                tbName.Text = parts[0];
                tbSurname.Text = "";
                tbNumber.Text = parts[1];
                tbPosition.Text = parts[2];
                tbCaptain.Text = parts[3];
            }
            string[] linije = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabraniIgraci.txt"));
            if (linije.Contains(lbPlayers.SelectedItem.ToString()))
            {
            }

        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbPicUrl.Text = open.FileName;
                    pbPlayer.Image = new Bitmap(open.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Došlo je do pogreške");
                }
            }
            try
            {
                File.Copy(tbPicUrl.Text, Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\Slike\", lbPlayers.SelectedItem.ToString()), true);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RangListWomen(players).Show();
        }
    }
}
