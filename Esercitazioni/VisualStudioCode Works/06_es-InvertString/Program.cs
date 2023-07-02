/***********************************************************************************************************************
 *             QUESTO ESEMPIO MOSTRA COME CREARE UNA FUNZIONE AUSILIARIA IN C# PER INVERTIRE UNA STRINGA.              *
 * SI POSSONO UTILIZZARE QUESTE FUNZIONALITÀ PER PROGRAMMI CHE MANIPOLANO TESTO, COME PROGRAMMI DI CRITTOGRAFIA,        *
 *                       PROGRAMMI DI ELABORAZIONE DEL LINGUAGGIO NATURALE E MOLTO ALTRO ANCORA                        *
 ***********************************************************************************************************************/

static void Main(string[] args)          //Entry Point
{
    Console.Write("Inserisci una stringa: "); // Stampa
    string input = Console.ReadLine();        // leggo output

    string reversed = ReverseString(input);   //funzione 
    Console.WriteLine("La stringa invertita è: " + reversed); 
}

static string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}