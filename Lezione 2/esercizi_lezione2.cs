//lezione 2 - esercizi in classe
namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (d1 != d2)
            //{
            //    // Condizioni <, >, <=, >=, ==, !=
            //    Console.WriteLine("Le date sono diverse");
            //}
            //else
            //{
            //    Console.WriteLine("Le date sono uguali");
            //}

            //string DataTestuale = "";
            //string Messaggio = "";




            ////inizio il codice
            //string s1 = "25-09-2025";
            //string s2 = "30-02-2025";

            //int voto = 8;
            //int votoMinimo = 6;
            //int votoMaximo = 5;
            //// string messaggio = (voto >= votoMinimo) ? "Promosso" : (voto <= votoMaximo) ? "Bocciato" : "Sospeso";

            //string messaggio;
            //if (voto >= votoMinimo)
            //{
            //    if (voto <= votoMaximo)
            //    {
            //        messaggio = "Promosso";
            //    }
            //    else
            //    {
            //        messaggio = "Sospeso";
            //    }
            //}
            //else
            //{
            //    messaggio = "Bocciato";
            //}

            //DateTime data1 = new DateTime();
            //DateTime data2 = new DateTime(2025, 10, 15);

            //try
            //{
            //    //tutto quello che viene scritto qui viene eseguito, e se c'è un errore va nel blocco catch
            //    //e trasforma data1 in una stringa
            //    //in caso di errore segnalare la data sbagliata
            //    Messaggio = "La data è corretta";
            //    data1 = Convert.ToDateTime(s1);
            //    Console.WriteLine(Messaggio);
            //    data2 = Convert.ToDateTime(s2);
            //    DataTestuale = data1.ToString("dd-MM-yyyy");
            //    DataTestuale = data2.ToString("dd-MM-yyyy");
            //}
            //catch (Exception ex)
            //{
            //    //qui arrivo in caso di errore
            //    Messaggio = ex.Message;
            //    Console.WriteLine(Messaggio);

            //}//catch

            //try
            //{
            //    // Verifica se le condizioni sono vere
            //    int num1 = 10;
            //    int num2 = 0;

            //    int risultato = num1 / num2;

            //    // Varifica se le condizioni sono vere
            //    if (risultato < 0)
            //    {
            //        Console.WriteLine("Il risultato è negativo.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Il risultato è positivo o zero.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Gestione dell'eccezione
            //    Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            //}

            //int - un tipo di dati
            // [] - operatore di indicizzazione 
            double[] mangoPrices = { 8.12, 6.23, 12.8, 5.78, 16.23 };
            for (int val = 0; val < mangoPrices.Length; val++)
            {
                Console.WriteLine(mangoPrices[val]);
            }

            // string nome = "Mario";
            // string cognome = "Rossi";
            // int eta = 30;

            // divesi metodi di comparazione < , >, <=, >=, ==, !=
            // && operatore logico AND



            //if (eta < 30 || eta > 30)
            //{
            //    Console.WriteLine("Mi chiampo " + nome + " " + cognome + " e ho " + eta + " anni.");
            //    Console.WriteLine($"Mi chiampo \'{nome}\' \'{cognome}\' e ho {eta} anni.");

            //}
            //else
            //{
            //    Console.WriteLine("Non hai 30 anni");
            //}







            // ++ operatore di incremento
            // -- operatore di decremento


            // string[] nomi = { "Mario", "Luigi", "Panca" };
            // for (int i = 0; i < nomi.Length; i++)
            // {
            //     Console.WriteLine(nomi[i]);
            // }

            Console.ReadKey();
        }
    }
}