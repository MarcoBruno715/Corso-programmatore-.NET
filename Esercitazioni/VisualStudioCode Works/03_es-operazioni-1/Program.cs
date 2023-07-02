/*******************************************************************************************************************
 *     QUESTO ESEMPIO MOSTRA COME UTILIZZARE OPERAZIONI MATEMATICHE IN C# PER CREARE UN PROGRAMMA CHE CALCOLI      *
 *           L'AREA E IL PERIMETRO DI UN QUADRATO IN BASE ALLA LUNGHEZZA DEL LATO INSERITA DALL'UTENTE.            *
 * SI POSSONO UTILIZZARE QUESTE FUNZIONALITÀ PER CREARE PROGRAMMI PIÙ COMPLESSI CHE EFFETTUANO CALCOLI MATEMATICI, *
 *                  COME CALCOLATRICI SCIENTIFICHE, PROGRAMMI DI SIMULAZIONE E MOLTO ALTRO ANCORA                  *
 *******************************************************************************************************************/
// metodo di input
Console.Write("Inserisci la lunghezza del lato del quadrato: ");
// leggo input come stringa
string input = Console.ReadLine();
// dichiaro variabile intera lato
int lato;
// dichiaro variabile boolean assegnando il valore di input
bool success = int.TryParse(input, out lato);
// condizione: se l'input è un numero intero
if (success)
{
    // dichiaro una variabile area ed assegno un valore
    int area = lato * lato;
    // dichiaro una variabile perimetro ed assegno un valore
    int perimetro = lato * 4;
    // stampo a video il risultato
    Console.WriteLine("L'area del quadrato è: " + area);
    Console.WriteLine("Il perimetro del quadrato è: " + perimetro);
}
// condizione: se l'input non è un numero intero
else
{
    // stampo a video il risultato
    Console.WriteLine("Input non valido!");
}