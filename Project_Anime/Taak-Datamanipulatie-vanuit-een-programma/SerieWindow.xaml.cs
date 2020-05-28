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
    /// Interaction logic for SerieWindow.xaml
    /// </summary>
    public partial class SerieWindow : Window
    {
        public SerieWindow()
        {
            InitializeComponent();
            ProjectlidVenster creator = new ProjectlidVenster("Vandeputte", "Stefan", "Beerse", "De seizoen selectie pagina");
            txtCredit.Text = creator.ToString();
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

        private void DataGrid_Initialized(object sender, EventArgs e)
        {
            datagridSeizoenen.ItemsSource = DatabaseOperations.OphalenSeizoenen();
        }

        private void btnSerieOverview_Click(object sender, RoutedEventArgs e)
        {
            if (datagridSeizoenen.SelectedItem is P_Seizoen seizoen)
            {
                Window SeizoenOverview = new SerieOverview(seizoen);
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
