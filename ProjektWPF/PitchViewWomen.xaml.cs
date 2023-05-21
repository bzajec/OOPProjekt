using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PitchViewWomen.xaml
    /// </summary>
    public partial class PitchViewWomen : Window
    {
        int resHeight;
        int resWidth;
        Team home;
        string away;
        public PitchViewWomen(Team homeTeam, string awayTeam)
        {
            InitializeComponent();
            this.Loaded += PitchView_Loaded;
            LoadData(homeTeam, awayTeam);
            home = homeTeam;
            away = awayTeam;
        }

        private void PitchView_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaRezolucijaWPF.txt"))
                {

                    String line = sr.ReadToEnd();
                    string[] parts = line.Split(':');
                    resWidth = int.Parse(parts[0]);
                    resHeight = int.Parse(parts[1]);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            this.Width = resWidth;
            this.Height = resHeight;
            if (resHeight == 0 || resWidth == 0)
            {
                this.Width = 800;
                this.Height = 600;
            }
        }

        private async void LoadData(Team homeTeam, string awayTeam)
        {
            var fixtures = await GetData();
            Fixture match = new Fixture();
            foreach (var fixture in fixtures)
            {
                if (fixture.HomeTeam.Country == homeTeam.Country || fixture.AwayTeam.Country == homeTeam.Country)
                {
                    if (fixture.HomeTeam.Country == awayTeam.ToString() || fixture.AwayTeam.Country == awayTeam.ToString())
                    {
                        match = fixture;
                    }
                }
            }

            for (int i = 0; i < 11; i++)
            {
                if (match.HomeTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    Button gk = new Button();
                    gk.Content = match.HomeTeamStatistics.StartingEleven[i].Name;
                    gk.Height = 45;
                    gk.Background = Brushes.White;
                    gk.Click += btnPlayer_Click;
                    grid.Children.Add(gk);
                }
                else if (match.HomeTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    Button def = new Button();
                    def.Content = match.HomeTeamStatistics.StartingEleven[i].Name;
                    def.SetValue(Grid.ColumnProperty, 1);
                    def.Height = 45;
                    def.Background = Brushes.White;
                    def.Click += btnPlayer_Click;
                    stackDefHome.Children.Add(def);
                }
                else if (match.HomeTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    Button mid = new Button();
                    mid.Content = match.HomeTeamStatistics.StartingEleven[i].Name;
                    mid.SetValue(Grid.ColumnProperty, 2);
                    mid.Height = 45;
                    mid.Background = Brushes.White;
                    mid.Click += btnPlayer_Click;
                    stackMidHome.Children.Add(mid);
                }
                else if (match.HomeTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    Button fow = new Button();
                    fow.Content = match.HomeTeamStatistics.StartingEleven[i].Name;
                    fow.SetValue(Grid.ColumnProperty, 3);
                    fow.Height = 45;
                    fow.Background = Brushes.White;
                    fow.Click += btnPlayer_Click;
                    stackFowHome.Children.Add(fow);
                }

            }

            for (int i = 0; i < 11; i++)
            {
                if (match.AwayTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    Button gk = new Button();
                    gk.Content = match.AwayTeamStatistics.StartingEleven[i].Name;
                    gk.Height = 45;
                    gk.Background = Brushes.White;
                    gk.SetValue(Grid.ColumnProperty, 7);
                    gk.Click += btnPlayer_Click;
                    grid.Children.Add(gk);
                }
                else if (match.AwayTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    Button def = new Button();
                    def.Content = match.AwayTeamStatistics.StartingEleven[i].Name;
                    def.SetValue(Grid.ColumnProperty, 6);
                    def.Height = 45;
                    def.Background = Brushes.White;
                    def.Click += btnPlayer_Click;
                    stackDefAway.Children.Add(def);
                }
                else if (match.AwayTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    Button mid = new Button();
                    mid.Content = match.AwayTeamStatistics.StartingEleven[i].Name;
                    mid.SetValue(Grid.ColumnProperty, 5);
                    mid.Height = 45;
                    mid.Background = Brushes.White;
                    mid.Click += btnPlayer_Click;
                    stackMidAway.Children.Add(mid);
                }
                else if (match.AwayTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    Button fow = new Button();
                    fow.Content = match.AwayTeamStatistics.StartingEleven[i].Name;
                    fow.SetValue(Grid.ColumnProperty, 4);
                    fow.Height = 45;
                    fow.Background = Brushes.White;
                    fow.Click += btnPlayer_Click;
                    stackFowAway.Children.Add(fow);
                }

            }
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            string s = (sender as Button).Content.ToString();
            PlayerViewWomen view = new PlayerViewWomen(s, home, away);
            view.Show();
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
