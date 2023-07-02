
/*
Semplice codice che verifica se i dadi sono uguali

In questo esempio, vengono generati due numeri casuali rappresentanti i due dadi utilizzando il metodo Next(min, max) della classe Random.
Successivamente, viene utilizzata una istruzione if-else per verificare se i due dadi sono uguali.
Se i dadi sono uguali, viene stampato un messaggio che indica che i dadi sono uguali, altrimenti viene stampato un messaggio che indica che i dadi non sono uguali.

*/
// Genera un numero casuale compreso tra 1 e 6
Random random = new Random();
int dado1 = random.Next(1, 7);
int dado2 = random.Next(1, 7);
// Stampa il risultato del lancio dei dadi
    Console.WriteLine("Lancio: " + dado1 + " e " + dado2);
// Verifica se i dadi sono uguali
if (dado1 == dado2)
{
    Console.WriteLine("I dadi sono uguali");
}
else
{
    Console.WriteLine("I dadi non sono uguali");
}
