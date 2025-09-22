//esercizi della lezione 5--imparare i concetti base di gestione file, RICERCA, INFO E SOVRASCRITTURA
//
using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;



namespace LezioneUno
{
    class LezioneCinque
    {
        static bool CercaFile(string filename) { //CercaFile(string filename), Usa File.Exists per verificare se un file esiste o meno nel percorso dato. Restituisce true se il file è presente, false altrimenti.
            bool Risultato = false;

            Risultato=File.Exists(filename);
            return Risultato;
        }//CercaFile

        static void StampaInformazioniFile(string filename) //StampaInformazioniFile(string filename). Crea un oggetto FileInfo che rappresenta il file indicato.
        {
            //occorre utilizzaree la classe di dotneet System.IO.FileInfo
            System.IO.FileInfo fInfo = new System.IO.FileInfo(filename);
            //fInfo quindi deevo usaree il meetodo neew per crearlo
            //ee passaree il parameetro filename cosi valorizza tuttee le proprietà
            Console.WriteLine("Name:              {0}", fInfo.Name);
            Console.WriteLine("Extension:         {0}", fInfo.Extension);
            Console.WriteLine("FullName:          {0}", fInfo.FullName);
            Console.WriteLine("Exists:            {0}", fInfo.Exists);
            Console.WriteLine("Directory:         {0}", fInfo.Directory);
            Console.WriteLine("DirectoryName:     {0}", fInfo.DirectoryName);
            Console.WriteLine("IsReadOnly:        {0}", fInfo.IsReadOnly);
            Console.WriteLine("Creation Time:     {0}", fInfo.CreationTime);
            Console.WriteLine("LastAccessTime:    {0}", fInfo.LastAccessTime);
            Console.WriteLine("LastWriteTime:     {0}", fInfo.LastWriteTime);
            Console.WriteLine("CreationTimeUtc:   {0}", fInfo.CreationTimeUtc);
            Console.WriteLine("LastAccessTimeUtc: {0}", fInfo.LastAccessTimeUtc);
            Console.WriteLine("LastWriteTimeUtc:  {0}", fInfo.LastWriteTimeUtc);
            Console.WriteLine("Length:            {0}", fInfo.Length);
        }//StampaInformazioniFile

        static void Scrivi(string filename, string Testo) {
            StreamWriter sw = new StreamWriter(filename); // sovrascrive il file se non trova
            sw.WriteLine(Testo);
            sw.Close();
        }//Scrivi
        
        static void Scrivi10Righe(string filename)
        {
            string sTesto = "";
            StreamWriter sw = new StreamWriter(filename); //cancella il contenuto del file, ossia in sovrascrittura
            //se voglio conservare l attuale contenuto del file usare
            //StreamWriter sw = new StreamWriter(filename,true);
            //Write a line of text


            for (int i = 1; i <= 10; i++) {
                sTesto = "Scrivo la riga numero " + i; // aggiunge numero progressivo
                sw.WriteLine(sTesto);
            }

            sw.Close();
        }//Scrivi
        
        static void Log(string filename) {

            string sTesto = "";
            StreamWriter sw = new StreamWriter(filename,true);
             for (int i = 1; i <= 10; i++)
             {
                sTesto = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                sw.WriteLine(sTesto);
             }
             sw.Close();
        }//Log

        static void Log_con_using(string filename)
        {
            //piu performante del metodo precedente Log!
            string sTesto = "";
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                for (int i = 1; i <= 10; i++)
                {
                    sTesto = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    sw.WriteLine(sTesto);
                }
                //sw.close();
            }//using
        }//Log_con_using

        static void LeggiContenuto(string filename) {
            string sRiga = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((sRiga = sr.ReadLine()) != null)
                {
                    Console.WriteLine(sRiga);
                }
            }
        }//LeggiContenuto


        // static void LeggiLog(string filename) {
        //     using (StreamReader sr = new StreamReader(filename)) {
        //         string riga;
        //         while ((riga = sr.ReadLine()) != null) {
        //             Console.WriteLine(riga);
        //         }
        //     }
        // }//LeggiLog



        static void Main(string[] args) //main !!!!!!
        {
            Console.WriteLine("GESTIONE DEI FILES !");
            //vedere se un file esiste 

            // vedere se un file esiste 
            // usa un percorso valido per macOS (modificalo se preferisci un altro file)
            string percorso = "/Users/lorenzocassiani/Desktop/CSharp/LezioneUno/appunti.txt";

            bool esiste3 = CercaFile(percorso);
            bool esiste = File.Exists(@"c:\config.sys"); // lasciato invariato come nel tuo originale
            bool esiste2 = System.IO.File.Exists(percorso);

            Console.ReadKey(); //attende un INVIO !!! 1

            Console.WriteLine("Recuperare le informazioni relative a un file");
            StampaInformazioniFile(percorso);
            Console.ReadKey(); //attende un INVIO !!! 2.fatto, con info

            Console.WriteLine("SOVRAscrivere informazioni all interno del file");
            string sTesto = "prima riga del file";
            Scrivi(percorso, sTesto);
            Console.ReadKey();

            //extra:

            // Console.WriteLine("scrivere 10 righe all interno del file");
            // //Scrivi10Righe(percorso);
            // Log(percorso);
            // Console.ReadKey();

            Console.WriteLine("stampa in console il contenuto del file");
            Scrivi10Righe(percorso);
            Console.ReadKey();

            //fare la lettura del contenuto di un file

            // definizione dei file
            string nomeVecchio = "/Users/lorenzocassiani/Desktop/CSharp/LezioneUno/vecchio.txt";
            string nomeNuovo = "/Users/lorenzocassiani/Desktop/CSharp/LezioneUno/nuovo.txt";
            string fileDaCancellare = "/Users/lorenzocassiani/Desktop/CSharp/LezioneUno/daCancellare.txt";
            string fileDaCreare = "/Users/lorenzocassiani/Desktop/CSharp/LezioneUno/nuovoFile.txt";

            // 1 Rinomina il file, se esiste
            if (File.Exists(nomeVecchio))
            {
                File.Move(nomeVecchio, nomeNuovo);
                Console.WriteLine($"File rinominato: {nomeVecchio} → {nomeNuovo}");
            }

            // 2 Cancella il file, se esiste
            if (File.Exists(fileDaCancellare))
            {
                File.Delete(fileDaCancellare);
                Console.WriteLine($"File cancellato: {fileDaCancellare}");
            }

            // 3 Crea un nuovo file vuoto
            if (!File.Exists(fileDaCreare))
            {
                using (FileStream fs = File.Create(fileDaCreare))
                {
                    // qui il file viene creato vuoto
                }
                Console.WriteLine($"Nuovo file creato: {fileDaCreare}");
            }


            
            //---OPERAZIONI CON DIRECTORY E FILES
            //---CREARE UNA DIRECTORY
            //---SPOSATE NEELLA DIRECTORY I FILE DA C:\CORSO TALENT
            //---STAMPARE A VIDEO L'ELENCO GREZZO DEI FILES CONTENUTI NELLA DIRECTORY
            //---STAMPARE L'ELENCO DEI FILE DI UNA DIRECTORY ORGANIZZATI PER TIPOLOGIA

            //stampare a video/console l'eleenco dei file contenuti in una directory



            Console.WriteLine("fine del programma");
            Console.ReadKey();

        }
    }
}