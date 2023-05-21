using ProjektWPF.Models;
using QuickType;
using ProjektWPF.Languages;
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
using RestSharp;
using Newtonsoft.Json;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for More.xaml
    /// </summary>
    public partial class More : Window
    {
        public More(Team team)
        {
            InitializeComponent();
            LoadData(team);
        }

        private async void LoadData(Team team)
        {
            var nations = await GetData();
            Nations nation = new Nations();
            foreach (var country in nations)
            {
                if (country.Country == team.Country)
                {
                    nation = country;
                }
            }
            Init(nation);
        }

        private Task<List<Nations>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/teams/results");


                var result = restClient.Execute<Nations>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Nations>>(result.Content);

            });
        }

        private void Init(Nations nation)
        {
            lbName.Content = MyResources.lblName;
            countryName.Content = nation.Country;
            lbCode.Content = MyResources.lbKod;
            countryCode.Content = nation.FifaCode;
            lbPlayed.Content = MyResources.lbOdigrani;
            countryPlayed.Content = nation.GamesPlayed;
            lbWins.Content = MyResources.lbPobjede;
            countryWins.Content = nation.Wins;
            lbLoses.Content = MyResources.lbGubici;
            countryLoses.Content = nation.Losses;
            lbGoalsScored.Content = MyResources.lbZabijeni;
            countryGoalsScored.Content = nation.GoalsFor;
            lbGoalsConceded.Content = MyResources.lbPrimljeni;
            countryGoalsConceded.Content = nation.GoalsAgainst;
            lbGoalDifference.Content = MyResources.lbRazlika;
            countryGoalDifference.Content = nation.GoalDifferential;
        }
    }
}
