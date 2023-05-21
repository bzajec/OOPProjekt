using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string HR = "hr",
                            EN = "en";
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btnLanguage.Content = HR;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NationChose nationChose = new NationChose();
            this.Visibility = Visibility.Hidden;
            nationChose.Show();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            NationChoseWomen nationChoseWomen = new NationChoseWomen();
            this.Visibility = Visibility.Hidden;
            nationChoseWomen.Show();
        }

        

        private void btnLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                SetCulture(EN);
                btnLanguage.Content = "EN";
            }
            else
            {
                SetCulture(HR);
                btnLanguage.Content = "HR";
            }
            WriteLanguage();
        }

        private void SetCulture(string kultura)
        {
            try
            {
                
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void WriteLanguage()
        {
            System.IO.File.WriteAllText(@"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaKulturaWPF.txt", btnLanguage.Content.ToString().ToLower());
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var rb = sender as RadioButton;
            System.IO.File.WriteAllText(@"C:\Users\Bruno\Desktop\ProjektOOP\OdabranaRezolucijaWPF.txt", rb.Content.ToString());
        }


    }
}
