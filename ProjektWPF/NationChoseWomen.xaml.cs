using Newtonsoft.Json;
using ProjektWPF.Languages;
using QuickType;
using RestSharp;
using System;
using System.IO;
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
using System.Web.UI.WebControls.WebParts;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for NationChoseWomen.xaml
    /// </summary>
    public partial class NationChoseWomen : Window
    {
        List<Fixture> lista;

        public NationChoseWomen()
        {
            InitializeComponent();
            LoadData();
            Init();
            cbHomeTeam.SelectionChanged += new SelectionChangedEventHandler(OnMyComboBoxChanged);
        }

        private void Init()
        {
            btnNext.Content = MyResources.btnDalje;
            btnNationChosen.Content = MyResources.lbVise;
        }

        private async void LoadData()
        {
            var nations = await GetData();
            lista = nations;
            List<Team> teams = new List<Team>();
            for (int i = 0; i < 16; i++)
            {
                teams.Add(nations[i].HomeTeam);
                teams.Add(nations[i].AwayTeam);
            }
            foreach (var team in teams)
            {
                cbHomeTeam.Items.Add(team);
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

        private void OnMyComboBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            cbAwayTeam.Items.Clear();
            var nation = cbHomeTeam.SelectedValue as Team;
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].HomeTeam.Country == nation.Country)
                {
                    cbAwayTeam.Items.Add(lista[i].AwayTeam.Country);
                }
                else if (lista[i].AwayTeam.Country == nation.Country)
                {
                    cbAwayTeam.Items.Add(lista[i].HomeTeam.Country);
                }
            }
        }

        private void btnNationChosen_Click(object sender, RoutedEventArgs e)
        {
            var homeTeam = cbHomeTeam.SelectedValue as Team;
            if (homeTeam == null)
            {
                MessageBox.Show("Odaberite naciju");
                return;
            }
            var moreAboutNation = new MoreWomen(homeTeam);
            moreAboutNation.Show();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var homeTeam = cbHomeTeam.SelectedValue as Team;
            var prikazTerena = new PitchViewWomen(homeTeam, cbAwayTeam.SelectedItem.ToString());
            this.Visibility = Visibility.Hidden;
            prikazTerena.Show();
        }
    }
}
