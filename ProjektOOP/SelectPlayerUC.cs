using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOOP.Languages;
using QuickType;
using System.IO;
using RestSharp;
using Newtonsoft.Json;

namespace ProjektOOP
{
    public partial class SelectPlayerUC : UserControl
    {
        public SelectPlayerUC()
        {
            InitializeComponent();
            LoadData();
            init();
        }

        private void init()
        {
            lbFavorites.AllowDrop = true;
            lbAll.AllowDrop = true;
            btnNext.Text = MyResources.gumbSpremi;
        }

        private async void LoadData()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacija.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country = parts[0];
            var team = await GetData();
            List<StartingEleven> players = new List<StartingEleven>();
            for (int i = 0; i < 16; i++)
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
                lbAll.Items.Add(player);
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

        private void btnLeft_Click(object sender, EventArgs e)
        {
            var selected = lbAll.SelectedItem;
            if (selected == null)
            {
                return;
            }
            lbFavorites.Items.Add(selected);
            lbAll.Items.Remove(selected);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            var selected = lbFavorites.SelectedItem;
            if (selected == null)
            {
                return;
            }
            lbAll.Items.Add(selected);
            lbFavorites.Items.Remove(selected);
            
        }

        private void lbFavorites_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                lbFavorites.DoDragDrop(lbAll.SelectedItem.ToString(), DragDropEffects.Copy);

            }
            catch (Exception)
            {
                return;
            }
        }

        private void lbFavorites_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbFavorites_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            if (lbFavorites.Items.Count < 3 && !lbFavorites.Items.Contains(e.Data))
            {
                lbFavorites.Items.Add(e.Data.GetData(DataFormats.Text));
                lbAll.Items.Remove(e.Data.GetData(DataFormats.Text));
                lbAll.ClearSelected();
            }
            else
            {
                return;
            }
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            while (lbAll.SelectedItems.Count != 0)
            {
                lbFavorites.Items.Add(lbAll.SelectedItems[0]);
                lbAll.Items.Remove(lbAll.SelectedItems[0]);
                
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            while (lbFavorites.SelectedItems.Count != 0)
            {
                lbAll.Items.Add(lbFavorites.SelectedItems[0]);
                lbFavorites.Items.Remove(lbFavorites.SelectedItems[0]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Bruno/Desktop/ProjektOOP/OdabraniIgraci.txt";

            StreamWriter SaveFile = new StreamWriter(path);
            foreach (var item in lbFavorites.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.ToString();
            SaveFile.Close();
            this.Hide();
        }

        private void lbAll_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                lbFavorites.DoDragDrop(lbAll.SelectedItem.ToString(), DragDropEffects.Copy);

            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
