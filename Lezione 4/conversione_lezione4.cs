// lezione 4 - esercizio conversione
//versione 1---
using System;

namespace LezioneUno
{
    class LezioneQuattro
    {
        static void Main(string[] args)
        {
            int scelta = 0;

            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("   CONVERSIONE DEI SISTEMI DI NUMERAZIONE");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Convertire da BINARIO a DECIMALE");
                Console.WriteLine("2. Convertire da OTTALE a DECIMALE");
                Console.WriteLine("3. Convertire da ESADECIMALE a DECIMALE");
                Console.WriteLine("4. Fine programma");
                Console.Write("Scegli un'opzione (1-4): ");

                // Leggo la scelta
                if (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Input non valido, riprova.\n");
                    continue;
                }

                switch (scelta)
                {
                    case 1:
                        Console.Write("Inserisci il numero BINARIO: ");
                        string binario = Console.ReadLine();
                        try
                        {
                            int dec_Bin = Convert.ToInt32(binario, 2);
                            Console.WriteLine($"Il numero in decimale è: {dec_Bin}\n");
                        }
                        catch
                        {
                            Console.WriteLine("Errore: il numero inserito non è un binario valido.\n");
                        }
                        break;

                    case 2:
                        Console.Write("Inserisci il numero OTTALE: ");
                        string ottale = Console.ReadLine();
                        try
                        {
                            int dec_Ott = Convert.ToInt32(ottale, 8);
                            Console.WriteLine($"Il numero in decimale è: {dec_Ott}\n");
                        }
                        catch
                        {
                            Console.WriteLine("Errore: il numero inserito non è un ottale valido.\n");
                        }
                        break;

                    case 3:
                        Console.Write("Inserisci il numero ESADECIMALE che vuoi convertire: ");
                        string esadec = Console.ReadLine();
                        try
                        {
                            int dec_Hex = Convert.ToInt32(esadec, 16);
                            Console.WriteLine($"Il numero in decimale è: {dec_Hex}\n");
                        }
                        catch
                        {
                            Console.WriteLine("Errore: il numero inserito non è un esadecimale valido.\n");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Chiusura del programma in corso...");
                        break;

                    default:
                        Console.WriteLine("Scelta non valida, riprova.\n");
                        break;
                }

            } while (scelta != 4);
        }
    }
}
//fine programma !!!

//-----------------versione 2 - manuale
// 
// using System;

// namespace LezioneUno
// {
//     class LezioneQuattro
//     {
//         static void Main(string[] args)
//         {
//             int scelta = 0;

//             do
//             {
//                 Console.WriteLine("========================================");
//                 Console.WriteLine("   CONVERSIONE DEI SISTEMI DI NUMERAZIONE");
//                 Console.WriteLine("========================================");
//                 Console.WriteLine("1. Convertire da BINARIO a DECIMALE");
//                 Console.WriteLine("2. Convertire da OTTALE a DECIMALE");
//                 Console.WriteLine("3. Convertire da ESADECIMALE a DECIMALE");
//                 Console.WriteLine("4. Fine programma");
//                 Console.Write("Scegli un'opzione (1-4): ");

//                 // Leggo la scelta
//                 if (!int.TryParse(Console.ReadLine(), out scelta))
//                 {
//                     Console.WriteLine("Input non valido, riprova.\n");
//                     continue;
//                 }

//                 switch (scelta)
//                 {
//                     case 1:
//                         Console.Write("Inserisci il numero BINARIO: ");
//                         string binario = Console.ReadLine();
//                         int dec_Bin = BinarioADecimale(binario);
//                         Console.WriteLine($"Il numero in decimale è: {dec_Bin}\n");
//                         break;

//                     case 2:
//                         Console.Write("Inserisci il numero OTTALE: ");
//                         string ottale = Console.ReadLine();
//                         int dec_Ott = OttaleADecimale(ottale);
//                         Console.WriteLine($"Il numero in decimale è: {dec_Ott}\n");
//                         break;

//                     case 3:
//                         Console.Write("Inserisci il numero ESADECIMALE: ");
//                         string esadec = Console.ReadLine();
//                         int dec_Hex = EsadecimaleADecimale(esadec);
//                         Console.WriteLine($"Il numero in decimale è: {dec_Hex}\n");
//                         break;

//                     case 4:
//                         Console.WriteLine("Chiusura del programma in corso...");
//                         break;

//                     default:
//                         Console.WriteLine("Scelta non valida, riprova.\n");
//                         break;
//                 }

//             } while (scelta != 4);
//         }

//         // Funzione per convertire binario -> decimale
//         static int BinarioADecimale(string bin)
//         {
//             int dec = 0;
//             int potenza = 1; // 2^0
//             for (int i = bin.Length - 1; i >= 0; i--)
//             {
//                 if (bin[i] == '1') dec += potenza;
//                 potenza *= 2;
//             }
//             return dec;
//         }

