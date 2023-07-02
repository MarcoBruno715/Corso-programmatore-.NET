
/*
Modifica codice: il giocatore ha a disposizione 5 tentativi

In questo esempio, viene utilizzata una variabile tentativi per definire il numero massimo di volte che l'utente può lanciare i dadi e una variabile conteggioTentativi per tenere traccia del numero di tentativi effettuati.
Viene utilizzato un ciclo while
*/


int soglia = 7;
int tentativi = 5;
int conteggioTentativi = 0;

while (conteggioTentativi < tentativi)
{
    conteggioTentativi++;

    Console.WriteLine("Tentativo #" + conteggioTentativi + ": premi INVIO");
    Console.ReadLine();

    Random random = new Random();
    int dado1 = random.Next(1, 7);
    int dado2 = random.Next(1, 7);
    int somma = dado1 + dado2;

    Console.WriteLine("Il risultato è: " + somma);

    if (somma > soglia)
    {
        Console.WriteLine("Lancio superiore a " + soglia);
        break;
    }
    else if (conteggioTentativi == tentativi)
    {
        Console.WriteLine("Hai esaurito i tuoi tentativi.");
     }
    else
    {
        Console.WriteLine("hai ancora " + (tentativi - conteggioTentativi) + " tentativi.");
    }
}

