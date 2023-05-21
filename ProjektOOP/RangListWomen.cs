using QuickType;
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
using ProjektOOP.Models;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace ProjektOOP
{
    public partial class RangListWomen : Form
    {
        Dictionary<StartingEleven, int> playerGol = new Dictionary<StartingEleven, int>();
        Dictionary<StartingEleven, int> playerYellow = new Dictionary<StartingEleven, int>();

        public RangListWomen(List<StartingEleven> lista)
        {
            InitializeComponent();
            List<StartingEleven> players = lista;
            LoadData(players);
            Init();
        }

        private void Init()
        {
            lblName.Text = MyResources.lblName;
            lblSurname.Text = MyResources.lblSurname;
            lblPosition.Text = MyResources.lblPosition;
            lblCaptain.Text = MyResources.lblCaptain;
            lblNumber.Text = MyResources.lblBroj;
            lblGoals.Text = MyResources.lbGolovi;

            lbName.Text = MyResources.lblName;
            lbSurname.Text = MyResources.lblSurname;
            lbNumber.Text = MyResources.lblBroj;
            lbPosition.Text = MyResources.lblPosition;
            lbCaptain.Text = MyResources.lblCaptain;
            lblNumber.Text = MyResources.lblBroj;
            lbZuti.Text = MyResources.lbZuti;

            lbVenue.Text = MyResources.lbVenue;
            lblAttendance.Text = MyResources.lbAttendance;
            lbHomeTeam.Text = MyResources.lbHomeTeam;
            lbAwayTeam.Text = MyResources.lbAwayTeam;
        }

        private async void LoadData(List<StartingEleven> players)
        {

            var team = await GetData();
            int golovi = 0;
            int zuti = 0;

            foreach (var player in players)
            {
                for (int i = 0; i < team.Count(); i++)
                {
                    for (int j = 0; j < team[i].HomeTeamEvents.Count(); j++)
                    {
                        if (team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.Goal || team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            if (team[i].HomeTeamEvents[j].Player == player.Name)
                            {
                                golovi++;
                            }
                        }
                    }
                    for (int j = 0; j < team[i].AwayTeamEvents.Count(); j++)
                    {
                        if (team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.Goal || team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            if (team[i].AwayTeamEvents[j].Player == player.Name)
                            {
                                golovi++;
                            }
                        }
                    }
                }
                playerGol.Add(player, golovi);
                golovi = 0;
            }
            GetDictionaryGoals();


            foreach (var player in players)
            {
                for (int i = 0; i < team.Count(); i++)
                {
                    for (int j = 0; j < team[i].HomeTeamEvents.Count(); j++)
                    {
                        if (team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCard || team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            if (team[i].HomeTeamEvents[j].Player == player.Name)
                            {
                                zuti++;
                            }
                        }
                    }
                    for (int j = 0; j < team[i].AwayTeamEvents.Count(); j++)
                    {
                        if (team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCard || team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            if (team[i].AwayTeamEvents[j].Player == player.Name)
                            {
                                zuti++;
                            }
                        }
                    }
                }
                playerYellow.Add(player, zuti);
                zuti = 0;
            }
            GetDictionaryYellow();


            List<Attendance> attendances = new List<Attendance>();
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaNacijaWomen.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country = parts[0];
            foreach (var match in team)
            {
                if (match.HomeTeamCountry == country || match.AwayTeamCountry == country)
                {
                    Attendance p = new Attendance
                    {
                        attendance = match.Attendance.Value,
                        venue = match.Venue,
                        home_team_country = match.HomeTeamCountry,
                        away_team_country = match.AwayTeamCountry
                    };
                    attendances.Add(p);
                }
            }
            attendances.Sort();
            foreach (var match in attendances)
            {
                lbAttendance.Items.Add(match);
            }

        }

        private void GetDictionaryYellow()
        {
            var sortedDict = from entry in playerYellow orderby entry.Value descending select entry;
            foreach (var player in sortedDict)
            {
                lbYellowCards.Items.Add(player);
            }
        }

        private void GetDictionaryGoals()
        {
            var sortedDict = from entry in playerGol orderby entry.Value descending select entry;
            foreach (var player in sortedDict)
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
            if (parts.Length == 6)
            {
                tbName.Text = parts[0].TrimStart('[');
                tbSurname.Text = parts[1];
                tbNumber.Text = parts[2];
                tbPosition.Text = parts[3];
                tbCaptain.Text = parts[4].TrimEnd(',');
                tbGoals.Text = parts[5].TrimEnd(']');

            }
            else if (parts.Length == 7)
            {
                tbName.Text = parts[0].TrimStart('[');
                tbSurname.Text = parts[1] + " " + parts[2];
                tbNumber.Text = parts[3];
                tbPosition.Text = parts[4];
                tbCaptain.Text = parts[5].TrimEnd(',');
                tbGoals.Text = parts[6].TrimEnd(']');
            }
            else
            {
                tbName.Text = parts[0].TrimStart('[');
                tbSurname.Text = "";
                tbNumber.Text = parts[1];
                tbPosition.Text = parts[2];
                tbCaptain.Text = parts[3].TrimEnd(',');
                tbGoals.Text = parts[4].TrimEnd(']');
            }

            if (parts.Length == 6)
            {
                string filename = parts[0].TrimStart('[') + " " + parts[1] + " " + parts[2] + " " + parts[3] + " " + parts[4].TrimEnd(',');
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\Slike\", filename)))
                {
                    pbPlayer.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\Slike\", filename));
                }
                else
                {
                    pbPlayer.Image = ProjektOOP.Properties.Resources.Webp_net_resizeimage;
                }
            }
            else if (parts.Length == 7)
            {
                string filename = parts[0].TrimStart('[') + " " + parts[1] + " " + parts[2] + " " + parts[3] + " " + parts[4] + " " + parts[5].TrimEnd(',');
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\Slike\", filename)))
                {
                    pbPlayer.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\Slike\", filename));
                }
                else
                {
                    pbPlayer.Image = ProjektOOP.Properties.Resources.Webp_net_resizeimage;
                }
            }
            else
            {
                string filename = parts[0].TrimStart('[') + " " + parts[1] + " " + parts[2] + " " + parts[3].TrimEnd(',');
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOP\Slike\", filename)))
                {
                    pbPlayer.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"C:\Users\Bruno\Desktop\ProjektOOPSlike\", filename));
                }
                else
                {
                    pbPlayer.Image = ProjektOOP.Properties.Resources.Webp_net_resizeimage;
                }
            }
        }

        private void lbYellowCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lines = lbYellowCards.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 6)
            {
                textBoxName.Text = parts[0].TrimStart('[');
                textBoxSurame.Text = parts[1];
                textBoxNumber.Text = parts[2];
                textBoxPosition.Text = parts[3];
                textBoxCaptain.Text = parts[4].TrimEnd(',');
                textBoxYellow.Text = parts[5].TrimEnd(']');
            }
            else if (parts.Length == 7)
            {
                textBoxName.Text = parts[0].TrimStart('[');
                textBoxSurame.Text = parts[1] + " " + parts[2];
                textBoxNumber.Text = parts[3];
                textBoxPosition.Text = parts[4];
                textBoxCaptain.Text = parts[5].TrimEnd(',');
                textBoxYellow.Text = parts[6].TrimEnd(']');

            }
            else
            {
                textBoxName.Text = parts[0].TrimStart('[');
                textBoxSurame.Text = "";
                textBoxNumber.Text = parts[1];
                textBoxPosition.Text = parts[2];
                textBoxCaptain.Text = parts[3].TrimEnd(',');
                textBoxYellow.Text = parts[4].TrimEnd(']');
            }
        
        }

        private void lbAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            Attendance p = lbAttendance.SelectedItem as Attendance;
            tbVenue.Text = p.venue;
            tbAttendance.Text = p.attendance.ToString();
            tbHome.Text = p.home_team_country;
            tbAway.Text = p.away_team_country;
        }
    }
}
