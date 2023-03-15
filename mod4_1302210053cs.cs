using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4_1302210053
{
    internal class mod4_1302210053cs
    {

        enum Buah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            jagung
        }

        private static string getKodeBuah(Buah inputbuah)
        {
            string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };

            return kodebuah[(int)inputbuah];

        }
        public static void Main(string[] args)
        {
            string output;
            Console.WriteLine(getKodeBuah(Buah.Apel));
            Console.WriteLine(getKodeBuah(Buah.Kelapa));
            Console.WriteLine(getKodeBuah(Buah.Pisang));
            Console.WriteLine(getKodeBuah(Buah.Blackberry));

        }
    }
}
