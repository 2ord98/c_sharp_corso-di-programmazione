namespace GestioneFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Progetti\CSharp\GesttioneFile02\GesttioneFile02\studenti.csv";
            // Leggere il contenuto del file
            using (StreamReader reader = new(filePath))
            {
                string? line;
                // Leggi il file vericando il contenuto
                while ((line = reader.ReadLine()) != null)
                {
                    string[] campi = line.Split(',');
                    Console.WriteLine($"Nome: {campi[0]}, voto: {campi[1]}");
                }
            }

            Console.WriteLine("Vuoi aggiungere un nuovo voto studente? (si/no):");

            string? risposta = Console.ReadLine().Trim();
            // Verifico se l'utente ha scelto si / no
            if (risposta != "si")
            {
                Console.WriteLine("Nessune dato aggiunto. Programma terminato.👋");
            }

            // Scrìvere nel file
            using (StreamWriter writer = new(filePath, append: true))
            {
                while (true)
                {
                    Console.Write("Inserisci Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Inserisci Voto: ");
                    string voto = Console.ReadLine();

                    writer.WriteLine($"{nome},{voto}");

                    Console.Write("Vuoi inserire un altro studente? (si/no): ");
                    risposta = Console.ReadLine().Trim().ToLower();
                    if (risposta != "si")
                    {
                        break;
                    }
                }
            }

            // Attesa dell'input dell'utente prima di chiudere
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}