
/*
Semplice codice che verifica se la somma dei dadi è superiore ad un determinato numero
In questo esempio, viene utilizzato lo stesso codice per generare il risultato del lancio di due dadi, ma viene aggiunta una variabile soglia che indica il
valore minimo che la somma dei dadi deve superare per considerarsi valida.
Dopo aver calcolato la somma dei dadi, viene utilizzata una istruzione if-else per verificare se la somma è maggiore della soglia.
Se la somma è maggiore della soglia, viene stampato un messaggio indicando che la somma è superiore alla soglia, altrimenti viene stampato un messaggio che indica che la somma non è superiore alla soglia.

*/

		// Genera un numero casuale compreso tra 1 e 6
		Random random = new Random();
		int dado1 = random.Next(1, 7);
		int dado2 = random.Next(1, 7);
		// Calcola la somma dei due dadi
		int somma = dado1 + dado2;
		// Soglia minima per considerare il lancio valido
		int soglia = 7;

			Console.WriteLine("Il risultato del lancio dei dadi è: " + somma);

		if (somma > soglia)
		{
			Console.WriteLine("Lancio superiore a " + soglia);
		}
		else
		{
			Console.WriteLine("Lancio non superiore a " + soglia);
		}
