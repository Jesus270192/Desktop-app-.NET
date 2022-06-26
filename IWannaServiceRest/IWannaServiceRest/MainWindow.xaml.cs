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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IWannaServiceRest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Spotify.Spotify spotify = new Spotify.Spotify(BodyRest.PROTOCOL.Https, "api.spotify.com/","", "v1/artists/1vCWHaC5f2uS3yhpwWbIA6/albums", "?album_type=SINGLE&offset=20&limit=10", BodyRest.METHOD.GET);

            spotify.doRequest();
        }
    }
}
