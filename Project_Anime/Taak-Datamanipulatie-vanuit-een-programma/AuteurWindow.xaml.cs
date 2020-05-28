using ProjectDatamanipulatieAnime_DAL;
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

namespace ProjectDatamanipulatieAnime_WPF
{
    /// <summary>
    /// Interaction logic for AuteurWindow.xaml
    /// </summary>
    public partial class AuteurWindow : Window
    {
        public AuteurWindow(P_Manga auteurmanga)
        {
            InitializeComponent();

            datagridAuteur.ItemsSource = DatabaseOperations.OphalenMangaviaAuteurID(auteurmanga.P_Auteur.Auteur_id);

            lblAuteurInfo.Content = "Naam: " + Environment.NewLine + auteurmanga.P_Auteur.Voornaam + Environment.NewLine + auteurmanga.P_Auteur.Naam + Environment.NewLine + Environment.NewLine + "Geboortedatum: " + Environment.NewLine + auteurmanga.P_Auteur.Geboortedatum;
        }



        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

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

        private void datagridAuteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
