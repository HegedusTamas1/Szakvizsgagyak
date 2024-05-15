using System;
using System.IO;
using Common;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0 || args.Length < 2)
                {
                    Console.WriteLine("Hiba!");
                    Console.WriteLine("Helyes használat: LogLoader.exe -InputFile systemlog.log");
                    return;
                }

                string inputFile = args[1];
                if (!File.Exists(inputFile))
                {
                    Console.WriteLine("Hiba!");
                    Console.WriteLine("Ez a fájl nem található: " + inputFile);
                    return;
                }

                using (Common.MyWorldDbContext.SQL sql = new Common.MyWorldDbContext.SQL())
                {
                    using (StreamReader sr = new StreamReader(inputFile))
                    {
                        int sorokSzama = 0;
                        int beolvasottakSzama = 0;
                        string sor;

                        // Első sort kihagyjuk
                        sr.ReadLine();

                        while ((sor = sr.ReadLine()) != null)
                        {
                            sorokSzama++;

                            string[] szetvagva = sor.Split(";");
                            if (szetvagva.Length < 8)
                            {
                                Console.WriteLine($"Hiba a(z) {sorokSzama}. sorban: Nem megfelelő számú mező.");
                                continue;
                            }

                            logentries bejegyzes = new logentries();
                            bejegyzes.id = int.Parse(szetvagva[0]);
                            bejegyzes.CorrelationId = szetvagva[1];
                            bejegyzes.DateUTC = DateTime.Parse(szetvagva[2]);
                            bejegyzes.Thread = int.Parse(szetvagva[3]);
                            bejegyzes.Level = szetvagva[4];
                            bejegyzes.Logger = szetvagva[5];
                            bejegyzes.Message = szetvagva[6];
                            bejegyzes.Exception = szetvagva[7];

                            sql.LogEntries.Add(bejegyzes);
                            sql.SaveChanges();

                            beolvasottakSzama++;
                        }
                        Console.WriteLine("Fájl neve: " + inputFile);
                        Console.WriteLine("Fájlban lévő sorok száma: " + sorokSzama);
                        Console.WriteLine("Beolvasott sorok száma: " + beolvasottakSzama);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
