using ProjektOOP.Languages;
using QuickType;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjektOOP
{
    public partial class WorldCup2019Women : Form
    {
        public WorldCup2019Women()
        {
            InitializeComponent();
        }

        private void WorldCup2019Women_Load(object sender, EventArgs e)
        {
            lblChooseFavouriteNation.Text = MyResources.izabertiNajdražuNaciju;
            LoadData();
        }

        private async void LoadData()
        {
            var nations = await GetData();
            List<Team> teams = new List<Team>();
            for (int i = 0; i < 16; i++)
            {
                teams.Add(nations[i].HomeTeam);
                teams.Add(nations[i].AwayTeam);
            }
            foreach (var team in teams)
            {
                cbNations.Items.Add(team);
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

        private void cbNations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacijaWomen.txt");
            string selectedValue = cbNations.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);
            this.Hide();
            new SelectPlayersWomen().Show();
        }
    }
}
