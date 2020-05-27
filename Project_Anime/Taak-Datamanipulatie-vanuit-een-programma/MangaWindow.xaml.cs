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
using System.Data.Entity;

namespace ProjectDatamanipulatieAnime_WPF
{
    /// <summary>
    /// Interaction logic for MangaWindow.xaml
    /// </summary>
    public partial class MangaWindow : Window
    {
        public MangaWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Window Home = new MainWindow();
            Home.Show();
            this.Close();
        }

        private void BtnSeizoen_Click(object sender, RoutedEventArgs e)
        {
            Window Seizoen = new SerieWindow();
            Seizoen.Show();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbManga.ItemsSource = DatabaseOperations.OphalenMangaNamen();
        }

        private void cmbManga_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbManga.SelectedItem is P_Manga manga) 
            {
                lblGenre.Content = "Genres: " + Environment.NewLine;
                List<P_Manga> Manga = DatabaseOperations.OphalenMangaviaMangaID(manga.Manga_id);
                datagridManga.ItemsSource = Manga;
                foreach (P_Manga geselecteerdeManga in Manga)
                {
                    foreach (var mangaGenre in geselecteerdeManga.P_Genre_Lijsten_Manga)
                    {
                        lblGenre.Content += mangaGenre.P_Genre.Naam + Environment.NewLine;
                    }
                }
            }
            else
            {
                MessageBox.Show("Je hebt incorrect een titel geselecteerd.");
            }
        }
        private void btnAuteur_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
