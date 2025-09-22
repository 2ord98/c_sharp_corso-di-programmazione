//esercizi della lezione 5 -- Tipo Unumerato !!!
//
using System;

namespace LezioneUno
{
    class LezioneCinque
    {
        
        enum Mesi { 
            x,Gennaio,Febbraio,Marzo,Aprile,Maggio, Giugno,Luglio,Agosto,Settembre,Ottobre,Novembre,Dicembre
        }
        enum Trimestre { 
        Gennaio=1,
        Febbraio=1,
        Marzo=1,
        Aprile=2,
        Maggio=2,
        Giugno=2,
        Luglio=3
        }

        public enum StatoPratica // vedi il campo tipo
        {
            APERTO = 0,
            CHIUSO = 8,
            SCARTATO = 1,
            APERTOSOLLECITATO = 2,
            RIENTRATO = 3,
            ANNULLATO = 4,
            RIFIUTATO = 5,
            PREAVVISO = 6,
            SCADUTO = 7,
            INATTESA = 9,
            INCODA = 10
            //mettere gli altri record di statopratica
        }
        public enum TipoComunicazione
        {
            SMS = 1,
            EMAIL = 2,
            CHAT = 3
        }

        static void Main(string[] args)
        {

            //string Mese;
            Console.WriteLine("Inserisci il mese (es: Gennaio, Febbraio,...):");
            string input = Console.ReadLine(); //input da tastiera
            //int MeseANumero = 0;
            string stagione = "";

            Mesi MeseCorrente = (Mesi)Enum.Parse(typeof(Mesi), input, true);

            // Mesi MeseCorrente=Mesi.Settembre;

            // Mese = Mesi.Settembre.ToString();

            // int iMese;
            // iMese = (int)Mesi.Settembre;

            TipoComunicazione comUtente;
            comUtente=TipoComunicazione.EMAIL;
            int iCodice;
            iCodice = (int)comUtente;

            string sDescrizione = "";
            sDescrizione = comUtente.ToString();

            switch (MeseCorrente)
            {
                case Mesi.Gennaio:
                case Mesi.Febbraio:
                case Mesi.Dicembre:
                    stagione = "inverno";
                    break;
                case Mesi.Marzo:
                case Mesi.Aprile:
                case Mesi.Maggio:
                    stagione = "primavera";
                    break;
                case Mesi.Giugno:
                case Mesi.Luglio:
                case Mesi.Agosto:
                    stagione = "estate";
                    break;
                case Mesi.Settembre:
                case Mesi.Ottobre:
                case Mesi.Novembre:
                    stagione = "autunno";
                    break;


            }//switch

            Console.WriteLine("siamo nella stagione: "+stagione);
            Console.ReadKey();//premi un tasto x terminare

            // Trimestre trimestre;
            // trimestre = Trimestre.Aprile;
            // int iTrimeste = (int)trimestre;
            // Console.WriteLine("siamo nel trimestre numero " + iTrimeste);

            Console.ReadKey();


        }
    }
}