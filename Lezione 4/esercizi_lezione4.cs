// lezione 4 - esercizi pomeriggio !!!!
//
using System;

namespace LezioneUno
{
    class LezioneQuattro
    {
        static void Main(string[] args)
        {
            // //esercizio 1
            // //
            // Console.WriteLine("--------Aritmetic operators in c# -----");

            // int a = 10;
            // int b = 30;

            // int sum = a + b;
            // int sumdiv = a / b;
            // int sumprod = a * b;
            // int sumsub = a - b;
            // int summod = a % b;
            // Console.WriteLine(sum);
            // Console.WriteLine(sumdiv);
            // Console.WriteLine(sumprod);
            // Console.WriteLine(sumsub);
            // Console.WriteLine(summod);

            // // string nome, cognome, nomecompleto;

            // Console.WriteLine("----comparison operators in c# -----");
            // int m = 10;
            // int n = 40;

            // //Console.WriteLine(); // Alt = ⬆️ || ⬇️ per spostare il codice

            // // Equal
            // Console.WriteLine(m == n); // false

            // // Not Equal
            // Console.WriteLine(m != n); // true

            // // Magiore di
            // Console.WriteLine(m > n); //fales

            // // Minore di
            // Console.WriteLine(m < n);// true

            // // Magiore o uguale a 
            // Console.WriteLine(m >= n); //false

            // // Minore o uguale a 
            // Console.WriteLine(m <= n); // true

            // //esercizio 2
            // //
            // // Condizoni multiple con operatori logici e di confronto 
            // int age = 18;
            // if ((age >= 18))
            // {
            //     Console.WriteLine("sei maggiorenne");
            // }
            // else
            // {
            //     Console.WriteLine("sei minorenne");
            // }

            // Console.WriteLine("-----Ternary Operator in C# ------");



            // // Ternary Operator
            // // un operatore che prende tre operandi e restituisce un valore basato su una condizione.
            // // Esempio: if else in una sola riga
            // int eta = 18;
            // string eligibility = (eta >= 18) ? "Eligible to vote" : "Not eligible to vote";
            // Console.WriteLine(eligibility);

            // // Gli Array in C# sono collezioni di elementi dello stesso tipo
            // int[] numeri = { 1, 2, 3, 4, 5 }; // Dichiarazione e inizializzazione di un array di tipo intero
            // //string[] nomi = new string[5];
            // string[] nomi = { "Moussa", "Marco", "Davide" };
            // double[] prezzi = new double[12];
            // char[] caratteri = { 'a', 'b', 'c', 'd' };


            // // Accesso agli elementi dell'array
            // Console.WriteLine(numeri[0]); // Stampa il primo elemento dell'array numeri (1)
            // Console.WriteLine(nomi[1]); // Stampa il secondo elemento dell'array nomi (Bob)
            // Console.WriteLine(prezzi.Length); // Stampa la lunghezza dell'array prezzi (5)
            // Console.WriteLine(caratteri[2]); // Stampa il terzo elemento dell'array caratteri (c)


            // Console.WriteLine("prima");
            // caratteri[3] = 'n';
            // Console.WriteLine(caratteri[3]); // Output: n

            // Console.WriteLine("dopo");
            // // Trasformare in maiuscolo
            // caratteri[3] = char.ToUpper(caratteri[3]);

            // Console.WriteLine(caratteri[3]); // Output: N

            //esercizio 3
            //
            // Console.WriteLine("inserisci un decimale: ");
            // int numeroDecimale = Convert.ToInt32(Console.ReadLine());
            // string numeroBinario = Convert.ToString(numeroDecimale, 2);
            // Console.WriteLine("Il numero binario è: " + numeroBinario);

            // const double IVA = 22.0; //costante
            // Console.WriteLine($"Il valore dell' IVA è: {IVA}");
            // //double IVA_2= 20.0; 

            List<string> listaSpesa = new List<string> {"pane", "marmellata","olive" };
            string nomeProdotto = listaSpesa[2];
            nomeProdotto = "pasta";
            Console.WriteLine(nomeProdotto);

            //fineLezione4 pomeriggio






            Console.ReadKey();
        }
    }
}