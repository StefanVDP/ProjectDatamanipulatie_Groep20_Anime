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
using System.Data.SqlClient;
using ProjectDatamanipulatieAnime_DAL;

namespace ProjectDatamanipulatieAnime_WPF
{
    /// <summary>
    /// Interaction logic for PersonageWindow.xaml
    /// </summary>
    public partial class PersonageWindow : Window
    {
        public PersonageWindow(P_Personage personage)
        {
            InitializeComponent();

            txtPersonageInfo.Text = "Naam: " + personage.Naam + Environment.NewLine + "Geslacht: " + personage.P_Geslacht.Naam;
            txtPersonageBeschrijving.Text = "Beschrijving: " + personage.Omschrijving;
            datagridStemacteurInfo.ItemsSource = DatabaseOperations.OphalenStemacteurviaPersonageID(personage.Stemacteur_id);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

        }

        private void BtnSeizoen_Click(object sender, RoutedEventArgs e)
        {
            Window Seizoen = new SerieWindow();
            Seizoen.Show();
            this.Close();
        }

        private void BtnManga_Click(object sender, RoutedEventArgs e)
        {
            Window Manga = new MangaWindow();
            Manga.Show();
            this.Close();
        }

        private void BtnIndustrie_Click(object sender, RoutedEventArgs e)
        {
            //Window Industrie = new IndustrieWindow();
            // Industrie.Show();
            //this.Close();
        }

        private void BtnGenre_Click(object sender, RoutedEventArgs e)
        {
            //Window Genre = new GenreWindow();
            //Genre.Show();
            //this.Close();
        }

        private void BtnManage_Click(object sender, RoutedEventArgs e)
        {
            //Window Manage = new ManageWindow();
            //Manage.Show();
            //this.Close();
        }
        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Window Home = new MainWindow();
            Home.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnStemacteur_Click(object sender, RoutedEventArgs e)
        {
            if (datagridStemacteurInfo.SelectedItem is P_Stemacteur stemacteur)
            {
                Window StemacteurWindow = new StemacteurWindow(stemacteur);
                StemacteurWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Je hebt incorrect een seizoen geselecteerd.");
            }
        }
    }
}
