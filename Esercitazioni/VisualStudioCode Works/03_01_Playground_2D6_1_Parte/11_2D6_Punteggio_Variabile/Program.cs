
/*
Gamification Modifica il codice: chi vince il lancio sottrae la somma del proprio lancio del punteggio dell’ opponente

*/


int punteggioGiocatore = 20;
int punteggioComputer = 20;
Random random = new Random();

Console.WriteLine("Il tuo punteggio iniziale è: " + punteggioGiocatore);
Console.WriteLine("Il punteggio iniziale del computer è: " + punteggioComputer);

while (punteggioGiocatore > 0 && punteggioComputer > 0)
{
    Console.WriteLine("Premi INVIO per lanciare i dadi contro il computer...");
    Console.ReadLine();

    int dado1Giocatore = random.Next(1, 7);
    int dado2Giocatore = random.Next(1, 7);
    int sommaGiocatore = dado1Giocatore + dado2Giocatore;

    Console.WriteLine("Il risultato del tuo lancio dei dadi è: " + sommaGiocatore);

    int dado1Computer = random.Next(1, 7);
    int dado2Computer = random.Next(1, 7);
    int sommaComputer = dado1Computer + dado2Computer;

    Console.WriteLine("Il risultato del computer è: " + sommaComputer);

    if (sommaGiocatore > sommaComputer)
    {
        Console.WriteLine("Hai vinto!");
        punteggioComputer -= sommaGiocatore;
    }
    else if (sommaComputer > sommaGiocatore)
    {
        Console.WriteLine("Hai perso!");
        punteggioGiocatore -= sommaComputer;
    }
    else
    {
        Console.WriteLine("Pareggio!");
    }
    Console.WriteLine("Il tuo punteggio attuale è: " + punteggioGiocatore);
    Console.WriteLine("Il punteggio attuale del computer è: " + punteggioComputer);
}
if (punteggioGiocatore < 0)
{
    Console.WriteLine("Hai perso!");
}
else if (punteggioComputer < 0)
{
    Console.WriteLine("Hai vinto!");
}
else
{
    Console.WriteLine("Qualcosa è andato storto...");
}


