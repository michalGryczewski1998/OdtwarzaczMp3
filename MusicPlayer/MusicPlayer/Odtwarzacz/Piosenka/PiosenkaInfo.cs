using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Odtwarzacz.Piosenka
{
    public class PiosenkaInfo
    {
        public string Wykonawca { get; set; }
        public string Tytul { get; set; }
        public string Album { get; set; }
        public DateTime RokWydania { get; set; }
        public TimeSpan CzasTrwania { get; set; } = TimeSpan.MinValue;
        public string Gatunek { get; set; }
        public string Sciezka { get; set; }

    }
}
