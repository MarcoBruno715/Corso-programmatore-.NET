
/*

In questo esempio, viene utilizzata la funzione Console.ReadLine() per attendere che l'utente schiacci "INVIO" per lanciare i dadi.
Dopo il lancio dei dadi, viene generata la somma dei dadi e viene verificato se la somma è superiore alla soglia.
Se la somma è maggiore della soglia, viene stampato un messaggio indicando che la somma è superiore alla soglia,
altrimenti viene stampato un messaggio che indica che la somma non è superiore alla soglia.

*/
// Genera un numero casuale compreso tra 1 e 6
Console.WriteLine("Premi INVIO per lanciare i dadi...");
// Attende che l'utente schiacci "INVIO"
Console.ReadLine();
// Genera un numero casuale compreso tra 1 e 6
Random random = new Random();
int dado1 = random.Next(1, 7);
int dado2 = random.Next(1, 7);
int somma = dado1 + dado2;
// Soglia minima per considerare il lancio valido
int soglia = 7;

	Console.WriteLine("Il risultato è: " + somma);

if (somma > soglia)
{
	Console.WriteLine("Lancio superiore alla soglia di " + soglia);
}
else
{
	Console.WriteLine("Lancio non è superiore alla soglia di " + soglia);
}
