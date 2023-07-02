/*
Funzione casuale nel test del codice
L'utilizzo della funzione casuale (random) è importante durante i test del codice per verificare il comportamento del programma in diverse situazioni e con diverse input.
Infatti, quando si scrive un programma, è importante considerare tutti i possibili input e scenari che possono verificarsi durante l'esecuzione del programma. L'utilizzo della funzione casuale può essere utile per generare input casuali e non prevedibili, in modo da testare il programma in modo più completo.
Ad esempio, se si sta scrivendo un programma che deve gestire una sequenza di numeri, è possibile utilizzare la funzione casuale per generare una serie di numeri casuali da utilizzare come input del programma.
In questo modo, si può verificare se il programma funziona correttamente con numeri diversi e non prevedibili, non solo con numeri specifici inseriti manualmente.

Inoltre, l'utilizzo della funzione casuale può aiutare a identificare eventuali errori o bug nel programma. Ad esempio, se
il programma produce risultati errati quando viene eseguito con numeri casuali, può essere un segnale che il programma non è stato scritto in modo corretto o che presenta qualche problema
*/
	// Generazione di un numero casuale
	Random random = new Random(); // Crea un oggetto di tipo Random
	// Genera un numero casuale tra 1 e 6
	int numero = random.Next(1, 7); // intervallo semi-aperto [1, 7)
	// Stampa il numero generato sulla console
	Console.WriteLine("Il numero generato è: " + numero);  

/*
In questo esempio, viene utilizzata la classe Random per generare un numero random tra 1 e 6.
Il metodo Next viene utilizzato per specificare l'intervallo di numeri da generare, con il primo parametro che rappresenta il valore minimo e il secondo parametro che rappresenta il valore massimo (escluso).
Il valore generato viene quindi memorizzato in una variabile di tipo int chiamata "numero", che viene utilizzata per stampare il numero generato sulla console.
Per eseguire il codice, è possibile copiarlo in un file di codice sorgente (ad esempio "Program.cs") all 'interno di un progetto in Visual Studio, quindi compilare ed eseguire il progetto.


In realtà, la funzione Random.Next(min, max) genera un numero casuale all'interno dell'intervallo semi-aperto [min, max), ovvero un intervallo che comprende il valore minimo e esclude il valore massimo.
Quindi, se si vuole generare un numero casuale tra 1 e 6 inclusi, è necessario impostare il valore di min a 1 e il valore di max a 7. In questo modo, l'intervallo semi-aperto [1, 7) corrisponderà all'intervallo chiuso [1, 6].
In sostanza, il valore 7 viene utilizzato come limite superiore dell'intervallo semi-aperto, ma poiché questo valore viene escluso dalla generazione di numeri casuali, l'intervallo effettivo è [1, 6].
*/