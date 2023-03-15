public class Program
{
    enum Buah {
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

    private static string getKodeBuah(Buah inputbuah) {
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


