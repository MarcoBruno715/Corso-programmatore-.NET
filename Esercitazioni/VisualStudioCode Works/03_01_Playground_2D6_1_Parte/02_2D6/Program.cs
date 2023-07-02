
/*
Semplice codice per visualizzare il risultato del lancio di due dadi in console
In questo esempio, viene utilizzata la classe Random per generare il risultato del lancio di due dadi. Sono
generati due numeri casuali compresi tra 1 e 6 utilizzando il metodo Next(min, max) e memorizzati nelle variabili
dado1 e dado2. Il valore della somma dei due dadi viene poi calcolato e memorizzato nella variabile somma.
Infine, il risultato del lancio dei dadi viene stampato sulla console utilizzando il metodo Console.WriteLine().

*/

	// Genera un numero casuale compreso tra 1 e 6
	Random random = new Random();
	// Genera un numero casuale compreso tra 1 e 6
	int dado1 = random.Next(1, 7);
	int dado2 = random.Next(1, 7);
	// Calcola la somma dei due dadi
	int somma = dado1 + dado2;
	
	// Stampa il risultato del lancio dei dadi
	Console.WriteLine("Primo Dado: " + dado1);
	Console.WriteLine("Secondo Dado: " + dado2);
	Console.WriteLine("Lancio: " + somma);
