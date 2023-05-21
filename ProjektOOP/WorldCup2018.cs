using Newtonsoft.Json;
using ProjektOOP.Languages;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class WorldCup2018 : Form
    {
        public WorldCup2018()
        {
            InitializeComponent();
        }

        private void WorldCup2018_Load(object sender, EventArgs e)
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
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/matches");


                var result = restClient.Execute<Fixture>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Fixture>>(result.Content);

            });
        }

        private void cbNations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacija.txt");
            string selectedValue = cbNations.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);
            this.Hide();
            new SelectPlayer().Show();
        }
    }
}