//         // Funzione per convertire ottale -> decimale
//         static int OttaleADecimale(string ott)
//         {
//             int dec = 0;
//             int potenza = 1; // 8^0
//             for (int i = ott.Length - 1; i >= 0; i--)
//             {
//                 dec += (ott[i] - '0') * potenza;
//                 potenza *= 8;
//             }
//             return dec;
//         }

//         // Funzione per convertire esadecimale -> decimale
//         static int EsadecimaleADecimale(string hex)
//         {
//             int dec = 0;
//             int potenza = 1; // 16^0
//             for (int i = hex.Length - 1; i >= 0; i--)
//             {
//                 char c = hex[i];
//                 int valore = 0;

//                 if (c >= '0' && c <= '9')
//                     valore = c - '0';
//                 else if (c >= 'A' && c <= 'F')
//                     valore = c - 'A' + 10;
//                 else if (c >= 'a' && c <= 'f')
//                     valore = c - 'a' + 10;

//                 dec += valore * potenza;
//                 potenza *= 16;
//             }
//             return dec;
//         }
//     }
// }
// fine programma 2!!!


//versione 3 ----------- math powe
//
// using System;

// namespace LezioneUno
// {
//     class LezioneQuattro
//     {
//         static void Main(string[] args)
//         {
//             int scelta = 0;

//             do
//             {
//                 Console.WriteLine("========================================");
//                 Console.WriteLine("   CONVERSIONE DEI SISTEMI DI NUMERAZIONE");
//                 Console.WriteLine("========================================");
//                 Console.WriteLine("1. Convertire da BINARIO a DECIMALE");
//                 Console.WriteLine("2. Convertire da OTTALE a DECIMALE");
//                 Console.WriteLine("3. Convertire da ESADECIMALE a DECIMALE");
//                 Console.WriteLine("4. Fine programma");
//                 Console.Write("Scegli un'opzione (1-4): ");

//                 if (!int.TryParse(Console.ReadLine(), out scelta))
//                 {
//                     Console.WriteLine("Input non valido, riprova.\n");
//                     continue;
//                 }

//                 switch (scelta)
//                 {
//                     case 1:
//                         Console.Write("Inserisci il numero BINARIO: ");
//                         string binario = Console.ReadLine();
//                         int dec_Bin = BinarioADecimale(binario);
//                         Console.WriteLine($"Il numero in decimale è: {dec_Bin}\n");
//                         break;

//                     case 2:
//                         Console.Write("Inserisci il numero OTTALE: ");
//                         string ottale = Console.ReadLine();
//                         int dec_Ott = OttaleADecimale(ottale);
//                         Console.WriteLine($"Il numero in decimale è: {dec_Ott}\n");
//                         break;

//                     case 3:
//                         Console.Write("Inserisci il numero ESADECIMALE: ");
//                         string esadec = Console.ReadLine();
//                         int dec_Hex = EsadecimaleADecimale(esadec);
//                         Console.WriteLine($"Il numero in decimale è: {dec_Hex}\n");
//                         break;

//                     case 4:
//                         Console.WriteLine("Chiusura del programma in corso...");
//                         break;

//                     default:
//                         Console.WriteLine("Scelta non valida, riprova.\n");
//                         break;
//                 }

//             } while (scelta != 4);
//         }

//         // Funzione binario -> decimale usando Math.Pow
//         static int BinarioADecimale(string bin)
//         {
//             int dec = 0;
//             int len = bin.Length;
//             for (int i = 0; i < len; i++)
//             {
//                 if (bin[i] == '1')
//                 {
//                     dec += (int)Math.Pow(2, len - i - 1);
//                 }
//             }
//             return dec;
//         }

//         // Funzione ottale -> decimale usando Math.Pow
//         static int OttaleADecimale(string ott)
//         {
//             int dec = 0;
//             int len = ott.Length;
//             for (int i = 0; i < len; i++)
//             {
//                 dec += (ott[i] - '0') * (int)Math.Pow(8, len - i - 1);
//             }
//             return dec;
//         }

//         // Funzione esadecimale -> decimale usando Math.Pow
//         static int EsadecimaleADecimale(string hex)
//         {
//             int dec = 0;
//             int len = hex.Length;
//             for (int i = 0; i < len; i++)
//             {
//                 char c = hex[i];
//                 int valore = 0;

//                 if (c >= '0' && c <= '9') valore = c - '0';
//                 else if (c >= 'A' && c <= 'F') valore = c - 'A' + 10;
//                 else if (c >= 'a' && c <= 'f') valore = c - 'a' + 10;

//                 dec += valore * (int)Math.Pow(16, len - i - 1);
//             }
//             return dec;
//         }
//     }
// }
// fine programma 3!!!
