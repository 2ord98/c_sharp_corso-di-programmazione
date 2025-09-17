//ESERCIZI POMERIGGIO !!!! 
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;

namespace LezioneUno
{
    class Lezionetre
    {
        static void Main(string[] args)                
        {
            //esercizio 1

            List<int> listaNumerica = new List<int>(); //Creazione di una lista di interi
            listaNumerica.Add(122); //Aggiunta di un elemento alla lista

            //Console.WriteLine(listaNumerica[0]); //Stampa del primo elemento della lista

            //esercizio 2

            List<string> listaNomi = new();
            listaNomi.Add("anna");
            listaNomi.Add("marco");
            listaNomi.Add("luca");
            foreach (string nome in listaNomi)
            {
                Console.WriteLine(nome.ToUpper());
            }
   
            Console.ReadKey();

        }
    }
}
    
