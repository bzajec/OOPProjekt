using Newtonsoft.Json;
using ProjektWPF.Languages;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for PlayerViewWomen.xaml
    /// </summary>
    public partial class PlayerViewWomen : Window
    {
        public PlayerViewWomen(string s, Team home, string away)
        {
            InitializeComponent();
            Task task = LoadData(s, home, away);
            Init();
        }

        private void Init()
        {
            lbName.Content = MyResources.lblName;
            lbNumber.Content = MyResources.lblBroj;
            lbPosition.Content = MyResources.lblPosition;
            lbGoals.Content = MyResources.lbGolovi;
            lbYellows.Content = MyResources.lbZuti;
            lbCaptian.Content = MyResources.lblCaptain;
        }

        private async Task LoadData(string s, Team home, string away)
        {
            var fixtures = await GetData();
            StartingEleven chosenPlayer = new StartingEleven();
            Fixture match = new Fixture();

            foreach (var fixture in fixtures)
            {
                if (fixture.HomeTeam.Country == home.Country || fixture.AwayTeam.Country == home.Country)
                {
                    if (fixture.HomeTeam.Country == away.ToString() || fixture.AwayTeam.Country == away.ToString())
                    {
                        match = fixture;
                    }
                }

                foreach (var player in match.HomeTeamStatistics.StartingEleven)
                {
                    if (player.Name == s)
                    {
                        chosenPlayer = player;
                    }
                }

                foreach (var player in match.AwayTeamStatistics.StartingEleven)
                {
                    if (player.Name == s)
                    {
                        chosenPlayer = player;
                    }
                }
                int numberOfGoals = 0;
                int numberOfYellowCards = 0;

                foreach (var eventevent in match.HomeTeamEvents)
                {
                    if (eventevent.TypeOfEvent == TypeOfEvent.Goal || eventevent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        if (eventevent.Player == chosenPlayer.Name)
                        {
                            numberOfGoals++;
                        }
                    }
                    if (eventevent.TypeOfEvent == TypeOfEvent.YellowCard || eventevent.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        if (eventevent.Player == chosenPlayer.Name)
                        {
                            numberOfYellowCards++;
                        }
                    }
                }
                foreach (var eventEvent in match.AwayTeamEvents)
                {
                    if (eventEvent.TypeOfEvent == TypeOfEvent.Goal || eventEvent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        if (eventEvent.Player == chosenPlayer.Name)
                        {
                            numberOfGoals++;
                        }
                    }
                    if (eventEvent.TypeOfEvent == TypeOfEvent.YellowCard || eventEvent.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        if (eventEvent.Player == chosenPlayer.Name)
                        {
                            numberOfYellowCards++;
                        }
                    }
                }

                playerName.Content = chosenPlayer.Name;
                playerNumber.Content = chosenPlayer.ShirtNumber;
                playerPosition.Content = chosenPlayer.Position;
                playerCaptain.Content = chosenPlayer.Captain;
                playerGoal.Content = numberOfGoals;
                playerYellows.Content = numberOfYellowCards;

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
    }
}
