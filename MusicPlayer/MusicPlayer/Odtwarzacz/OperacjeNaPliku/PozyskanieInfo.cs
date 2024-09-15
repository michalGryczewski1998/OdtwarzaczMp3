using MusicPlayer.Odtwarzacz.Piosenka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Odtwarzacz.OperacjeNaPliku
{
    public class PozyskanieInfo
    {
        public List<PiosenkaInfo> PozyskajInformacje(List<string> wybranePliki)
        {
            PiosenkaInfo piosenkaInfo;
            List<PiosenkaInfo> piosenkaInfoList = new List<PiosenkaInfo>();

            foreach (var item in wybranePliki)
            {
                var informacje = TagLib.File.Create(item);
                piosenkaInfo = new PiosenkaInfo
                {
                    Wykonawca = string.Join(",", informacje.Tag.Performers),
                    Tytul = informacje.Tag.Title,
                    Album = informacje.Tag.Album,
                    RokWydania = new DateTime((int)informacje.Tag.Year,1,1),
                    CzasTrwania = informacje.Properties.Duration,
                    Gatunek = string.Join(",", informacje.Tag.Genres),
                    Sciezka = informacje.Name
                };

                piosenkaInfoList.Add(piosenkaInfo);
            }

            return piosenkaInfoList;
        }
    }
}
