//esercizi con le matrici
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace LezioneUno
{
    class Lezionedue
    {
        static void Main(string[] args) // MAIN !! 
        {
            // //OPERATORI TERNARY
            // //Console.WriteLine("Inserisci il tuo voto:");
            // //string risposta = Console.ReadLine();

            // // int voto = 25; //I DUE PUNTI DIVENTANO UN "&" E IL PUNTO INTERROGATIVO UN "="
            // // string esito = (voto < 18) ? "Bocciato" : (voto < 24) ? "Sufficiente" 
            // //             : (voto < 28) ? "Buono" 
            // //             : "Ottimo";
            // // Console.WriteLine(esito);

            // //esercizi con array
            // int[] Numeri = {1,2,3,4,5};
            // string[] Nomi = {"Alice", "Bob", "Charlie", "Francesco"};
            // //double[] Prezzi = new double [] DA FINIRE UN'ALTRA VOLTA !!!!

            // // //altri ESERCIZI DA 16,30 IN POI
            // // int[,] matrice = { {1,2,3} ,{4,5,6} , {7,8,9} }; // Dichiarazione e inizializzazione di un array bidimensionale

            // // for (int i=0; i<3; i++) // Ciclo per le righe della matrice
            // // {
            // //     for (int j=0; j<3; j++) //ciclo colonne
            // //     {
            // //         Console.Write(matrice[i,j] + " ");
            // //     }
            // //     Console.WriteLine(); // Nuova riga dopo ogni riga della matrice
            // // }

            // //ora esercizio ARRAY 3D
            // string[,,] arrey3d = { { {"cane","gatto","topo"},{"elefante","leone","tigre"},{"orso","lupo","volpe"} }, { {"aquila","falco","gufo"},{"pinguino","squalo","delfino"},{"balena","polpo","stella marina" } }, { {"rana","serpente","lucertola"},{"coccodrillo","iguana","camaleonte"},{"tartaruga","cervo","alce"} } };

            // // Console.Write(array3d[1, 0, 1] + " ");

            // // for (int i = 0; i < 3; i++) // Ciclo per le "pagine" dell'array 3D
            // // {

            // //     for (int j = 0; j < 3; j++) // Ciclo per le righe
            // //     {
            // //         for (int k = 0; k < 3; k++) // Ciclo per le colonne
            // //         {
            // //             Console.Write(array3d[i, j, k] + " ");
            // //         }
            // //         Console.WriteLine(); // Nuova riga dopo ogni riga
            // //     }
            // //     Console.WriteLine(); // Nuova riga dopo ogni pagina
            // // }


            // //ESERCIZIO 3D MIO CON FORMATTZIONE TABELLA !!!!

            // // Array 3D con animali
            string[,,] array3d =
            {
                {
                    { "cane","gatto","topo" },
                    { "elefante","leone","tigre" },
                    { "orso","lupo","volpe" }
                },
                {
                    { "aquila","falco","gufo" },
                    { "pinguino","squalo","delfino" },
                    { "balena","polpo","stella marina" }
                },
                {
                    { "rana","serpente","lucertola" },
                    { "coccodrillo","iguana","camaleonte" },
                    { "tartaruga","cervo","alce" }
                }
            };

            // Calcolo la larghezza massima di una parola
            int maxLen = 0;
            foreach (var animale in array3d)
            {
                if (animale.Length > maxLen)
                    maxLen = animale.Length;
            }

            // Stampo le 3 "pagine" come tabelle 3x3
            for (int i = 0; i < 3; i++) // pagine
            {
                Console.WriteLine($"\n");

                for (int j = 0; j < 3; j++) // righe
                {
                    for (int k = 0; k < 3; k++) // colonne
                    {
                        string cella = array3d[i, j, k].PadRight(maxLen); // spaziatura uniforme
                        Console.Write($"| {cella} ");
                    }
                    Console.WriteLine("|"); // chiudo riga
                }

                Console.WriteLine(); // spazio tra le tabelle
            }

            //FINE LEZIONE POME 2
        }

    }
}