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
using ProjectDatamanipulatieAnime_Models;

namespace ProjectDatamanipulatieAnime_WPF
{
    /// <summary>
    /// Interaction logic for SerieOverview.xaml
    /// </summary>
    public partial class SerieOverview : Window
    {
        public SerieOverview(P_Seizoen seizoen)
        {
            InitializeComponent();

            ProjectlidVenster creator = new ProjectlidVenster("Vandeputte", "Stefan", "Beerse", "De seizoen overview pagina");
            txtCredit.Text = creator.ToString();

            datagridSeizoen.ItemsSource = DatabaseOperations.OphalenSeizoenviaID(seizoen.Seizoen_id);

            lblAdaptieEnVoorloper.Content = "Adaptatie: " + Environment.NewLine;
            List<P_Seizoen> Seizoen1 = DatabaseOperations.OphalenSeizoenviaID(seizoen.Seizoen_id);
            foreach (P_Seizoen AdaptatieManga in Seizoen1)
            {
                foreach (var AdaptatieTitel in AdaptatieManga.P_Adaptaties)
                {
                    lblAdaptieEnVoorloper.Content += AdaptatieTitel.P_Manga.Naam + Environment.NewLine;
                }
            }
            lblAdaptieEnVoorloper.Content += "Voorloper: " + Environment.NewLine;
            List<P_Seizoen> Seizoen2 = DatabaseOperations.OphalenSeizoenviaID(seizoen.Seizoen_id);
            foreach (P_Seizoen VoorloperSeizoen in Seizoen2)
            {
                foreach (var VoorloperTitel in VoorloperSeizoen.P_Seizoenen)
                {
                    lblAdaptieEnVoorloper.Content += VoorloperTitel.Naam + Environment.NewLine;
                }
            }

            datagridRelaties.ItemsSource = DatabaseOperations.OphalenSeizoenviaID(seizoen.Seizoen_id);
            datagridAfleveringen.ItemsSource = DatabaseOperations.OphalenAfleveringenviaSeizoenID(seizoen.Seizoen_id);
            datagridPersonages.ItemsSource = DatabaseOperations.OphalenPersonagesviaSeizoenID(seizoen.Seizoen_id);
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Window Home = new MainWindow();
            Home.Show();
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

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

        }

        private void btnPersonage_Click(object sender, RoutedEventArgs e)
        {

            if (datagridPersonages.SelectedItem is P_Personage personage)
            {
                Window SeizoenOverview = new PersonageWindow(personage);
                SeizoenOverview.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Je hebt incorrect een seizoen geselecteerd.");
            }
        }
    }
}
