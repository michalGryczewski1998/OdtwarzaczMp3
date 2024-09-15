using MusicPlayer.Odtwarzacz.OperacjeNaPliku;
using MusicPlayer.Odtwarzacz.Piosenka;
using System.Diagnostics;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private List<PiosenkaInfo> _listaPlikowPoPrzetworzeniu;
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddMusicMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 pliki (*.mp3)|*mp3";
            ofd.Title = "Wybierz mplik MP3";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> wybranePliki = new List<string>();

                foreach (var item1 in ofd.FileNames)
                {
                    wybranePliki.Add(item1);

#if DEBUG
                    Debug.WriteLine("Dodano do listy: " + item1);
#endif
                }

                var pozInfo = new PozyskanieInfo();
                _listaPlikowPoPrzetworzeniu = pozInfo.PozyskajInformacje(wybranePliki);

            }

        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
            MediaPlayer.URL = _listaPlikowPoPrzetworzeniu[0].Sciezka;
            MediaPlayer.Ctlcontrols.play();
        }
    }
}
